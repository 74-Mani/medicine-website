USE [Medical]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReportMedicineIOByMonth]    Script Date: 04/15/2013 09:55:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[sp_ReportMedicineIOByMonth]
@ClinicId as int,
@Month as datetime	
as 
begin
	declare @NgayDauKy as datetime
	set @NgayDauKy = DATEADD(dd, 0, DATEDIFF(dd, 0, DATEADD(dd,-(DAY(@Month)-1),@Month)))
	
	declare @NgayCuoiKy as datetime
	set @NgayCuoiKy = DATEADD(d,-1, DATEADD(mm, DATEDIFF(mm, 0 ,@Month)+1, 0))
	
	--if @NgayCuoiKy > GETDATE() 
	--begin
	--	set @ngayCuoiKy = GETDATE()
	--end	
	
	-- Delete 
	Delete from _ReportMedicineIOByMonth where ClinicId = @ClinicId and MonthYear = @Month
	
	-- Insert MedicineId
	insert into _ReportMedicineIOByMonth(ClinicId,MedicineId,MonthYear,MedicineVolumn)
	select distinct @ClinicId, MedicineId,@Month,Volumn from WareHouse
	where ClinicId = @ClinicId
 
	-- Update Medicine Name, Unit, Volumn
	update _ReportMedicineIOByMonth
	set MedicineName = Medicine.Name,
	TradeName = Medicine.TradeName,
	MedicineUnit = de.Name,
	MedicineVolumn = Medicine.Content
	from _ReportMedicineIOByMonth
	inner join Medicine on _ReportMedicineIOByMonth.MedicineId = Medicine.Id
	inner join Define de on de.Id = Medicine.Unit
	where _ReportMedicineIOByMonth.ClinicId = @ClinicId

	
	-- Update Medicine Price
	update _ReportMedicineIOByMonth
	set MedicineUnitPriceId = (select top 1 ID from MedicineUnitPrice a where a.MedicineId = _ReportMedicineIOByMonth.MedicineId
				and @Month between a.StartDate and ISNULL(a.EndDate,'4000-01-01')  Order by EndDate desc)
				
	-- Update UnitPrice
	/*update _ReportMedicineIOByMonth
	set MedicineUnitPrice = MedicineUnitPrice.UnitPrice,
	MedicinePrice = MedicineVolumn * MedicineUnitPrice.UnitPrice
	from _ReportMedicineIOByMonth
	inner join MedicineUnitPrice on _ReportMedicineIOByMonth.MedicineId = MedicineUnitPrice.Id
	*/
	update _ReportMedicineIOByMonth
	set MedicineUnitPrice = whIODetail.UnitPrice,
	MedicinePrice = MedicineVolumn *  whIODetail.UnitPrice
	from _ReportMedicineIOByMonth
	inner join WareHouseIO whIO on _ReportMedicineIOByMonth.ClinicId = whIO.ClinicId 
	inner join WareHouseIODetail whIODetail on whIO.Id = whIODetail.WareHouseIOId
	where 	 _ReportMedicineIOByMonth.ClinicId = @ClinicId
			and whIO.ClinicId = @ClinicId
			and _ReportMedicineIOByMonth.MedicineId = whIODetail.MedicineId
			and whIO.Date between @NgayDauKy and @ngayCuoiKy
	
	
	--	Update MedicineInput
	Update _ReportMedicineIOByMonth
	set MedicineInputVolumn = (select SUM(isnull(whIODetail.Qty,0)) from WareHouseIO whIO inner join WareHouseIODetail whIODetail on whIO.Id = whIODetail.WareHouseIOId 
								where  _ReportMedicineIOByMonth.ClinicId = whIO.ClinicId
									and whIO.ClinicId = @ClinicId
									and _ReportMedicineIOByMonth.MedicineId = whIODetail.MedicineId
									and whIO.CreatedDate between @NgayDauKy and @ngayCuoiKy 
									and whIO.Type = '0'),
	
	MedicineInputPrice = (select SUM(isnull(whIODetail.Amount,0)) from WareHouseIO whIO inner join WareHouseIODetail whIODetail on whIO.Id = whIODetail.WareHouseIOId 
								where _ReportMedicineIOByMonth.ClinicId = whIO.ClinicId
									and whIO.ClinicId = @ClinicId
									and _ReportMedicineIOByMonth.MedicineId = whIODetail.MedicineId
									and whIO.CreatedDate between @NgayDauKy and @ngayCuoiKy 
									and whIO.Type = '0'),
	SumVolumnInputOpeningStock = (select SUM(isnull(whIODetail.Qty,0)) from WareHouseIO whIO inner join WareHouseIODetail whIODetail on whIO.Id = whIODetail.WareHouseIOId 
								where _ReportMedicineIOByMonth.ClinicId = whIO.ClinicId
									and _ReportMedicineIOByMonth.MedicineId = whIODetail.MedicineId
									and whIO.CreatedDate < @ngayCuoiKy 
									and whIO.Type = '0')
																
	--	Update MedicineOutput
	Update _ReportMedicineIOByMonth
	set MedicineOutputVolumn = (select SUM(isnull(whIODetail.Qty,0)) from WareHouseIO whIO inner join WareHouseIODetail whIODetail on whIO.Id = whIODetail.WareHouseIOId 
								where _ReportMedicineIOByMonth.ClinicId = whIO.ClinicId
									and whIO.ClinicId = @ClinicId
									and _ReportMedicineIOByMonth.MedicineId = whIODetail.MedicineId
									and whIO.CreatedDate between @NgayDauKy and @ngayCuoiKy 
									and whIO.Type = '1'),
	
	MedicineOutputPrice = (select SUM(isnull(whIODetail.Amount,0)) from WareHouseIO whIO inner join WareHouseIODetail whIODetail on whIO.Id = whIODetail.WareHouseIOId 
								where _ReportMedicineIOByMonth.ClinicId = whIO.ClinicId
									and whIO.ClinicId = @ClinicId
									and _ReportMedicineIOByMonth.MedicineId = whIODetail.MedicineId
									and whIO.CreatedDate between @NgayDauKy and @ngayCuoiKy 
									and whIO.Type = '1'),	
	
	 SumVolumnOutputOpeningStock = (select SUM(isnull(whIODetail.Qty,0)) from WareHouseIO whIO inner join WareHouseIODetail whIODetail on whIO.Id = whIODetail.WareHouseIOId 
								where _ReportMedicineIOByMonth.ClinicId = whIO.ClinicId
									and whIO.ClinicId = @ClinicId
									and _ReportMedicineIOByMonth.MedicineId = whIODetail.MedicineId
									and whIO.CreatedDate < @NgayDauKy 
									and whIO.Type = '1')
	
	
	
	-- Update ton kho dau ky
	Update _ReportMedicineIOByMonth
	set OpeningStock = isnull(SumVolumnInputOpeningStock,0) -  isnull(SumVolumnOutputOpeningStock,0),
	ClosingStock =  isnull(OpeningStock,0) + isnull(MedicineInputVolumn,0) - isnull(MedicineOutputVolumn,0)
									
	select * from 	_ReportMedicineIOByMonth where ClinicId = @ClinicId and MonthYear = @Month														
end



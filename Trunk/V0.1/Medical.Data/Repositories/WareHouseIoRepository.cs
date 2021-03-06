﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using Medical.Data.Entities;
using IsolationLevel = System.Transactions.IsolationLevel;


namespace Medical.Data.Repositories
{
    public class WareHouseIORepository : RepositoryBase, IWareHouseIORepository
    {

        public WareHouseIO Get(int id)
        {
            var whPaper = this.Context.WareHouseIO.FirstOrDefault(x => x.Id.Equals(id));
            return whPaper;
        }

        public WareHouseIO GetById(int id)
        {
            var whPaper = this.Context.WareHouseIO.FirstOrDefault(x => x.Id.Equals(id));
            return whPaper;
        }

        public void WarehouseInputRegister(WareHouseIO wareHouseIO, List<WareHouseIODetail> warehouseIODetails)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                wareHouseIO.SetInfo(false);
                this.Context.WareHouseIO.Add(wareHouseIO);
                this.Context.SaveChanges();

                var medicineDictionary = new Dictionary<int, int>();
                foreach (var wareHouseIoDetail in warehouseIODetails)
                {
                    wareHouseIoDetail.WareHouseIOId = wareHouseIO.Id;
                    wareHouseIoDetail.SetInfo(false);
                    this.Context.WareHouseIODetail.Add(wareHouseIoDetail);

                    if (medicineDictionary.ContainsKey(wareHouseIoDetail.MedicineId))
                    {
                        medicineDictionary[wareHouseIoDetail.MedicineId] += wareHouseIoDetail.Qty;
                        continue;
                    }
                    medicineDictionary.Add(wareHouseIoDetail.MedicineId, wareHouseIoDetail.Qty);
                }
                this.Context.SaveChanges();

                foreach(var item in medicineDictionary.Keys)
                {
                    var warehouse = this.Context.WareHouses.FirstOrDefault(x => x.MedicineId == item && x.ClinicId == AppContext.CurrentClinic.Id);
                    if (warehouse == null) 
                    {
                        warehouse = new WareHouse()
                                        {
                                            ClinicId = AppContext.CurrentClinic.Id,
                                            MedicineId = item,
                                            Volumn = medicineDictionary[item],
                                            MinAllowed = 0
                                        };
                        this.Context.WareHouses.Add(warehouse);
                        this.Context.SaveChanges();
                    } 
                    else 
                    {
                        warehouse.Volumn += medicineDictionary[item];
                    }
                    

                    foreach (var warehouseIoDetail in warehouseIODetails)
                    {
                        if (warehouseIoDetail.MedicineId != item) continue;
                        var warehouseDetail = new WareHouseDetail
                                                  {
                                                      WareHouseId = warehouse.Id,
                                                      MedicineId = warehouseIoDetail.MedicineId,
                                                      Unit = warehouseIoDetail.Unit,
                                                      UnitPrice = warehouseIoDetail.UnitPrice ?? 0,
                                                      LotNo = warehouseIoDetail.LotNo,
                                                      ExpiredDate = warehouseIoDetail.ExpireDate,
                                                      WareHouseIODetailId = warehouseIoDetail.Id,
                                                      OriginalVolumn = warehouseIoDetail.Qty,
                                                      CurrentVolumn = warehouseIoDetail.Qty
                                                  };
                        warehouseDetail.SetInfo(false);
                        this.Context.WareHouseDetails.Add(warehouseDetail);
                    }
                    
                }
                this.Context.SaveChanges();
                scope.Complete();
            }
        }

        public void WarehouseOutputRegister(WareHouseIO wareHouseIO, List<WareHouseIODetail> warehouseIODetails)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                wareHouseIO.SetInfo(false);
                this.Context.WareHouseIO.Add(wareHouseIO);
                this.Context.SaveChanges();

                var medicineDictionary = new Dictionary<int, int>();
                foreach (var wareHouseIoDetail in warehouseIODetails)
                {
                    wareHouseIoDetail.WareHouseIOId = wareHouseIO.Id;
                    wareHouseIoDetail.SetInfo(false);
                    this.Context.WareHouseIODetail.Add(wareHouseIoDetail);

                    if (medicineDictionary.ContainsKey(wareHouseIoDetail.MedicineId))
                    {
                        medicineDictionary[wareHouseIoDetail.MedicineId] += wareHouseIoDetail.Qty;
                        continue;
                    }
                    medicineDictionary.Add(wareHouseIoDetail.MedicineId, wareHouseIoDetail.Qty);
                }
                this.Context.SaveChanges();

                // var allocatedList = new List<WareHouseExportAllocate>();
                foreach (var item in medicineDictionary.Keys)
                {
                    var warehouse = this.Context.WareHouses.FirstOrDefault(x => x.MedicineId == item && x.ClinicId == AppContext.CurrentClinic.Id);
                    var validWarehouseIODetail = this.Context.VWarehouseDetailFull.Where(x => x.MedicineId == item && x.ClinicId == AppContext.CurrentClinic.Id && (x.Date == null || x.Date <= wareHouseIO.Date) && x.CurrentVolumn > 0).Select(x => x.Id).ToList<int>();
                    var warehouseDetailList = this.Context.WareHouseDetails.Where(x => validWarehouseIODetail.Contains(x.Id)).ToList();
                    var warehouseOutputDetail = warehouseIODetails.Where(x => x.MedicineId == item).ToList();
                    foreach (var outputItem in warehouseOutputDetail)
                    {
                        var qty = outputItem.Qty;
                        foreach(var detail in warehouseDetailList)
                        {
                            if (!detail.LotNo.Equals(outputItem.LotNo)) continue;
                            var allotcateItem = new WareHouseExportAllocate
                                                    {
                                                        WareHouseDetailId = detail.Id,
                                                        WareHouseIODetailId = outputItem.Id,
                                                        Unit = outputItem.Unit,
                                                        Volumn = detail.CurrentVolumn > qty ? qty : detail.CurrentVolumn,
                                                        Version = 0
                                                    };

                            // allocatedList.Add(allotcateItem);
                            this.Context.WareHouseExportAllocates.Add(allotcateItem);
                            qty -= allotcateItem.Volumn;
                            detail.CurrentVolumn -= allotcateItem.Volumn;
                            detail.SetInfo(true);
                            warehouse.Volumn -= allotcateItem.Volumn;
                            warehouse.SetInfo(true);
                            if (qty == 0) break;
                        }

                        if (qty != 0) throw new Exception("Số lượng thuốc đã bị lệch trong lúc thay đổi, hãy chọn lại số lượng cho khớp.");
                    }
                }
                
                this.Context.SaveChanges();
                scope.Complete();
            }
        }

        public void Insert(WareHouseIO whIo)
        {
            whIo.CreatedUser = AppContext.LoggedInUser.Id;
            whIo.CreatedDate = DateTime.Now;
            whIo.Version = 0;
            this.Context.WareHouseIO.Add(whIo);
            this.Context.SaveChanges();
        }

        public void Update(WareHouseIO whIo)
        {
            try
            {
                var oldwhPaper = this.Context.WareHouseIO.FirstOrDefault(x => x.Id == whIo.Id);
                if (oldwhPaper == null) return;
                oldwhPaper.Type = whIo.Type;
                oldwhPaper.ClinicId = whIo.ClinicId;
                oldwhPaper.CreatedUser = whIo.CreatedUser;
                oldwhPaper.CreatedDate = whIo.CreatedDate;
                oldwhPaper.Date = whIo.Date;
                oldwhPaper.No = whIo.No;
                // oldwhPaper.Recipient = whIo.Recipient;
                // oldwhPaper.Deliverer = whIo.Deliverer;
                oldwhPaper.Note = whIo.Note;
                // oldwhPaper.LastUpdatedUser = 1;
                // oldwhPaper.LastUpdatedUser = AppContext.LoggedInUser.Id;
                // oldwhPaper.LastUpdatedDate = DateTime.Now;
                oldwhPaper.Version++;
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void Delete(int id)
        {
            try
            {
                var oldwhPaper = this.Context.WareHouseIO.FirstOrDefault(x => x.Id == id);
                this.Context.WareHouseIO.Remove(oldwhPaper);
                this.Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public List<WareHouseIO> GetAll()
        {
            try
            {
                List<WareHouseIO> lst = this.Context.WareHouseIO.ToList();
                return lst;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<WareHouseIO> GetAll(DateTime? fromDate, DateTime? toDate, int? clinicId)
        {
            return
                this.Context.WareHouseIO.Where(
                    x =>
                    (!fromDate.HasValue || x.Date >= fromDate.Value) && (!toDate.HasValue || x.Date <= toDate.Value) &&
                    (!clinicId.HasValue || x.ClinicId == clinicId)).OrderByDescending(x => x.Id).ToList();
        }

        public List<WareHouseIO> GetByClinicID(int idClinic)
        {
            try
            {
                List<WareHouseIO> lst =
                    this.Context.WareHouseIO.Where(x => x.ClinicId.Equals(idClinic)).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<WareHouseIO> Search(string type, int clinicId, DateTime fromDate, DateTime toDate)
        {
            try
            {
                if (type != string.Empty)
                {
                    if (clinicId > 0)
                        return this.Context.WareHouseIO.Where(x => x.ClinicId == clinicId && x.Type == type && x.Date >= fromDate.Date && x.Date <= toDate).OrderByDescending(x=>x.Date).ToList();
                    else
                        return this.Context.WareHouseIO.Where(x => x.Type == type && x.Date >= fromDate.Date && x.Date <= toDate).OrderByDescending(x => x.Date).ToList();
                }
                else
                {
                    if (clinicId > 0)
                        return this.Context.WareHouseIO.Where(x => x.ClinicId == clinicId && x.Date >= fromDate.Date && x.Date <= toDate).OrderByDescending(x => x.Date).ToList();
                    else
                        return this.Context.WareHouseIO.Where(x => x.Date >= fromDate.Date && x.Date <= toDate).OrderByDescending(x => x.Date).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

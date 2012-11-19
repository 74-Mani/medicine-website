﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Medical.Data.Entities;
using Medical.Forms.Implements;


namespace Medical.Data.Repositories {
    public class WareHouseDetailRepository : RepositoryBase, IWareHouseDetailRepository
    {

        public WareHouseDetail Get(int id)
        {
            var whDetail = this.Context.WareHouseDetails.FirstOrDefault(x => x.Id.Equals(id));
            return whDetail;
        }
        public WareHouseDetail GetById(int id)
        {
            var whDetail = this.Context.WareHouseDetails.FirstOrDefault(x => x.Id.Equals(id));
            return whDetail;
        }

     

        public void Insert(WareHouseDetail whDetail)
        {
            whDetail.CreatedUser = AppContext.LoggedInUser.Id;
            whDetail.CreatedDate = DateTime.Now;
            whDetail.LastUpdatedUser = AppContext.LoggedInUser.Id;
            whDetail.LastUpdatedDate = DateTime.Now;
            whDetail.Version = 0;
            this.Context.WareHouseDetails.Add(whDetail);
            this.Context.SaveChanges();
        }

        public void Update(WareHouseDetail whDetail)
        {
            try
            {
                var oldWhDetail = this.Context.WareHouseDetails.FirstOrDefault(x => x.Id == whDetail.Id);
                if (oldWhDetail == null) return;
                oldWhDetail.BadVolumn = whDetail.BadVolumn;
                oldWhDetail.ClinicId = whDetail.ClinicId;
                oldWhDetail.CreatedUser = whDetail.CreatedUser;
                oldWhDetail.CreatedDate = whDetail.CreatedDate;
                oldWhDetail.ExpiredDate = whDetail.ExpiredDate;
                oldWhDetail.LotNo = whDetail.LotNo;
                oldWhDetail.MedicineId = whDetail.MedicineId;
                oldWhDetail.UnitPrice = whDetail.UnitPrice;
                oldWhDetail.Volumn = whDetail.Volumn;
                oldWhDetail.LastUpdatedUser = AppContext.LoggedInUser.Id;
                oldWhDetail.LastUpdatedDate = DateTime.Now;
                oldWhDetail.Version++;
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
         
        }

    
        public void Delete(int id) {
            try
            {
                var oldWHDetail = this.Context.WareHouseDetails.FirstOrDefault(x => x.Id == id);
                this.Context.WareHouseDetails.Remove(oldWHDetail);
                this.Context.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

 
        public List<WareHouseDetail> GetAll() {
            try
            {
                List<WareHouseDetail> lst = this.Context.WareHouseDetails.ToList();
                return lst;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<WareHouseDetail> GetByIdMedicine(int idMedicine)
        {
            try
            {
                List<WareHouseDetail> lst =
                    this.Context.WareHouseDetails.Where(x => x.MedicineId.Equals(idMedicine)).ToList();
                return lst;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

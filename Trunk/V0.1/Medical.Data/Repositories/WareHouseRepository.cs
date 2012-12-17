﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Medical.Data.Entities;
//using Medical.Forms.Implements;


namespace Medical.Data.Repositories
{
    public class WareHouseRepository : RepositoryBase, IWareHouseRepository
    {
        public WareHouse Get(int id)
        {
            var whDetail = this.Context.WareHouses.FirstOrDefault(x => x.Id.Equals(id));
            return whDetail;
        }
        public WareHouse GetById(int id)
        {
            var whDetail = this.Context.WareHouses.FirstOrDefault(x => x.Id.Equals(id));
            return whDetail;
        }



        public void Insert(WareHouse whItem)
        {
            try
            {
                this.Context.WareHouses.Add(whItem);
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }

        public void Update(WareHouse whItem)
        {
            try
            {
                var oldWh = this.Context.WareHouses.FirstOrDefault(x => x.Id == whItem.Id);
                if (oldWh == null) return;
                oldWh.ClinicId = whItem.ClinicId;
                oldWh.MedicineId = whItem.MedicineId;
                oldWh.Volumn = whItem.Volumn;
                oldWh.MinAllowed = whItem.MinAllowed;
                oldWh.LastUpdatedUser = whItem.LastUpdatedUser;
                oldWh.LastUpdatedDate = DateTime.Now;
                oldWh.Version++;
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
                var oldWHDetail = this.Context.WareHouses.FirstOrDefault(x => x.Id == id);
                this.Context.WareHouses.Remove(oldWHDetail);
                this.Context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<WareHouse> GetAll()
        {
            try
            {
                List<WareHouse> lst = this.Context.WareHouses.ToList();
                return lst;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public WareHouse GetByIdMedicine(int idMedicine)
        {
            try
            {
                WareHouse item =
                    this.Context.WareHouses.Where(x => x.MedicineId.Equals(idMedicine)).FirstOrDefault();
                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public WareHouse GetByIdMedicine(int idMedicine, int clinicId)
        {
            try
            {
                WareHouse item =
                    this.Context.WareHouses.Where(x => x.MedicineId.Equals(idMedicine) && x.ClinicId.Equals(clinicId)).FirstOrDefault();
                return item;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

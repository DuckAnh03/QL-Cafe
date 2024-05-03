using QL_Cafe.DAL;
using QL_Cafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.BUS
{
    internal class BillBUS
    {
        private readonly BillDAL _billDAL;

        public BillBUS()
        {
            _billDAL = new BillDAL();
        }

        public List<Bill> GetAllBill()
        {
            var result = new List<Bill>();
            var data = _billDAL.GetAllBill();
            foreach (var bill in data.Rows)
            {
                result.Add(new((DataRow)bill));
            }
            return result;
        }

        public Bill getBillByID(int id)
        {
            var result = new Bill();
            var data = _billDAL.getBillByID(id);
            result = new((DataRow)data.Rows[0]);

            return result;
        }
        public int getUncheckBillByIDTable(int id)
        {
            var result = new Bill();
            DataTable data = _billDAL.getUncheckBillByIDTable(id);
            if(data.Rows.Count > 0)
            {
                result = new((DataRow)data.Rows[0]);
                return (int)result.ID;
            }
            
            return -1;
        }

        public bool Add(int idtable)
        {
            if (idtable< 1)
            {
                return false;
            }

            return _billDAL.AddBill(idtable);
        }

        public bool Delete(int id)
        {
            return _billDAL.DeleteBill(id);
        }


        public bool Update(Bill bill)
        {
            if (bill == null || bill.ID <= 0)
            {
                return false;
            }

            return _billDAL.UpdateDrinks(bill);
        }
    }
}

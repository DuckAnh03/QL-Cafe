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
    internal class BillInfoBUS
    {
        private readonly BillInfoDAL _billinfoDAL;

        public BillInfoBUS() 
        {
            _billinfoDAL = new BillInfoDAL();
        }

        public List<BillInfo> getBillInfoByBillID(int id)
        {
            var result = new List<BillInfo>();
            var data = _billinfoDAL.getBillInfoByBillID(id);
            foreach (var billinfo in data.Rows)
            {
                result.Add(new((DataRow)billinfo));
            }
            return result;
        }

        public bool Add(int idbill, int iddrinks, int count)
        {
            if (idbill == null || idbill == null||count == null)
            {
                return false;
            }

            return _billinfoDAL.AddDrinksToBill(idbill, iddrinks, count);

        }

    }
}

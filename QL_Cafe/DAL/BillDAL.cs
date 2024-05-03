using QL_Cafe.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DAL
{
    internal class BillDAL
    {
        public BillDAL() { }

        public bool AddBill(Bill data)
        {
            var query = $"INSERT INTO [Bill] (CheckIn, CheckOut, IDTable, Status)" +
                        $" VALUES ({data.CheckIn}, {data.CheckOut}, {data.IDTable},{data.Status})";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool DeleteBill(int id)
        {
            var query = $"DELETE [Bill] WHERE ID = {id}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateDrinks(Bill data)
        {
            var query = $"UPDATE [Bill] SET " +
                        $"CheckIn = {data.CheckIn}, CheckOut = {data.CheckOut}, IDTable = {data.IDTable}, Status = {data.Status}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

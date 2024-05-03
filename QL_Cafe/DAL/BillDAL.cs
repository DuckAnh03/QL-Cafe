using QL_Cafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DAL
{
    internal class BillDAL
    {
        public BillDAL() { }

        public DataTable GetAllBill()
        {
            var query = "SELECT * FROM [Bill]";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getBillByID(int id) 
        {
            var query = $"SELECT * FROM [Bill] WHERE ID = {id}";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getUncheckBillByIDTable(int id)
        {
            var query = $"SELECT * FROM [Bill] WHERE IDTable = {id} AND Status = {0}";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool AddBill(int idtable)
        {
            var query = $"INSERT INTO [Bill] (IDTable)" +
                        $" VALUES ({idtable})";
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
                        $"CheckIn = '{data.CheckIn}', CheckOut = '{data.CheckOut}', IDTable = {data.IDTable}, Status = {data.Status}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

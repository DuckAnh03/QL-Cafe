using QL_Cafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DAL
{
    internal class BillInfoDAL
    {
        public BillInfoDAL() { }

        public DataTable getBillInfoByBillID(int id)
        {
            var query = $"SELECT * FROM [BillInfo] WHERE IDBill = {id}";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool AddDrinksToBill(int idbill, int iddrinks, int count)
        {
            DataProvider.Instance.ExecuteNonQuery($"EXEC USP_INSERTBILLINFO @idbill = {idbill}, @iddrinks = {iddrinks}, @count ={count}");
            return true;
        }


        public bool DeleteDrinksInBill(int id)
        {
            var query = $"DELETE [BillInfo] WHERE IDDrinks = {id}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateDrinksCount(int count, int iDdrinks)
        {
            var query = $"UPDATE [BillInfo] SET " +
                        $"Count ={count} WHERE IDDrinks = {iDdrinks}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

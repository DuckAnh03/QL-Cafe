using QL_Cafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DAL
{
    internal class DrinksDAL
    {
        public DrinksDAL() { }

        public DataTable GetAllDrinks()
        {
            var query = "SELECT * FROM [DRINKS]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetDrinksByCategoryId(int categoryId)
        {
            var query = "SELECT * FROM [Drinks] ";
            if (categoryId > 0)
            {
                query += $"WHERE IDCategory ={categoryId}";
            }
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetDrinksByID(int id)
        {
            var query = $"SELECT * FROM [Drinks] WHERE ID ={id}";
            
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddDrinks(Drinks data)
        {
            var query = $"INSERT INTO [Drinks] (Name, IDCategory, Price)" +
                        $" VALUES (N'{data.DrinksName}', {data.IDCategory}, {data.Price})";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool DeleteDrinks(int id)
        {
            var query = $"DELETE [Drinks] WHERE ID = {id}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateDrinks(Drinks data)
        {
            var query = $"UPDATE [Drinks] SET " +
                        $"Name = N'{data.DrinksName}', ID_DrinksCategory = {data.IDCategory}, Price = {data.Price}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

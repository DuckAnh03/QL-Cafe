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
            var query = "SELECT * FROM [STUDENT] ";
            if (categoryId > 0)
            {
                query += $"WHERE ClassId ={categoryId}";
            }
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetDrinksById_DrinksCategory(int categoryId)
        {
            var query = "SELECT * FROM [Drinks] ";
            if (categoryId > 0)
            {
                query += $"WHERE ID_DrinksCategory ={categoryId}";
            }
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddDrinks(Drinks data)
        {
            var query = $"INSERT INTO [Drinks] (Name, ID_DrinksCategory, Price" +
                        $" VALUES (N'{data.DrinksName}', {data.ID_DrinksCategory}, {data.Price})";
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
                        $"Name = N'{data.DrinksName}', ID_DrinksCategory = {data.ID_DrinksCategory}, Price = {data.Price}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

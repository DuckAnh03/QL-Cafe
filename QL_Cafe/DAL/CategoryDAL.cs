using QL_Cafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DAL
{
    internal class CategoryDAL
    {
        public CategoryDAL() { }

        public DataTable GetAllCategory()
        {
            var query = "SELECT * FROM [Category] ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddCategory(Category data)
        {
            var query = $"INSERT INTO [Category] (Name) VALUES (N'{data.CategoryName}')";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            var query = $"DELETE [Category] WHERE Id = {id}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateCategory(Category data)
        {
            var query = $"UPDATE [Category] SET Name = N'{data.CategoryName}' WHERE Id = {data.ID}";
            var result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

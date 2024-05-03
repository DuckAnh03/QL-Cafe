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
    internal class CategoryBUS
    {
        private readonly CategoryDAL _categoryDAL;

        public CategoryBUS()
        {
            _categoryDAL = new CategoryDAL();
        }

        public List<Category> GetAllCategory()
        {
            var result = new List<Category>();
            var data = _categoryDAL.GetAllCategory();
            foreach (var category in data.Rows)
            {
                result.Add(new((DataRow)category));
            }
            return result;
        }

        public bool Add(Category category)
        {
            if (category == null || category.ID <= 0)
            {
                return false;
            }

            return _categoryDAL.AddCategory(category);
        }

        public bool Delete(int id)
        {
            return _categoryDAL.DeleteCategory(id);
        }

        public bool Update(Category category)
        {
            if (category == null || category.ID <= 0)
            {
                return false;
            }

            return _categoryDAL.UpdateCategory(category);
        }
    }
}

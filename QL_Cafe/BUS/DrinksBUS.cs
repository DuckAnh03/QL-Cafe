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
    internal class DrinksBUS
    {
        private readonly DrinksDAL _drinksDAL;

        public DrinksBUS() 
        {
            _drinksDAL = new DrinksDAL();
        }

        public List<Drinks> GetAllDrinks()
        {
            var result = new List<Drinks>();
            var data = _drinksDAL.GetAllDrinks();
            foreach ( var drinks in data.Rows ) 
            {
                result.Add(new((DataRow)drinks));
            }
            return result;
        }

        public List<Drinks> GetDrinksByCategoryId(int categoryId = 0)
        {
            var result = new List<Drinks>();
            var data = _drinksDAL.GetDrinksByCategoryId(categoryId);
            foreach (var drinks in data.Rows)
            {
                result.Add(new((DataRow)drinks));
            }
            return result;
        }

        public bool Add(Drinks drinks)
        {
            if (drinks == null || drinks.ID_DrinksCategory <= 0)
            {
                return false;
            }

            return _drinksDAL.AddDrinks(drinks);
        }

        public bool Delete(int id)
        {
            return _drinksDAL.DeleteDrinks(id);
        }

        /// <summary>
        /// Updates the specified student.
        /// </summary>
        /// <param name="student">The student.</param>
        /// <returns></returns>
        public bool Update(Drinks drinks)
        {
            if (drinks == null || drinks.ID <= 0)
            {
                return false;
            }

            return _drinksDAL.UpdateDrinks(drinks);
        }
    }
}

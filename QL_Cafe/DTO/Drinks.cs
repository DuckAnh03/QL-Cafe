using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QL_Cafe.DTO
{
    internal class Drinks
    {
        public int? ID { get; }
        public string? DrinksName { get;set; }

        public int? ID_DrinksCategory { get; set; }

        public double? Price { get; set; }

        public Drinks(int? id, string drinksname, int id_drinkscategory, float price)
        {
            ID = id;
            DrinksName = drinksname;
            ID_DrinksCategory = id_drinkscategory;
            Price = price;
        }

        public Drinks(DataRow Row)
        {
            ID = (int)Row["ID"];
            DrinksName = Row["Name"].ToString();
            ID_DrinksCategory = (int)Row["ID_DrinksCategry"];
            Price = (double)Row["Price"];
        }

    }
}

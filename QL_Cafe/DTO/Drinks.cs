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
        public int? ID { get; set; }
        public string? DrinksName { get;set; }

        public int? IDCategory { get; set; }

        public double? Price { get; set; }

        public Drinks() { }
        public Drinks(int? id, string drinksname, int idcategory, double price)
        {
            ID = id;
            DrinksName = drinksname;
            IDCategory = idcategory;
            Price = price;
        }

        public Drinks(DataRow Row)
        {
            ID = (int)Row["ID"];
            DrinksName = Row["Name"].ToString();
            IDCategory = (int)Row["IDCategory"];
            Price = (double)Row["Price"];
        }

    }
}

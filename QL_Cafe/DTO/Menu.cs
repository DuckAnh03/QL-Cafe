using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DTO
{
    internal class Menu
    {
        public string DrinksName { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalPrice {  get; set; }
        public Menu() { }
        public Menu(string drinksName, double price, int count, double totalPrice)
        {
            DrinksName = drinksName;
            Price = price;
            Count = count;
            TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            DrinksName = row["Name"].ToString();
            Price = (double)row["Price"];
            Count = (int)row["Count"];
            TotalPrice = (double)row["TotalPrice"];
        }

    }
}

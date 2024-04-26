using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DTO
{
    internal class Category
    {
        public int? ID {get;set;}
        public string? CategoryName { get; set; }

        public Category(int? id, string categoryname)
        {
            ID= id;
            CategoryName= categoryname;
        }

        public Category(DataRow Row)
        {
            ID = (int)Row["ID"];
            CategoryName = Row["Name"].ToString();
        }
    }
}

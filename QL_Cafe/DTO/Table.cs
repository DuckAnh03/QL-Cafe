using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DTO
{
    internal class Table
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public Table() { }

        public Table(int? iD, string? name, string? status)
        {
            ID = iD;
            Name = name;
            Status = status;
        }

        public Table(DataRow row)
        {
            ID = (int)row["ID"];
            Name = row["Name"].ToString();
            Status = row["Status"].ToString();
        }
    }
}

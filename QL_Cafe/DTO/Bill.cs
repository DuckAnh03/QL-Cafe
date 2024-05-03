using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DTO
{
    internal class Bill
    {
        public int? ID { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public int? IDTable { get; set; }
        public int? Status { get; set; }

        public Bill() { }

        public Bill(int? iD, DateTime? checkIn, DateTime? checkOut, int? iDTable, int? status)
        {
            ID = iD;
            CheckIn = checkIn;
            CheckOut = checkOut;
            IDTable = iDTable;
            Status = status;
        }
        public Bill(DataRow row)
        {
            ID = (int?)row["ID"];
            CheckIn = (DateTime?)row["CheckIn"];
            CheckOut = null;
            IDTable = (int?)row["IDTable"];
            Status = (int?)row["Status"];
        }
    }
}

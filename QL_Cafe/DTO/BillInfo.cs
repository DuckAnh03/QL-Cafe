using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DTO
{
    internal class BillInfo
    {
        public int? ID {  get; set; }
        public int? IDBill {  get; set; }
        public int? IDDrinks {  get; set; }
        public int? Count {  get; set; }

        public BillInfo() { }

        public BillInfo(int? iD, int? iDBill, int? iDDrinks, int? count)
        {
            ID = iD;
            IDBill = iDBill;
            IDDrinks = iDDrinks;
            Count = count;
        }
        public BillInfo(DataRow row)
        {
            ID = (int)row["ID"];
            IDBill = (int)row["IDBill"];
            IDDrinks = (int)row["IDDrinks"];
            Count = (int)row["Count"];
        }
    }
}

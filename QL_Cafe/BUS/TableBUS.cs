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
    internal class TableBUS
    {
        private readonly TableDAL _tableDAL;

        public TableBUS()
        {
            _tableDAL = new TableDAL();
        }

        public List<Table> GetAllTable()
        {
            var result = new List<Table>();
            var data = _tableDAL.GetAllTable();
            foreach (var table in data.Rows)
            {
                result.Add(new((DataRow)table));
            }
            return result;
        }

        
    }
}

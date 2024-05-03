using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DAL
{
    internal class TableDAL
    {
        public TableDAL() { }

        public DataTable GetAllTable()
        {
            var query = "SELECT * FROM [CoffeeTable]";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}

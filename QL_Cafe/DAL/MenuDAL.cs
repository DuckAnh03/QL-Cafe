using QL_Cafe.DTO;
using QL_Cafe.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Cafe.DAL
{
    internal class MenuDAL
    {
        public MenuDAL() { }

        public DataTable GetListMenusByTable(int idTable)
        {
            List<Menu> listmenu = new List<Menu>();
            var query = $"SELECT d.Name, d.Price, bi.Count, d.Price*bi.Count AS TotalPrice FROM  [BillInfo] AS bi, [Bill] AS b, [Drinks] AS d" +
                        $" WHERE bi.IDBill = b.ID AND bi.IDDrinks = d.ID AND b.IDTable = {idTable} AND b.status={0}";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}

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
    internal class MenuBUS
    {
        private readonly MenuDAL _menuDAL;

        public MenuBUS()
        {
            _menuDAL = new MenuDAL();
        }

        public List<Menu> getMenu(int idTable) 
        {
            List<Menu> menulist = new List<Menu>();
            var data = _menuDAL.GetListMenusByTable(idTable);
            foreach ( var menu in data.Rows ) 
            {
                menulist.Add(new((DataRow)menu));
            }
            return menulist;
        }
    }
}

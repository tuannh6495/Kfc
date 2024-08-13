using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kfc.Application.Enities
{
    public class MenuType : BaseEntity
    {
        public string MenuTypeName { get; set; }

        public ICollection<Item> Items { get; set; }
        public ICollection<Combo> Combos { get; set; }

        //public MenuType(string menuTypeName)
        //{
        //    MenuTypeName = menuTypeName;
        //}
    }
}

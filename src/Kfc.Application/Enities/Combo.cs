using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kfc.Application.Enities
{
    public class Combo : BaseEntity
    {
        public string ComboName { get; set; }
        public string ComboDesc { get; set; }
        public double ComboPrice { get; set; }

        public int MenuTypeId { get; set; }
        public MenuType MenuType { get; set; }

        public IList<ComboItem> ComboItem { get; set; }

        //public Combo(string comboName, string comboDesc, double comboPrice, int menuTypeId)
        //{
        //    comboName = ComboName;
        //    comboDesc = ComboDesc;
        //    comboPrice = ComboPrice;
        //    menuTypeId = MenuTypeId;
        //}
    }
}

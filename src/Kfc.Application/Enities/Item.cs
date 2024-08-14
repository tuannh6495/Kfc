using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kfc.Application.Enities
{
    public class Item : BaseEntity
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public int MenuTypeId { get; set; }
        //[ForeignKey("MenuType")]    
        public MenuType MenuType { get; set; }

        public IList<ComboItem> ComboItem { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kfc.Application.Enities
{
    public class ComboItem : BaseEntity
    {
        public int ComboId { get; set; }
        public int ItemId { get; set; }

        [ForeignKey("ComboId")]
        public Combo Combo { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}

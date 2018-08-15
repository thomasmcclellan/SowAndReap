using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SowAndReap.Models
{
    public class SingleMaterialItem
    {
        public int MaterialID { get; set; }
        public string MaterialName { get; set; }
        public decimal MaterialCost { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using SowAndReap.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SowAndReap.Models
{
    public class SinglePlantView
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public PlantHealth PlantRanking { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SowAndReap.Data
{
    public class Plant
    {
        [Key]
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        public int PlantZone { get; set; }
        public DateTimeOffset SowDate { get; set; }
        public DateTimeOffset ReapDate { get; set; }
        public int SpaceNeeds { get; set; }
        public int WaterNeeds { get; set; }
        public string SoilNeeds { get; set; }
        public string SolarNeeds { get; set; }
        public string Comments { get; set; }
    }
}

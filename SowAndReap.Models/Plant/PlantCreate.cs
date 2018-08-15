using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SowAndReap.WebMVC.Models.Plant
{
    public class PlantCreate
    {
        [Required]
        public string PlantName { get; set; }
        [Required]
        public int[] PlantZone { get; set; }
        [Required]
        public DateTime SowStartDate { get; set; }
        [Required]
        public DateTime SowEndDate { get; set; }
        [Required]
        public DateTime ReapStartDate { get; set; }
        [Required]
        public DateTime ReapEndDate { get; set; }
        [Required]
        public int SpaceNeeds { get; set; }
        [Required]
        public int WaterNeeds { get; set; }
        [Required]
        public string SoilNeeds { get; set; }
        [Required]
        public string SolarNeeds { get; set; }

        public override string ToString() => PlantName;
    }
}
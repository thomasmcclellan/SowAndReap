using SowAndReap.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace SowAndReap.Models.Plant
{
    public class PlantCreate
    {
        [Required]
        public string PlantName { get; set; }
        //[Required]
        //public int[] PlantZone { get; set; }
        //[Required]
        //public season Season { get; set; }
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
        //[Required]
        //public waterNeeds WaterNeeds { get; set; }
        //[Required]
        //public soilNeeds SoilNeeds { get; set; }
        //[Required]
        //public solarNeeds SolarNeeds { get; set; }

        public override string ToString() => PlantName;
    }
}
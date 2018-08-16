using System;
using System.ComponentModel.DataAnnotations;

namespace SowAndReap.Data
{
    public class Plant
    {
        [Key]
        public int PlantID { get; set; }

        [Required]
        public Guid OwnerID { get; set; }

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

        public int SpaceNeeds { get; set; }
        //public waterNeeds WaterNeeds { get; set; }
        //public soilNeeds SoilNeeds { get; set; }
        //public solarNeeds SolarNeeds { get; set; }

        //public PlantHealth PlantRanking { get; set; }

        //[MaxLength(150, ErrorMessage = "Comment exceeded character length.")]
        //public string Comments { get; set; }
    }

    //public enum season { Spring, Autumn, Summer, Winter }
    //public enum waterNeeds { Daily, EveryOtherDay, ThriceWeekly, TwiceWeekly, Weekly }
    //public enum soilNeeds { LimeAndSulfur, SoilConditioner, SoilCompost, PeatMoss, Perlite, Gypsum }
    //public enum solarNeeds { Direct, MorningOnly, HalfDay, Shade }


    //public class PlantHealth
    //{
    //    public bool WillLive { get; set; }
    //    public plantRanking PlantRanking { get; set; }
    //    public leafColor LeafColor { get; set; }
    //    public stalkStrenth StalkStrenth { get; set; }
    //    public bool BearingFruit { get; set; }
    //}

    //public enum plantRanking { VeryHealthy, Healthy, ModeratelyHealthy, Moderate, ModeratelyPoor, Poor, VeryPoor, Dead }
    //public enum leafColor { DarkGreen, MediumGreen, LightGreen, Yellow, Orange, Brown }
    //public enum stalkStrenth { Strong, Moderate, Weak }
}

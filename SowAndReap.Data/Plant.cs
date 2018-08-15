﻿using System;
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
        public int SpaceNeeds { get; set; }
        public int WaterNeeds { get; set; }
        public string SoilNeeds { get; set; }
        public string SolarNeeds { get; set; }

        public PlantHealth WillLive { get; set; }

        [MaxLength(150, ErrorMessage = "Comment exceeded character length.")]
        public string Comments { get; set; }
    }

    public class PlantHealth
    {
        public bool WillLive { get; set; }
        public string LeafColor { get; set; }
        public string StalkStrenth { get; set; }
        public bool BearingFruit { get; set; }
    }
}

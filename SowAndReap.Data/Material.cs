﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SowAndReap.Data
{
    public class Material
    {
        [Key]
        public int MaterialID { get; set; }

        [Required]
        public string MaterialName { get; set; }

        [Required]
        public decimal MaterialCost { get; set; }

        [Required]
        public DateTimeOffset MaterialDOP { get; set; }
        public bool MaterialFrequency { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SowAndReap.Data
{
    public class Crop
    {
        [Key]
        public int CropID { get; set; }
        public int PlantID { get; set; }
        public int MaterialID { get; set; }

        [ForeignKey] //this should be here I assume?
        public virtual Plant Plant { get; set; }
        public virtual Material Material { get; set; }
    }
}
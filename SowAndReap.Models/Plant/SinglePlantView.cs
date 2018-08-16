using SowAndReap.Data;

namespace SowAndReap.Models
{
    public class SinglePlantView
    {
        public int PlantID { get; set; }
        public string PlantName { get; set; }
        //public season Season { get; set; }
        //public PlantHealth PlantRanking { get; set; }

        public override string ToString() => PlantName;
    }
}

using SowAndReap.Data;
using SowAndReap.Models;
using SowAndReap.WebMVC.Models.Plant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SowAndReap.Services
{
    public class PlantService
    {

        private readonly Guid _userId;

        public PlantService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePlant(PlantCreate model)
        {
            var entity =
                new Plant()
                {
                    OwnerID = _userId,
                    PlantName = model.PlantName,
                    PlantZone = model.PlantZone,
                    SowStartDate = model.SowStartDate,
                    SowEndDate = model.SowEndDate,
                    ReapStartDate = model.ReapStartDate,
                    ReapEndDate = model.ReapEndDate,
                    SpaceNeeds = model.SpaceNeeds,
                    //WaterNeeds = model.WaterNeeds,
                    //SoilNeeds = model.SoilNeeds,
                    //SolarNeeds = model.SolarNeeds,
                    //PlantHealth = model.PlantHealth,
                    //Comments = model.Comments

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Plants.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<SinglePlantView> GetPlants()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Plants
                        .Where(e => e.OwnerID == _userId)
                        .Select(
                            e =>
                                new SinglePlantView
                                {
                                    PlantID = e.PlantID,
                                    PlantName = e.PlantName,
                                    PlantRanking = e.PlantRanking
                                }
                        );

                return query.ToArray();
            }
        }
    }
}

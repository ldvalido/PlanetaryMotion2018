using System.Collections.Generic;
using System.Data.Entity;
using PlanetaryMotion.Model;

namespace PlanetaryMotion.Storage.Context
{
    public class PlanetaryMotionInitializer : DropCreateDatabaseAlways<PlanetaryMotionContext>
    {
        public PlanetaryMotionInitializer():base()
        {
            
        }
        
        protected override void Seed(PlanetaryMotionContext context)
        {
            IList<Planet> planets = new List<Planet>
            {
                new Planet {Name = "Ferengi", Angle = 1d, Id = 1, Radious = 500*1000},
                new Planet {Name = "BetaSoide", Angle = 3d, Id = 2, Radious = 2000*1000},
                new Planet {Name = "Vulcano", Angle = -5d, Id = 3, Radious = 1000*1000}
            };
            var galaxy = new Galaxy {Id = 1, Name="Galaxia Lejana", Planets = planets};

            foreach (var p in planets)
            {
                context.Planets.Add(p);
            }
            
            context.Galaxys.Add(galaxy);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}

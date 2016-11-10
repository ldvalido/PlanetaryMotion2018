using System.Collections.Generic;
using System.Data.Entity;
using PlanetaryMotion.Model;
using PlanetaryMotion.Model.Model;

namespace PlanetaryMotion.Storage.Context
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Data.Entity.DropCreateDatabaseIfModelChanges{PlanetaryMotion.Storage.Context.PlanetaryMotionContext}" />
    public class PlanetaryMotionInitializer : DropCreateDatabaseAlways<PlanetaryMotionContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanetaryMotionInitializer"/> class.
        /// </summary>
        public PlanetaryMotionInitializer():base()
        {
            
        }

        /// <summary>
        /// A method that should be overridden to actually add data to the context for seeding.
        /// The default implementation does nothing.
        /// </summary>
        /// <param name="context">The context to seed.</param>
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

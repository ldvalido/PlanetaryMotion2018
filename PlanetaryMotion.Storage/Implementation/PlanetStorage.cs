using System.Collections.Generic;
using PlanetaryMotion.Model;
using PlanetaryMotion.Storage.Base;
using PlanetaryMotion.Storage.Context;

namespace PlanetaryMotion.Storage.Implementation
{
    public class PlanetStorage : StorageBase<Planet>
    {
        #region Overrides of StorageBase<Planet>

        protected override IEnumerable<Planet> GetList()
        {
            return new PlanetaryMotionContext().Set<Planet>().Include("Galaxy");
        }

        #endregion
    }
}

using System.Collections.Generic;
using PlanetaryMotion.Model;
using PlanetaryMotion.Storage.Base;
using PlanetaryMotion.Storage.Context;

namespace PlanetaryMotion.Storage.Implementation
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PlanetaryMotion.Storage.Base.StorageBase{PlanetaryMotion.Model.Planet}" />
    public class PlanetStorage : StorageBase<Planet>
    {
        #region Overrides of StorageBase<Planet>        
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<Planet> GetList()
        {
            return new PlanetaryMotionContext().Set<Planet>().Include("Galaxy");
        }

        #endregion
    }
}

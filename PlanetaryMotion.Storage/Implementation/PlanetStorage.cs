using System.Collections.Generic;
using PlanetaryMotion.Model;
using PlanetaryMotion.Storage.Base;

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
            return DbContext.Set<Planet>().Include("Galaxy");
        }

        #endregion
    }
}

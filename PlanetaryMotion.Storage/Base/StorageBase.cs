using System;
using System.Collections.Generic;
using System.Linq;
using PlanetaryMotion.Storage.Context;

namespace PlanetaryMotion.Storage.Base
{
    public abstract class StorageBase <T> where T: class
    {
        #region Astract Methods

        protected virtual IEnumerable<T> GetList()
        {
            return new PlanetaryMotionContext().Set<T>();
        }
        #endregion

        #region Public Methods
        public void Save(T element)
        {
            GetList().ToList().Add(element);
        }

        public void Remove(T element)
        {
            GetList().ToList().Remove(element);
        }

        public IEnumerable<T> GetAll()
        {
            return GetList().AsQueryable();
        }

        public IEnumerable<T> GetByCriteria(Func<T,bool> fncCriteria)
        {
            return GetList().Where(fncCriteria);
        } 
        #endregion
    }
}

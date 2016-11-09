using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PlanetaryMotion.Storage.Context;

namespace PlanetaryMotion.Storage.Base
{
    public abstract class StorageBase <T> where T: class
    {
        private DbContext _ctx;

        #region C...tor
        public StorageBase()
        {
            _ctx = new PlanetaryMotionContext();
        } 
        #endregion
        
        #region Astract Methods

        protected virtual IEnumerable<T> GetList()
        {
            return _ctx.Set<T>();
        }
        #endregion

        #region Public Methods
        public void Save(T element)
        {
            _ctx.Set<T>().Add(element);
            _ctx.SaveChanges();
        }

        public void Remove(T element)
        {
            _ctx.Set<T>().Remove(element);
            _ctx.SaveChanges();
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

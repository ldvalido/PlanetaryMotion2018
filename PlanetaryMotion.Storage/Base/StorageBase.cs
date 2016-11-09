using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PlanetaryMotion.Storage.Context;

namespace PlanetaryMotion.Storage.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class StorageBase <T> where T: class
    {
        private readonly DbContext _ctx;

        #region C...tor        
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageBase{T}"/> class.
        /// </summary>
        public StorageBase()
        {
            _ctx = new PlanetaryMotionContext();
        }
        #endregion

        #region Astract Methods        
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerable<T> GetList()
        {
            return _ctx.Set<T>();
        }
        #endregion

        #region Public Methods        
        /// <summary>
        /// Saves the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Save(T element)
        {
            _ctx.Set<T>().Add(element);
            _ctx.SaveChanges();
        }
        /// <summary>
        /// Removes the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Remove(T element)
        {
            _ctx.Set<T>().Remove(element);
            _ctx.SaveChanges();
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            return GetList().AsQueryable();
        }
        /// <summary>
        /// Gets the by criteria.
        /// </summary>
        /// <param name="fncCriteria">The FNC criteria.</param>
        /// <returns></returns>
        public IEnumerable<T> GetByCriteria(Func<T,bool> fncCriteria)
        {
            return GetList().Where(fncCriteria);
        } 
        #endregion
    }
}

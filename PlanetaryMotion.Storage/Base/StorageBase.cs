using System;
using System.Collections.Generic;
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
        /// <summary>
        /// Gets or sets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        public PlanetaryMotionContext DbContext { get; set; }
        
        #region Astract Methods        
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns></returns>
        protected virtual IEnumerable<T> GetList()
        {
            return DbContext.Set<T>();
        }
        #endregion

        #region Public Methods        
        /// <summary>
        /// Saves the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Save(T element)
        {
            DbContext.Set<T>().Add(element);
            DbContext.SaveChanges();
        }
        /// <summary>
        /// Removes the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Remove(T element)
        {
            DbContext.Set<T>().Remove(element);
            DbContext.SaveChanges();
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
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

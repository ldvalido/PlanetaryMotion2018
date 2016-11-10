using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PlanetaryMotion.Model.Model;
namespace PlanetaryMotion.Storage.Context
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class PlanetaryMotionContext : DbContext
    {
        /// <summary>
        /// Gets or sets the galaxys.
        /// </summary>
        /// <value>
        /// The galaxys.
        /// </value>
        public DbSet<Galaxy> Galaxys { get; set; }
        /// <summary>
        /// Gets or sets the planets.
        /// </summary>
        /// <value>
        /// The planets.
        /// </value>
        public DbSet<Planet> Planets { get; set; }
        /// <summary>
        /// Gets or sets the weather history.
        /// </summary>
        /// <value>
        /// The weather history.
        /// </value>
        public DbSet<WeatherHistory> WeatherHistory { get; set; }

        #region C...tor        
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanetaryMotionContext"/> class.
        /// </summary>
        public PlanetaryMotionContext() : base("PlanetaryMotionCnnStr")
        {
            DbConfiguration.SetConfiguration(new MySqlConfiguration.MySqlConfiguration());
            Database.SetInitializer(new PlanetaryMotionInitializer());
        }
        #endregion
        #region Overrides of DbContext
        /// <summary>
        /// This method is called when the model for a derived context has been initialized, but
        ///             before the model has been locked down and used to initialize the context.  The default
        ///             implementation of this method does nothing, but it can be overridden in a derived class
        ///             such that the model can be further configured before it is locked down.
        /// </summary>
        /// <remarks>
        /// Typically, this method is called only once when the first instance of a derived context
        ///             is created.  The model for that context is then cached and is for all further instances of
        ///             the context in the app domain.  This caching can be disabled by setting the ModelCaching
        ///             property on the given ModelBuidler, but note that this can seriously degrade performance.
        ///             More control over caching is provided through use of the DbModelBuilder and DbContextFactory
        ///             classes directly.
        /// </remarks>
        /// <param name="modelBuilder">The builder that defines the model for the context being created. </param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<WeatherHistory>().HasKey(p => p.Day);
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}

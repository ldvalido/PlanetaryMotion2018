using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace PlanetaryMotion.Storage.MySqlConfiguration
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Data.Entity.Migrations.History.HistoryContext" />
    public class MySqlHistoryContext : HistoryContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlHistoryContext"/> class.
        /// </summary>
        /// <param name="existingConnection">An existing connection to use for the new context.</param>
        /// <param name="defaultSchema">The default schema of the model being migrated.
        /// This schema will be used for the migrations history table unless a different schema is configured in OnModelCreating.</param>
        public MySqlHistoryContext(
          DbConnection existingConnection,
          string defaultSchema)
        : base(existingConnection, defaultSchema)
        {
        }
        /// <summary>
        /// Applies the default configuration for the migrations history table. If you override
        /// this method it is recommended that you call this base implementation before applying your
        /// custom configuration.
        /// </summary>
        /// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
        }
    }
}

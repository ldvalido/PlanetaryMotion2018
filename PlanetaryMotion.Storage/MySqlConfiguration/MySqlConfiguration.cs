using System.Data.Entity;

namespace PlanetaryMotion.Storage.MySqlConfiguration
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbConfiguration" />
    public class MySqlConfiguration : DbConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlConfiguration"/> class.
        /// </summary>
        public MySqlConfiguration()
        {
            SetHistoryContext(
            "MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
        }
    }
}

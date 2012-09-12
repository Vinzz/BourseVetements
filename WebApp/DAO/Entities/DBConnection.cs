using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace DAO
{
    public class DBConnection
    {
        /// <summary>
        /// Gets the DB connection
        /// connection parameters are decrypted
        /// </summary>
        /// <returns>An Entity (Framework) connection</returns>
        public static EntityConnection GetEntityConnection()
        {
            EntityConnection ans = null;
            EntityConnection conn = null;
            try
            {
                SqlConnectionStringBuilder sqlBuilder = GetSqlBuilder();

                // Initialize the EntityConnectionStringBuilder.
                EntityConnectionStringBuilder entityBuilder =
                    new EntityConnectionStringBuilder();

                // Set the provider name.
                entityBuilder.Provider = "MySql.Data.MySqlClient";

                // Set the provider-specific connection string.
                entityBuilder.ProviderConnectionString = GetSqlBuilder().ToString();

                // Set the Metadata location.
                entityBuilder.Metadata = @"res://*/Entities.BourseEntities.csdl|res://*/Entities.BourseEntities.ssdl|res://*/Entities.BourseEntities.msl";
                string st = entityBuilder.ToString();

                conn = new EntityConnection(entityBuilder.ToString());

                conn.Open();

                // Just testing the connection.
                conn.Close();

                // CA2000 prevention
                ans = conn;
                conn = null;

                return ans;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Gets the SQL connexion string from the settings.
        /// </summary>
        /// <returns>A SQL connexion string builder</returns>
        private static SqlConnectionStringBuilder GetSqlBuilder()
        {
            var uriString = Properties.Settings.Default.SQLSERVER_URI;
            var uri = new Uri(uriString);
            return new SqlConnectionStringBuilder
            {
                DataSource = uri.Host,
                InitialCatalog = uri.AbsolutePath.Trim('/'),
                UserID = uri.UserInfo.Split(':').First(),
                Password = uri.UserInfo.Split(':').Last(),
            };
        }
    }
}

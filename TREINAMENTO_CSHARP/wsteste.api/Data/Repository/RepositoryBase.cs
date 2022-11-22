using System.Data;

namespace wsteste.api.Data.Repository
{
    public class RepositoryBase
    {
        public abstract class RepositoryBase
        {
            public static IDbConnection Connection
            {
                get
                {
                    SqlConnection sqlConnection = new SqlConnection(Global.ConnectionString);
                    sqlConnection.Open();
                    sqlConnection.Execute("Set Transaction Isolation Level Read UnCommitted");
                    return sqlConnection;
                }
            }

            public RepositoryBase()
            {
                DefaultTypeMap.MatchNamesWithUnderscores = true;
            }
        }
    }
}

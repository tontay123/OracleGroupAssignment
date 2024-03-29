using Microsoft.Data.SqlClient;
using System.Data;

namespace OracleGroupAssignment.Data
{
    public class DapperDbContext
    {
        private readonly IConfiguration _configuration;
        public DapperDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection Connection => new SqlConnection(_configuration.GetConnectionString("myconnection"));
    }
}


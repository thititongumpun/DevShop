using Dapper;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.ViewModels.Position;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core.Repository.Position
{
    public class PositionRepository : IPositionRepository
    {
        protected readonly IConfiguration _config;
        public PositionRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DevShops"));
            }
        }

        public async Task<IEnumerable<PositionViewModel>> GetAllPositions()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    string sql = @"SELECT * FROM Positions";

                    return await dbConnection.QueryAsync<PositionViewModel>(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception !!!", ex);
            }
        }
    }
}

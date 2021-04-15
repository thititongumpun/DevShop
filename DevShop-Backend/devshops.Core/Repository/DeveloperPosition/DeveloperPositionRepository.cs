using Dapper;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.ViewModels.DeveloperPositionViewModel;
using devshops.Domain.ViewModels.Position;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core.Repository.DeveloperPosition
{
    public class DeveloperPositionRepository : IDeveloperPositionRepository
    {
        protected readonly IConfiguration _config;
        public DeveloperPositionRepository(IConfiguration config)
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

        public async Task<IEnumerable<DeveloperPositionViewModel>> GetDeveloperPosition()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    string sql = @"SELECT DP.* FROM DeveloperPosition DP;";

                    return await dbConnection.QueryAsync<DeveloperPositionViewModel>(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }

        public void AddDeveloperPosition(DeveloperPositionCreateModel createModel)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var trans = dbConnection.BeginTransaction();

                try
                {
                    string sql = @"INSERT INTO DeveloperPosition (DeveloperId, PositionId, Created, CreatedBy)
                                VALUES (@DeveloperId, @PositionId, @Created, @CreatedBy)";

                    dbConnection.Execute(sql, createModel, trans);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("Something Wrong While Insert DeveloperPosition", ex);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }
    }
}

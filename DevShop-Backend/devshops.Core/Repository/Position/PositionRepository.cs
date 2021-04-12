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

        public void AddPosition(PositionCreateModel position)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var tran = dbConnection.BeginTransaction();
                
                try
                {
                    string sql = @"INSERT INTO PositionS (PositionName)
                                VALUES (@PositionName)";

                    dbConnection.Execute(sql, position, tran);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw new Exception("Something Wrong While Insert Position", ex);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }

        public void UpdatePosition(PositionViewModel position)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var tran = dbConnection.BeginTransaction();

                try
                {
                    string sql = @"UPDATE Positions SET PositionName=@PositionName WHERE PositionId=@PositionId";

                    dbConnection.Execute(sql, position, tran);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw new Exception("Something Wrong While Update Position", ex);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }

        public void DeletePosition(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var tran = dbConnection.BeginTransaction();

                try
                {
                    string sql = @"DELETE FROM Positions WHERE PositionId=@PositionId";

                    dbConnection.Execute(sql, new { PositionId = id }, tran);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw new Exception("Something Wrong While Update Position", ex);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }
    }
}

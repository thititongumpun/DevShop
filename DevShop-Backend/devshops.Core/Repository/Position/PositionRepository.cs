using Dapper;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.Entities;
using devshops.Domain.ViewModels.Position;
using devshops.Infrastructure.Interfaces;
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

        public async Task<IEnumerable<PositionGroupModel>> GetAllPositions()
        {
            try
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    string sql = @"SELECT P.PositionId, PositionName, D.DeveloperId,
                                D.DeveloperName, D.Email, D.GithubUrl, D.ImageUrl, D.Status
                                FROM Positions P
                                LEFT JOIN DeveloperPosition DP
                                ON P.PositionId = DP.PositionId
                                LEFT JOIN Developers D
                                ON DP.DeveloperId = D.DeveloperId;";

                    var positions = await dbConnection.QueryAsync<PositionGroupModel, DeveloperModel, PositionGroupModel>(sql, (position, developer) =>
                    {
                        position.Developers.Add(developer);
                        return position;
                    }, splitOn: "DeveloperId");
                    var result = positions.GroupBy(p => p.PositionId).Select(g =>
                    {
                        var groupPosition = g.First();
                        groupPosition.Developers = g.Select(p => p.Developers.FirstOrDefault()).ToList();
                        return groupPosition;
                    });

                    return result;

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something Wrong While Select Positions", ex);
            }
        }

        public void AddPosition(PositionCreateModel position)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var trans = dbConnection.BeginTransaction();
                
                try
                {
                    string sql = @"INSERT INTO Positions (PositionName, Created, CreatedBy)
                                VALUES (@PositionName, @Created, @CreatedBy)";

                    dbConnection.Execute(sql, position, trans);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
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
                var trans = dbConnection.BeginTransaction();

                try
                {
                    string sql = @"UPDATE Positions SET PositionName = @PositionName,
                                   LastModified = @LastModified, LastModifiedBy = @LastModifiedBy
                                   WHERE PositionId=@PositionId";

                    dbConnection.Execute(sql, position, trans);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
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
                    string sql = @"DELETE FROM Positions WHERE PositionId= @PositionId";

                    dbConnection.Execute(sql, new { PositionId = id }, tran);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw new Exception("Something Wrong While Delete Position", ex);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
        }

        public async Task<PositionGroupModel> GetPositionById(int id)
        {
            try
            {
                Dictionary<int, PositionGroupModel> result = new Dictionary<int, PositionGroupModel>();

                using (IDbConnection dbConnection = Connection)
                {
                    string sql = @"SELECT P.PositionId, PositionName,
                                D.DeveloperId, DeveloperName, D.Email,
                                D.GithubUrl, D.ImageUrl, D.Status
                                FROM Positions P
                                LEFT JOIN DeveloperPosition DP 
                                ON P.PositionId = DP.PositionId
                                LEFT JOIN Developers D
                                ON DP.DeveloperId = D.DeveloperId
                                WHERE P.PositionId = @id;";

                    var developer = await dbConnection.QueryAsync<PositionGroupModel, DeveloperModel, PositionGroupModel>(sql, (position, developer) =>
                    {
                        if (!result.ContainsKey(position.PositionId))
                        {
                            result.Add(position.PositionId, position);
                        }
                        PositionGroupModel positionGroup = result[position.PositionId];
                        positionGroup.Developers.Add(developer);
                        return position;
                    }, new { id }, splitOn: "DeveloperId");

                    if (result.Values.Count > 0)
                    {
                        return result.Values.First();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Something Wrong While Getting Position", ex);
            }
        }
    }
}

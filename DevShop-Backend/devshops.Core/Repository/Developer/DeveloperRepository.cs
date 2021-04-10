using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using devshops.Domain.Developer.ViewModels;
using devshops.Domain.Entities;
using devshops.Domain.ViewModels.Position;
using Microsoft.Extensions.Configuration;

namespace devshops.Core.Repository.Developer
{
    public class DeveloperRepository : IDeveloperRepository
    {
        protected readonly IConfiguration _config;
        public DeveloperRepository(IConfiguration config)
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
        public async Task<IEnumerable<DeveloperViewModel>> GetAllDevelopers()
        {
            try 
            {
                using (IDbConnection dbConnection = Connection)
                {
                    dbConnection.Open();
                    string sql = @"SELECT D.DeveloperId, D.DeveloperName, D.Email,
                                D.GithubUrl, D.JoinedDate, D.Status,
                                P.PositionId, P.PositionName
                                FROM Developers D
                                LEFT JOIN DeveloperPosition DP ON D.DeveloperId = DP.DeveloperId
                                LEFT JOIN Positions P ON DP.PositionId = P.PositionId";
                    
                    var developers = await dbConnection.QueryAsync<DeveloperViewModel, PositionViewModel, DeveloperViewModel>(sql, (developer, position) => 
                    {
                        developer.Positions.Add(position);
                        return developer;
                    }, splitOn: "PositionId");
                    var result = developers.GroupBy(d => d.DeveloperId).Select(g => 
                    {
                        var groupDeveloper = g.First();
                        groupDeveloper.Positions = g.Select(d => d.Positions.Single()).ToList();
                        return groupDeveloper;
                    });
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception !!!", ex);
            }
        }
    }
}
using Dapper;
using IncentiveCampaign.Domain.Contracts.Repository;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace IncentiveCampaign.DapperSqlRepository
{
    public class CampaignRepository : ICampaignRepository
    {
        public CampaignRepository()
        {
            connectionString = @"Server=localhost;Database=DapperDemo;Trusted_Connection=true;";
        }

        private string connectionString;
        
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
        
        public Campaign Create(Campaign baseEntity, string username)
        {
            throw new NotImplementedException();
        }

        public List<Campaign> GetAll()
        {
            using (var conn = Connection)
            {
                conn.Open();
                var campaigns = conn.Query<Campaign>("SELECT * FROM tbl_campaigns");

                return campaigns.ToList();

            }
                throw new NotImplementedException();
        }

        public Campaign GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Campaign Invalidate(long id, string username)
        {
            throw new NotImplementedException();
        }

        public Campaign Update(Campaign baseEntity, string username)
        {
            throw new NotImplementedException();
        }
    }
}

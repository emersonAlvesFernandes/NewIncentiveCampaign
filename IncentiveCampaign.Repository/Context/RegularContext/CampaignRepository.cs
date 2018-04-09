using IncentiveCampaign.Domain.Contracts.Repository;
using IncentiveCampaign.Domain.Entities;
using IncentiveCampaign.SqlRepository.Contracts;
using System;
using System.Collections.Generic;

namespace IncentiveCampaign.SqlRepository.Context.RegularContext
{
    public class CampaignRepository : BaseRepository, ICampaignRepository
    {
        //public Entity GetNestedByBaseId(long campaignId)
        //{
        //    try
        //    {
        //        //base.conne1ction = new SqlConnection(connectionstring);
        //        //this.OpenConnection();

        //        using (var cmd = new SqlCommand("spr_ca_ctxt_ler_campa_conce_usuar", connection))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@id_empre", campaignId);

        //            var dataReader = cmd.ExecuteReader();
        //            while (dataReader.Read())
        //            {
        //                //var userId = dataReader["num_entid"].ToInt32();
        //                //var nomEntid = dataReader["nom_entid"].ToString();
        //                //var hasAcceptedTerm = dataReader["ind_aceit_termo"].ToBoolean();
        //                //var termacceptDate = dataReader["dat_aceit_termo"].ToDateTime();
        //                //var dealer = new Dealer(hasAcceptedTerm, termacceptDate, userId, nomEntid);

        //            }
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        base.CloseConnection();
        //    }
        //}

        //List<Entity> INestedEntityRepository<Entity>.GetNestedByBaseId(long baseId)
        //{
        //    throw new NotImplementedException();
        //}
        public Campaign Create(Domain.Entities.Campaign baseEntity, string username)
        {
            throw new NotImplementedException();
        }

        public List<Campaign> GetAll()
        {
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

        public Campaign Update(Domain.Entities.Campaign baseEntity, string username)
        {
            throw new NotImplementedException();
        }
    }
}

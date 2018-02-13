using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using IncentiveCampaign.ALDomainContext.Contracts.Repository;
using IncentiveCampaign.SqlRepository.Contracts;
using IncentiveCampaign.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IncentiveCampaign.SqlRepository.Context.RegularContext
{
    public class CampaignRepository : BaseRepository, INestedEntityRepository<Entity>
    {
        public CampaignRepository() : base()
        {

        }

        public Entity GetNestedByBaseId(long campaignId)
        {
            try
            {
                //base.conne1ction = new SqlConnection(connectionstring);
                //this.OpenConnection();

                using (var cmd = new SqlCommand("spr_ca_ctxt_ler_campa_conce_usuar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_empre", campaignId);

                    var dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        //var userId = dataReader["num_entid"].ToInt32();
                        //var nomEntid = dataReader["nom_entid"].ToString();
                        //var hasAcceptedTerm = dataReader["ind_aceit_termo"].ToBoolean();
                        //var termacceptDate = dataReader["dat_aceit_termo"].ToDateTime();
                        //var dealer = new Dealer(hasAcceptedTerm, termacceptDate, userId, nomEntid);

                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                base.CloseConnection();
            }
        }
    }
}

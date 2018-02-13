using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using IncentiveCampaign.ALDomainContext.Contracts.Repository;
using IncentiveCampaign.ALDomainContext.Domain;
using IncentiveCampaign.SqlRepository.Contracts;
using IncentiveCampaign.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace IncentiveCampaign.SqlRepository.Context.AgreementLetterContext
{
    public class CampaignRepository : BaseRepository, IBaseEntityRepository<Campaign>
    {
        public CampaignRepository() : base()
        {

        }

        public Campaign GetBaseEntity(long id)
        {
            try
            {
                //base.conne1ction = new SqlConnection(connectionstring);
                //this.OpenConnection();

                using (var cmd = new SqlCommand("spr_ca_ctxt_ler_campa_conce_usuar", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@num_campa", id);

                    var dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        var campaignName = dataReader["nom_entid"].ToString();
                        var agreementLetterRequired = dataReader["ind_reqr_carta_acord"].ToBoolean();

                        return new Campaign(agreementLetterRequired, id, campaignName);
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

using IncentiveCampaign.Domain.Contracts.Crud;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.Repository
{
    public interface IDealershipRepository : INestedCrudRepository<Dealership>
    {
        void SendAgreementLetter(long dealershipId, string username);
    }
}

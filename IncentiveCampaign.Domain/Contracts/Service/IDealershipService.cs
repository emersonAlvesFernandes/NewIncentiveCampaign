using IncentiveCampaign.Domain.Contracts.Crud;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.Service
{
    public interface IDealershipService : INestedCrudService<Dealership>
    {
        void SendAgreementLetter(long dealershipId, string username);

        void DeleteAllRelationships(List<Dealership> dealerships, long baseId);
    }
}

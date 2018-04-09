using IncentiveCampaign.Domain.Contracts.Repository;
using IncentiveCampaign.Domain.Contracts.Service;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Services
{
    public class DealershipService : IDealershipService
    {
        private readonly IDealershipRepository _repository;

        public List<Dealership> GetByBaseId(long baseId)
        {
            throw new NotImplementedException();
        }

        public List<Dealership> Relate(List<Dealership> dealerships, long campaignId, string username)
        {            
            this.DeleteAllRelationships(dealerships, campaignId);

            this.CreateRelationship(dealerships, campaignId);

            return dealerships;
        }

        public void DeleteAllRelationships(List<Dealership> dealerships, long campaignId)
        {            
            dealerships.ForEach(d => _repository.DeleteRelationship(campaignId));
        }

        private void CreateRelationship(List<Dealership> dealerships, long baseId)
        {
            dealerships.ForEach( d => _repository.CreateRelationship(baseId, d.Id));            
        }

        public void SendAgreementLetter(long dealershipId, string username)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public List<Dealership> Relate(List<Dealership> dealerships, long baseId, string username)
        {
            //  Checar se concessionária há dealers com 
            //  pontos

            this.DeleteAllRelationships(dealerships, baseId);
            this.CreateRelationship(dealerships, baseId);

            return null;
        }

        public void DeleteAllRelationships(List<Dealership> dealerships, long baseId)
        {
            foreach (var d in dealerships)
            {
                _repository.DeleteRelationship(baseId, d.Id);
            }
        }

        private void CreateRelationship(List<Dealership> dealerships, long baseId)
        {
            foreach (var dealership in dealerships)
            {
                _repository.CreateRelationship(baseId, dealership);
            }
        }

        public void SendAgreementLetter(long dealershipId, string username)
        {
            throw new NotImplementedException();
        }
    }
}

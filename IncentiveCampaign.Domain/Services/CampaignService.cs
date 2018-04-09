using IncentiveCampaign.Domain.Contracts.Repository;
using IncentiveCampaign.Domain.Contracts.Service;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _repository;

        public CampaignService(ICampaignRepository repository)
        {
            _repository = repository;
        }

        public Campaign Create(Campaign baseEntity, string username)
        {
            return _repository.Create(baseEntity, username);
        }

        public List<Campaign> GetAll()
        {
            return _repository.GetAll();
        }

        public Campaign GetById(long id)
        {
            return _repository.GetById(id);
        }

        public Campaign Invalidate(long campaignId, string username)
        {
            return _repository.Invalidate(campaignId, username);
        }

        public Campaign Update(Campaign baseEntity, string username)
        {
            return _repository.Update(baseEntity, username);
        }
    }
}

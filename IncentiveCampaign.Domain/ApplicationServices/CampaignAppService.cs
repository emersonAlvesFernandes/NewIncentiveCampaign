using IncentiveCampaign.Domain.Contracts.ApplicationService;
using IncentiveCampaign.Domain.Contracts.Service;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.ApplicationServices
{
    public class CampaignAppService : ICampaignAppService
    {
        private readonly ICampaignService _campaignService;
        private readonly IDealershipService _dealership;

        public Campaign Create(Campaign baseEntity, string username)
        {
            var campaign = _campaignService.Create(baseEntity, username);
            var dealerships = _dealership.Relate(baseEntity.Dealerships, campaign.Id, username);

            campaign.Dealerships = dealerships;

            return campaign;
        }

        public Campaign GetAll()
        {
            var campaigns = _campaignService.GetAll();            

            return campaigns;
        }

        public Campaign GetById(long id)
        {
            var campaign = _campaignService.GetById(id);
            campaign.Dealerships = _dealership.GetByBaseId(id);

            return campaign;
        }
        
        public Campaign Invalidate(long id, string username)
        {
            return _campaignService.Invalidate(id, username);
        }

        public Campaign Update(Campaign baseEntity, string username)
        {
            var campaign = _campaignService.Update(baseEntity, username);
            campaign.Dealerships = _dealership.Relate(baseEntity.Dealerships, baseEntity.Id, username);

            return campaign;
        }
    }
}

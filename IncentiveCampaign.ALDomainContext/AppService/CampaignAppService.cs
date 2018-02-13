using IncentiveCampaign.ALDomainContext.Contracts.AppService;
using IncentiveCampaign.ALDomainContext.Contracts.Service;
using IncentiveCampaign.ALDomainContext.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.AppService
{
    public class CampaignAppService : IALAppService
    {
        private readonly IBaseEntityService<Campaign> _campaignService;
        private readonly INestedEntityService<Regional> _regionalService;
        private readonly INestedEntityService<Dealership> _dealershipService;
        private readonly INestedEntityService<Dealer> _dealerService;

        public CampaignAppService(IBaseEntityService<Campaign> service)
        {
            _campaignService = service;
        }

        public Campaign GetCampaignData(long id)
        {
            var campaign = _campaignService.GetBaseId(id);
            campaign.Regionals = _regionalService.GetNestedByBaseId(campaign.Id);
            //var regionals = _regionalService.GetNestedByBaseId(campaign.Id);

            foreach (var r in campaign.Regionals)
            {
                var dealership = _dealershipService.GetNestedByBaseId(r.Id);
                r.AddDealership(dealership);

                foreach(var d in r.Dealerships)
                {
                    var dealers = _dealerService.GetNestedByBaseId(d.Id);
                    d.AddDealers(dealers);
                }
            }
                                    
            return null;
        }
    }
}

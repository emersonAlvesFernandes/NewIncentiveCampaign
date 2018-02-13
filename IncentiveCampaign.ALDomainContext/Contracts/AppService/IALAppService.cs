using IncentiveCampaign.ALDomainContext.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Contracts.AppService
{
    public interface IALAppService
    {
        Campaign GetCampaignData(long id);
    }
}
 
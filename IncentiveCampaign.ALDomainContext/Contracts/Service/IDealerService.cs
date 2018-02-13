using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Contracts.Service
{
    public interface IDealerService
    {
        void MarkAsReadyToUse(long userId); 
    }
}

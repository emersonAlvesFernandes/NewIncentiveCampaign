using System;
using System.Collections.Generic;
using System.Text;
using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;

namespace IncentiveCampaign.ALDomainContext.Domain
{
    public class Dealer : IEntity
    {
        public bool HasAcceptedTerm { get; set; }

        public DateTime AcceptDate { get; set; }
    }
}

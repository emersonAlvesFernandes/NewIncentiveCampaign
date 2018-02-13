using System;
using System.Collections.Generic;
using System.Text;
using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;

namespace IncentiveCampaign.ALDomainContext.Domain
{
    public class Dealer : Entity
    {
        public Dealer(bool hasAcceptedTerm, DateTime? termAcceptDate, long id, string name) 
            : base(id, name)
        {            
            HasAcceptedTerm = hasAcceptedTerm;
            TermAcceptDate = termAcceptDate;
        }

        public bool HasAcceptedTerm { get; private set; }

        public DateTime? TermAcceptDate { get; private set; }

        public override bool IsValid()
        {            
            return true;
        }
    }
}

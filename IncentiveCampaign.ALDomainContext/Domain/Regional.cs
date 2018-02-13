using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Domain
{
    public class Regional : Entity
    {
        public Regional(List<Dealership> dealerships, long id, string name)
            : base(id, name)
        {
            Dealerships = dealerships;
        }

        public List<Dealership> Dealerships { get; private set; }

        public override bool IsValid()
        {
            return true;
        }

        public void AddDealership(List<Dealership> dealerships)
        {
            Dealerships.AddRange(dealerships);
        }
    }
}

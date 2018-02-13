using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Domain
{
    public class Dealership : Entity
    {
        public Dealership(byte[] agreementLetter, List<Dealer> dealers, long id, string name)
            : base(id, name)
        {
            AgreementLetter = agreementLetter;
            Dealers = dealers;
        }

        public byte[] AgreementLetter { get; private set; }

        public List<Dealer> Dealers { get; private set; }

        public override bool IsValid()
        {            
            return true;
        }

        public void AddDealers(List<Dealer> dealers)
        {
            dealers.AddRange(dealers);
        }
    }
}

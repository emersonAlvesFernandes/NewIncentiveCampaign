using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Domain
{
    public class Dealership
    {
        public byte[] AgreementLetter { get; set; }

        public List<Dealer> Dealers { get; set; }
    }
}

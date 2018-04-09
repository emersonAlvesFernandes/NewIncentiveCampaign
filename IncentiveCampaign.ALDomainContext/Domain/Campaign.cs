using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Domain
{
    public class Campaign : Entity
    {
        public Campaign(bool agreementLetterRequired, long id, string name)
            : base(id, name)
        {
            AgreementLetterRequired = agreementLetterRequired;            
        }

        public Campaign(bool agreementLetterRequired, List<Regional> regionals, long id, string name)
            : base (id, name)
        {
            AgreementLetterRequired = agreementLetterRequired;
            Regionals = regionals;
        }

        public bool AgreementLetterRequired { get; private set; }

        public List<Regional> Regionals { get; set; }

        public override bool IsValid()
        {
            return true;
        }
    }
}

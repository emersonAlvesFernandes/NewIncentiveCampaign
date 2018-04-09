using IncentiveCampaign.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Dealership : Entity
    {
        public Dealership(
            long id,
            string name,
            string cnpj,
            bool agreementLetterSent) : base(id, name)
        {
            Cnpj = cnpj;
            AgreementLetterSent = agreementLetterSent;            
        }

        public string Cnpj { get; private set; }

        public bool AgreementLetterSent { get; private set; }       

        public List<Dealer> Dealers { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}

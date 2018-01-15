using IncentiveCampaign.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Dealership : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Cnpj { get; set; }

        public bool AgreementLetterSent { get; set; }       

        public List<Dealer> Dealers { get; set; }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}

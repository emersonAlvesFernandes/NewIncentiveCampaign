using IncentiveCampaign.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Dtos.Dealership
{
    public class DealershipCreateDto : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Cnpj { get; set; }

        public bool AgreementLetterSent { get; set; }        

        public bool IsValid()
        {

            throw new NotImplementedException();
        }
    }
}

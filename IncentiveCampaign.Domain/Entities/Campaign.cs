using IncentiveCampaign.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Campaign : Entity
    {        
        public Campaign(
            long id,
            string name,
            DateTime startDate, 
            DateTime endDate, 
            bool isActive, 
            DateTime creationDate, 
            string userName, 
            bool agreementLetterRequired, 
            string termUrl) : base(id, name)
        {
            StartDate = startDate;
            EndDate = endDate;
            IsActive = isActive;
            CreationDate = creationDate;
            UserName = userName;
            AgreementLetterRequired = agreementLetterRequired;
            TermUrl = termUrl;
        }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public bool IsActive { get; private set; }

        public DateTime CreationDate { get; private set; }

        public string UserName { get; private set; }

        public bool AgreementLetterRequired { get; private set; }

        public string TermUrl { get; private set; }

        public List<Dealership> Dealerships { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}

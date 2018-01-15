//using Flunt.Notifications;
//using Flunt.Validations;
using IncentiveCampaign.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace IncentiveCampaign.Domain.Dtos.Campaign
{
    public class CampaignCreateDto : IEntity
    {        
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }

        public string UserName { get; set; }

        public bool AgreementLetterRequired { get; set; }

        public bool IsValid()
        {                        
            return true;
        }        
    }
}

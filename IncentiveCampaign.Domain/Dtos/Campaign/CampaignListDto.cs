using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Dtos.Campaign
{
    class CampaignListDto
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreationDate { get; set; }

        public string UserName { get; set; }

        public bool AgreementLetterRequired { get; set; }

        public string TermUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Score
    {
        public long Id { get; set; }

        public int Value { get; set; }

        public bool IsBlocked { get; set; }

        public EBlockDescription BlockedDescriprion { get; set; }

        public string Descriprion { get; set; }        

        public string Proposal { get; set; }

        public string Contract { get; set; }        
    }
}

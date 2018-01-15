using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Dealer
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Cpf { get; set; }

        public bool AcceptedTerm { get; set; }

        public bool IsValidated { get; set; }
        
        public List<Score> Scores { get; set; }

        public bool IsValid { get; set; }
    }
}

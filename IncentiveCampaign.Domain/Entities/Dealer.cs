using IncentiveCampaign.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Dealer : Entity
    {
        public Dealer(
            long id, 
            string name, 
            string cpf, 
            bool acceptedTerm, 
            bool isValidated) : base(id, name)
        {
            Cpf = cpf;
            AcceptedTerm = acceptedTerm;
            IsValidated = isValidated;
        }
        
        public string Cpf { get; set; }

        public bool AcceptedTerm { get; set; }

        public bool IsValidated { get; set; }
        
        public List<Score> Scores { get; set; }
        
        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}

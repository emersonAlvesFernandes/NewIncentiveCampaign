using IncentiveCampaign.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Score : Entity
    {
        public Score(
            long id,            
            int value, 
            bool isBlocked, 
            EBlockDescription blockedDescriprion, 
            string descriprion, 
            string proposal, 
            string contract) : base(id, "")
        {
            Value = value;
            IsBlocked = isBlocked;
            BlockedDescriprion = blockedDescriprion;
            Descriprion = descriprion;
            Proposal = proposal;
            Contract = contract;
        }

        public int Value { get; set; }

        public bool IsBlocked { get; set; }

        public EBlockDescription BlockedDescriprion { get; set; }

        public string Descriprion { get; set; }        

        public string Proposal { get; set; }

        public string Contract { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}

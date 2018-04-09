using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts
{
    public abstract class Entity
    {
        protected Entity(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public long Id { get; protected set; }

        public string Name { get; protected set; }

        public abstract bool IsValid();
    }
}

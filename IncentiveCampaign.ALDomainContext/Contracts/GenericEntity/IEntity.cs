namespace IncentiveCampaign.ALDomainContext.Contracts.GenericEntity
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

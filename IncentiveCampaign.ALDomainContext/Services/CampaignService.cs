using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using IncentiveCampaign.ALDomainContext.Contracts.Repository;
using IncentiveCampaign.ALDomainContext.Contracts.Service;
using IncentiveCampaign.ALDomainContext.Domain;
using System;

namespace IncentiveCampaign.ALDomainContext.Services
{
    public class CampaignService : IBaseEntityRepository<Campaign>
    {
        private readonly IBaseEntityRepository<Entity> _db;

        public CampaignService()
        {
            //_db = new BaseEntityRepository<IEntity>();
        }

        private readonly IBaseEntityRepository<Entity> _repository;

        public CampaignService(IBaseEntityRepository<Entity> db)
        {
            _db = db;
        }
        
        public Campaign GetBaseEntity(long id)
        {
            return (Campaign)_db.GetBaseEntity(id);
        }
    }
}

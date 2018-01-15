using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using IncentiveCampaign.ALDomainContext.Contracts.Repository;
using IncentiveCampaign.ALDomainContext.Contracts.Service;
using System;

namespace IncentiveCampaign.ALDomainContext.Services
{
    public class NestedEntityService : IBaseEntityService<IEntity>
    {
        private readonly IBaseEntityRepository<IEntity> _db;

        public NestedEntityService()
        {
            //_db = new BaseEntityRepository<IEntity>();
        }

        public NestedEntityService(IBaseEntityRepository<IEntity> db)
        {
            _db = db;
        }

        public IEntity GetNestedByBaseId(long baseId)
        {
            throw new NotImplementedException();
        }
    }
}

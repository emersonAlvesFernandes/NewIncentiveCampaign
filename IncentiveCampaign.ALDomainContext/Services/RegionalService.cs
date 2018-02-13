using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using IncentiveCampaign.ALDomainContext.Contracts.Repository;
using IncentiveCampaign.ALDomainContext.Contracts.Service;
using IncentiveCampaign.ALDomainContext.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Services
{
    public class RegionalService : INestedEntityService<Regional>
    {
        private readonly INestedEntityRepository<Regional> _db;

        public RegionalService(INestedEntityRepository<Regional> db)
        {
            _db = db;
        }

        public List<Regional> GetNestedByBaseId(long baseId)
        {
            return _db.GetNestedByBaseId(baseId);
        }
    }
}

using IncentiveCampaign.ALDomainContext.Contracts.Repository;
using IncentiveCampaign.ALDomainContext.Contracts.Service;
using IncentiveCampaign.ALDomainContext.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Services
{
    public class DealerService : INestedEntityService<Dealer>, IDealerService
    {
        private readonly INestedEntityRepository<Dealer> _db;

        public DealerService(INestedEntityRepository<Dealer> db)
        {
            _db = db;
        }

        public List<Dealer> GetNestedByBaseId(long baseId)
        {
            return _db.GetNestedByBaseId(baseId);
        }

        public void MarkAsReadyToUse(long userId)
        {
            throw new NotImplementedException();
        }
    }
}

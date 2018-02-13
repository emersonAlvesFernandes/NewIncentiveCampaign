using IncentiveCampaign.ALDomainContext.Contracts.Repository;
using IncentiveCampaign.ALDomainContext.Contracts.Service;
using IncentiveCampaign.ALDomainContext.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Services
{
    public class DealershipService : INestedEntityService<Dealership>, IDealershipService
    {
        private readonly INestedEntityRepository<Dealership> _db;

        public DealershipService(INestedEntityRepository<Dealership> db)
        {
            _db = db;
        }

        public byte[] GetAgreementLetter(long dealershipId)
        {
            throw new NotImplementedException();
        }

        public List<Dealership> GetNestedByBaseId(long baseId)
        {
            return _db.GetNestedByBaseId(baseId);
        }
    }
}

using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using System.Collections.Generic;

namespace IncentiveCampaign.ALDomainContext.Contracts.Repository
{
    public interface INestedEntityRepository<T> where T : Entity
    {
        List<T> GetNestedByBaseId(long baseId);
    }
}

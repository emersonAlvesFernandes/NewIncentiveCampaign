using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using System.Collections.Generic;

namespace IncentiveCampaign.ALDomainContext.Contracts.Service
{
    public interface INestedEntityService<T> where T : Entity
    {
        List<T> GetNestedByBaseId(long baseId);
    }
}

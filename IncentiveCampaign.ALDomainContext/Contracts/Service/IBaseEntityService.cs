using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;

namespace IncentiveCampaign.ALDomainContext.Contracts.Service
{
    public interface IBaseEntityService<T> where T : IEntity
    {
        T GetNestedByBaseId(long baseId);
    }
}

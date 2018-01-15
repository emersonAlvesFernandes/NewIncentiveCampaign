using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;

namespace IncentiveCampaign.ALDomainContext.Contracts.Repository
{
    public interface IBaseEntityRepository<T> where T : IEntity
    {
        T GetNestedByBaseId(long baseId);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.Crud
{
    public interface INestedCrudRepository<T> where T : IEntity
    {
        void DeleteRelationship(long baseEntityId, long childEntityId);

        void CreateRelationship(long baseEntityId, T nestedEntity);
    }
}

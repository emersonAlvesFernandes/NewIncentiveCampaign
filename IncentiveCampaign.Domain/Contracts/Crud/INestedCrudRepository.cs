using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.Crud
{
    public interface INestedCrudRepository<T> where T : Entity
    {
        void DeleteRelationship(long baseEntityId);

        void CreateRelationship(long baseEntityId, long nestedEntityId);
    }
}

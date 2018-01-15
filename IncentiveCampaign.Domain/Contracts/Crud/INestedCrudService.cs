using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.Crud
{
    public interface INestedCrudService<T> where T : IEntity
    {        
        List<T> GetByBaseId(long baseId);

        List<T> Relate(List<T> entity, long baseId, string username);
    }
}

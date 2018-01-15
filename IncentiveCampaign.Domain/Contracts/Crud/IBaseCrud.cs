using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.Crud
{
    public interface IBaseCrud<T> where T : IEntity
    {
        T GetAll();

        T GetById(long id);

        T Create(T baseEntity, string username);

        T Update(T baseEntity, string username);

        T Invalidate(long id, string username);
    }
}

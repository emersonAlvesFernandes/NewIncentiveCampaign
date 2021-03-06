﻿using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Contracts.Repository
{
    public interface IBaseEntityRepository<T> where T : Entity
    {
        T GetBaseEntity(long id);
    }
}

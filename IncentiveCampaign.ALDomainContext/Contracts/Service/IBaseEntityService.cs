﻿using IncentiveCampaign.ALDomainContext.Contracts.GenericEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ALDomainContext.Contracts.Service
{
    public interface IBaseEntityService<T> where T : Entity
    {
        T GetBaseId(long id);
    }
}

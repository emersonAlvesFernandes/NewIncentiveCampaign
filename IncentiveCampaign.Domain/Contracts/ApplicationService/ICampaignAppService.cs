using IncentiveCampaign.Domain.Contracts.Crud;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.ApplicationService
{
    public interface ICampaignAppService : IBaseCrud<Campaign>
    {
    }
}

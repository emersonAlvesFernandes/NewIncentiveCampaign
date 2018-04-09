using IncentiveCampaign.Domain.Contracts.Crud;
using IncentiveCampaign.Domain.Contracts.Notification;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.ApplicationService
{
    public interface ICampaignAppService : IBaseCrud<Campaign>, INotifiable
    {
    }
}

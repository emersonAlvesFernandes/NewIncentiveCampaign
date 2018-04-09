using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.Notification
{
    public interface INotifiable
    {
        void CreateNotification(long id);
    }
}

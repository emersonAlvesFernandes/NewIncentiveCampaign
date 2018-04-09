using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Contracts.Notification
{
    public interface INotificationRepository
    {
        void NotificateAllDealersFromDealership(long dealershipId);

        void NotificateAllDealersFromCampaign(long dealershipId);

        void NotificateDealer(long dealerId);
    }
}

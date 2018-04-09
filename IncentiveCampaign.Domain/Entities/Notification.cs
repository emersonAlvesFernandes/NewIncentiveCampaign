using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Notification
    {
        public long Id { get; set; }

        public string Message { get; set; }

        public List<int> RecipientIds { get; set; }

        public DateTime SentDate { get; set; }
    }
}

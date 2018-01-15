using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.Domain.Entities
{
    public class Regional
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Dealership> Dealerships { get; set; }
    }
}

using AutoMapper;
using IncentiveCampaign.Domain.Contracts;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ViewModel
{
    public class ReadCampaignViewModel : BaseViewModel
    {
        public static IEnumerable<ReadCampaignViewModel> MapList(List<Campaign> modelList) 
            => Mapper.Map<List<ReadCampaignViewModel>>(modelList);

        public static ReadCampaignViewModel Map(Campaign model)
            => Mapper.Map<ReadCampaignViewModel>(model);

        public long Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        //public bool IsActive { get;  set; }

        //public DateTime CreationDate { get; set; }

        //public string UserName { get; set; }

        public bool AgreementLetterRequired { get; set; }

        public string TermUrl { get; set; }
    }
}

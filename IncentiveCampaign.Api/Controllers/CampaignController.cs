using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using IncentiveCampaign.Domain.Contracts.ApplicationService;
using IncentiveCampaign.Domain.Entities;
using IncentiveCampaign.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IncentiveCampaign.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Campaign")]    
    public class CampaignController : Controller
    {
        private readonly ICampaignAppService _campaignAppService;

        public CampaignController(ICampaignAppService campaignAppService)
        {
            _campaignAppService = campaignAppService;
        }
        
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ReadCampaignViewModel>), (int)HttpStatusCode.OK)]        
        public async Task<IEnumerable<ReadCampaignViewModel>> GetAsync()
        {
            var campaigns = await Task.Run(()=> _campaignAppService.GetAll());
            
            return ReadCampaignViewModel.MapList(campaigns);            
        }
    }
}
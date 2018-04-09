using AutoMapper;
using IncentiveCampaign.Domain.Contracts;
using IncentiveCampaign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.ViewModel
{


    public interface IBaseMapObject
    {
        BaseViewModel Map(Entity model);
    }

    public interface IBaseMapObjectList
    {
        IEnumerable<BaseViewModel> MapList(List<Entity> model);
    }


    public class BaseViewModel
    {

    }

    public static class BaseMap
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Campaign, CreateCampaignViewModel>();                
            });
        }        
    }
}

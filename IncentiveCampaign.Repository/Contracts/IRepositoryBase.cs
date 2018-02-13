using System;
using System.Collections.Generic;
using System.Text;

namespace IncentiveCampaign.SqlRepository.Contracts
{
    public interface IRepositoryBase
    {
        bool OpenConnection();

        bool CloseConnection();

        void Initialize();
    }
}

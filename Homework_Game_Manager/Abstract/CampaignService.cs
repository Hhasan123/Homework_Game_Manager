using Homework_Game_Manager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Game_Manager.Abstract
{
    interface CampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);


    }
}

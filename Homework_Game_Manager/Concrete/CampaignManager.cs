using Homework_Game_Manager.Abstract;
using Homework_Game_Manager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Game_Manager.Concrete
{
    class CampaignManager : CampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added. "+ campaign.Title);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted. " + campaign.Title);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated. " + campaign.Title);
        }
    }
}

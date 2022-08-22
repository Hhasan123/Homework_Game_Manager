using Homework_Game_Manager.Concrete;
using Homework_Game_Manager.Entities;
using System;

namespace Homework_Game_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Nickname = "Gamer1";
            Game game = new Game();
            game.Name = "Game1";
            Campaign campaign = new Campaign();
            campaign.Title = "Campaign1";

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            Console.ReadLine();


        }
    }
}

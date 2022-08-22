using Homework_Game_Manager.Abstract;
using Homework_Game_Manager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Game_Manager.Concrete
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            if (gamerCheckManager.EdevletValidation(gamer) == true)
            {
                Console.WriteLine("Gamer added. "+ gamer.Nickname);
            }
            else
            {
                Console.WriteLine("Your identity did not validate.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted. "+ gamer.Nickname);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated. " + gamer.Nickname);
        }
    }
}

using Homework_Game_Manager.Abstract;
using Homework_Game_Manager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Game_Manager.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool EdevletValidation(Gamer gamer)
        {
            Console.WriteLine("Gamer identity validated.");
            return true;
        }
    }
}

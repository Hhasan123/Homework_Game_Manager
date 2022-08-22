using Homework_Game_Manager.Abstract;
using Homework_Game_Manager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Game_Manager.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game added. "+ game.Name);
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Game removed. " + game.Name);
        }

        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.Name+" saled to " +gamer.Nickname);
        }
    }
}

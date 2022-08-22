using Homework_Game_Manager.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Game_Manager.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Sale(Game game, Gamer gamer);
        void Remove(Game game);

    }
}

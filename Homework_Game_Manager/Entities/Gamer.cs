using Homework_Game_Manager.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Game_Manager.Entities
{
    class Gamer : IGamer
    {
        public int Id { get; set; }
        public String TcNo { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Nickname { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
   public class Player
    {
        public Player(int point=0)
        {
            Point = point;
        }

        public int Point { get; set; }
    }
}

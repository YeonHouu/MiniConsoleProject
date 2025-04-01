using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MiniTextRPG
{
   
    public class Player
    {
        private int speed;
        private int hp;

        public int Speed { get { return speed; } set { speed = value; } }
        public int Hp { get { return hp; } set { hp = value; } }
    }
}

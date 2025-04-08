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
        private int exp;
        private int level;

        private string playerLocation;
        public int Speed { get { return speed; } set { speed = value; } }
        public int Hp { get { return hp; } set { hp = value; } }
        public int Exp { get { return exp; } set { exp = value; } }
        public int Level { get { return level; } set { level = value; } }
        
        public Player()
        {
            Hp = 100;
            Speed = 10;
            Exp = 0;
            Level = 1;
        }
                       
    }
}

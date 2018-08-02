using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types.super
{
    class SuperWarrior : Warrior
    {
        public SuperWarrior(string name)
        {
            Name = name + Name;
        }
    }
}

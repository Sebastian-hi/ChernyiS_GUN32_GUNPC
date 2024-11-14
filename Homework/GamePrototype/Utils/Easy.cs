using GamePrototype.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Utils
{
    internal class Easy : Difficulty
    {
        public override void GoblinDifficulty()
        {
            new Goblin(GameConstants.Goblin, 18, 18, 2);
        }
            
    }
}



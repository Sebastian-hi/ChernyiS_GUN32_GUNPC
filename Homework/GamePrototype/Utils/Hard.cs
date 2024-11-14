using GamePrototype.Units;
using GamePrototype.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype
{
    internal class Hard : Difficulty
    {
        public override void GoblinDifficulty()
        {
            new Goblin(GameConstants.Goblin, 25, 25, 4);
        }
        
    }
}

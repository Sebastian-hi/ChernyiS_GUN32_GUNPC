using GamePrototype.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Utils
{
    internal class Hard : Difficulty
    {
        public override void GoblinDifficulty()
        {
            new Goblin(GameConstants.Goblin, 25, 25, 4);
        }
        
    }
}

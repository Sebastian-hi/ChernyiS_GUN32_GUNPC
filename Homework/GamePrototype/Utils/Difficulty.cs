﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePrototype.Utils
{
    abstract class Difficulty
    {
        public abstract void GoblinDifficulty();

    }

    public enum DifficultyChoise
    {
        Easy,
        Hard
    }
}
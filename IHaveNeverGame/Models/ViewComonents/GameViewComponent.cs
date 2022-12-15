﻿using IHaveNeverGame.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IHaveNeverGame.Models.ViewComonents
{
    public class GameViewComponent
    {
        public List<Player> Players { get; set; }
        public List<Question> Questions { get; set; }
    }
}
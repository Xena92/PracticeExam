﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NytSalgsSystem
{
    public enum smiley { Happy, Neutral, Unhappy };

    public interface ISmiley
    {
        smiley GetSmiley();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenCast
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}

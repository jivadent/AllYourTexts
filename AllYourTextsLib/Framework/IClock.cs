﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllYourTextsLib.Framework
{
    public interface IClock
    {
        DateTime CurrentTime();
    }
}
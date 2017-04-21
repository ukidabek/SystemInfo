﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfo
{
    public class Units
    {
        public const float Bits_In_Gibabyte = 1073741824f;

        public static float BitesToGigabites(long bytes)
        {
            return bytes / Bits_In_Gibabyte;
        }
    }
}

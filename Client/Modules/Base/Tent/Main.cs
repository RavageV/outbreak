﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace Outbreak.Base
{
    public partial class Tent : BaseScript
    {
        Translation Translate { get; } = new Translation(Config.Lang);
        public Tent()
        {
            Events();
            Locales();

        }
    }
}

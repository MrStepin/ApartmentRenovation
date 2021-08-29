﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public interface IWallpapers
    {
        Wallpapers CreateDarkWallpapers();

        Wallpapers CreateLightWallpapers();

    }
}

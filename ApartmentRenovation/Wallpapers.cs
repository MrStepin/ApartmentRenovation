using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class Wallpapers : IWallpapers
    {
        
        public Wallpapers CreateDarkWallpapers()
        {
            return new DarkWallpapers();
        }

        public Wallpapers CreateLightWallpapers()
        {
            return new LightWallpapers();
        }
    }
}

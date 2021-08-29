using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class Room : IRoom
    {
        public IWallpapers CreateWallpapers()
        {
            return new Wallpapers();
        }

        public IChandelier CreateChandelier()
        {
            return new Chandelier();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class LightRoomFactory : IFactory
    {
        public IWallpapers CreateWallpapers()
        {
            return new LightWallpapers();
        }

        public IChandelier CreateChandelier()
        {
            return new LightChandelier();
        }
    }
}

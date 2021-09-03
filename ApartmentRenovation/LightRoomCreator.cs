using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class LightRoomCreator : IFactory
    {
        public IWallpapers CreateWallpapers()
        {
            return new LightChandelier();
        }

        public IChandelier CreateChandelier()
        {
            return new LightWallpapers();
        }
    }
}

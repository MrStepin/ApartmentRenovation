using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class DarkRoomFactory : IFactory
    {
        public IChandelier CreateChandelier()
        {
            return new DarkChandelier();
        }

        public IWallpapers CreateWallpapers()
        {
            return new DarkWallpapers();
        }
    }
}

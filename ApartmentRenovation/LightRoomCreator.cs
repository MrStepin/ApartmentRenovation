using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class LightRoomCreator : IFactory
    {
        public Room CreateRoom()
        {
            Room room = new Room();
            room.Chandelier = new LightChandelier();
            room.Wallpaper = new LightWallpapers();

            return room;
        }
    }
}

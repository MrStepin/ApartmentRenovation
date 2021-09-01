using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class DarkRoomCreator : IFactory
    {
        public Room CreateRoom()
        {
            Room room = new Room();
            room.Chandelier = new DarkChandelier();
            room.Wallpaper = new DarkWallpapers();

            return room;
        }
    }
}

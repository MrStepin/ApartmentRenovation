using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class DarkRoomCreator : IRoomFactory
    {
        public Room CreateRoom()
        {
            Room room = new Room();
            room.CreateChandelier().CreateDarkChandelier();
            room.CreateWallpapers().CreateDarkWallpapers();

            return room;
        }
    }
}

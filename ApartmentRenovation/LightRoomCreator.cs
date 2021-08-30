using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class LightRoomCreator : IRoomFactory

    {
    public Room CreateRoom()
    {
        Room room = new Room();
        room.CreateChandelier().CreateLightChandelier();
        room.CreateWallpapers().CreateLightWallpapers();

        return room;
    }
    }
}

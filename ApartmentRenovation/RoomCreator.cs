using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class RoomCreator
    {
        public Room CreateRoom(string styleOfFlat)
        {
            Room room = new Room();

            if (styleOfFlat == "Light")
            {
                room = new LightRoomCreator().CreateRoom();
            }
            if (styleOfFlat == "Dark")
            {
                room = new DarkRoomCreator().CreateRoom();
            }

            return room;
        }
    }
}

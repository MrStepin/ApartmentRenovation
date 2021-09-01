using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class RoomCreator
    {
        public IFactory CreateRoom(string styleOfFlat)
        {
            if (styleOfFlat == "Light")
            {
                return new LightRoomCreator();
            }
            if (styleOfFlat == "Dark")
            {
                return new DarkRoomCreator();
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class RoomCreator
    {
        public (IWallpapers, IChandelier) CreateRoom(string styleOfFlat)
        {

            if (styleOfFlat == "Light")
            {
                return CreateStyle(new LightRoomCreator());
            }
            if (styleOfFlat == "Dark")
            {
                return CreateStyle(new DarkRoomCreator());
            }

            return (null,null);
        }

        public (IWallpapers,IChandelier) CreateStyle(IFactory roomStyle)
        {
            return (roomStyle.CreateWallpapers(), roomStyle.CreateChandelier());
        }
    }
}

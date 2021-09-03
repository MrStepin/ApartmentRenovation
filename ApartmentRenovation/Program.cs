using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms do you want?");
            int qtyOfRooms = Convert.ToInt32(Console.ReadLine());

            Room[] rooms = new Room[qtyOfRooms];

            Console.WriteLine("What style of flat do you want?");
            string styleOfFlat = Console.ReadLine();

            Room newRoom = new Room();

            for (int i = 0; i < qtyOfRooms; i++)
            {
                rooms[i] = newRoom;
                newRoom.Chandelier = CreateRoom(styleOfFlat).CreateChandelier();
                newRoom.Wallpapers = CreateRoom(styleOfFlat).CreateWallpapers();
            }
        }

        public static IFactory CreateRoom(string styleOfFlat)
        {

            if (styleOfFlat == "Light")
            {
                return new LightRoomFactory();
            }
            if (styleOfFlat == "Dark")
            {
                return new DarkRoomFactory();
            }

            return  null;
        }
    }
}

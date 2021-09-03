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

            (IWallpapers, IChandelier)[] rooms = new (IWallpapers, IChandelier)[qtyOfRooms];

            Console.WriteLine("What style of flat do you want?");
            string styleOfFlat = Console.ReadLine();

            (IWallpapers, IChandelier) newRoom = new RoomCreator().CreateRoom(styleOfFlat);

            for (int i = 0; i < qtyOfRooms; i++)
            {
                rooms[i] = newRoom;
            }
        }
    }
}

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

            IRoomFactory[] rooms = new IRoomFactory[qtyOfRooms];

            Console.WriteLine("What style of flat do you want?");
            string styleOfFlat = Console.ReadLine();

            for (int i = 0; i < qtyOfRooms; i++)
            {
                if (styleOfFlat == "Light")
                {
                    rooms[i] = new CreateLightRoom();
                }
                if (styleOfFlat == "Dark")
                {
                    rooms[i] = new CreateDarkRoom();
                }
            }
        }
    }
}

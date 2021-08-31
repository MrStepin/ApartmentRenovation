using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public interface IRoom
    {
        Wallpapers Wallpaper { get; set; }

        Chandelier Chandelier { get; set; }
    }
}

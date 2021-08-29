using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentRenovation
{
    public class Chandelier : IChandelier
    {
        public Chandelier CreateDarkChandelier()
        {
            return new DarkChandelier();
        }

        public Chandelier CreateLightChandelier()
        {
            return new LightChandelier();
        }
    }
}

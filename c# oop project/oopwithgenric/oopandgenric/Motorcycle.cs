using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public sealed class Motorcycle:Twowheeler
    {
        public Motorcycle()
        {
            
        }
        public Motorcycle(string modelno, int yearmake, int numofgear, int enginecapcc, Vehicletype vehicletype, string startm, int mbph, int mnm, int mileage, string cooling, string fbrake, string rbrake) : base(modelno, yearmake, numofgear, enginecapcc, vehicletype,  startm,  mbph,  mnm,  mileage,  cooling, fbrake, rbrake)
        
        {
            
        }
    }
}

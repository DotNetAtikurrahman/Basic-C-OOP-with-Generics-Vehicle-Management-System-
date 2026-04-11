using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public sealed class Car:Fourwheeler
    {
        public Car()
        {
            
        }
        public Car(string modelno, int yearmake, int numofgear, int enginecapcc, Vehicletype vehicletype, int numofseat, int numofdoor) : base(modelno, yearmake, numofgear, enginecapcc, vehicletype, numofseat,  numofdoor)
        {
            
        }
    }
}

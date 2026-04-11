using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public abstract class Vehicle
    {

        public string modelno { get; set; }
        public int yearmake { get; set; }
        public int  numofgear { get; set; }
        public int enginecapcc { get; set; }
        public Vehicletype vehicletype { get; set; }


        public Vehicle()
        {
            
        }
        protected Vehicle(string modelno,int yearmake,int numofgear,int enginecapcc,Vehicletype vehicletype)
        {
          this.modelno = modelno;
            this.yearmake = yearmake;
            this.numofgear = numofgear;
            this.enginecapcc = enginecapcc;
            this.vehicletype = vehicletype;

        }


        public abstract string detail();

    }
}

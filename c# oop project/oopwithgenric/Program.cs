using oopwithgenric.oopandgenric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Motorcycle m = new Motorcycle("pulsar 150",2025,5,160,Vehicletype.personal,"self and kick",130,120,45,"air cooler","disk","disk");
            m.addexteriordesign("vip horn","comfort seat");
            Igenricimp<Motorcycle> mi = new Igenricimp<Motorcycle>();
            Console.WriteLine(mi.getdetail<Motorcycle>(m));
            Console.WriteLine(m.getexteriordesign());

            Console.WriteLine();
            Car c = new Car("toyota corolla",2025,5,1200,Vehicletype.familly,4,4);
            c.addinteriordesign("wifi 8","vip seat");
            Ivehicleimp<Car> ci = new Ivehicleimp<Car>();
            Console.WriteLine(ci.getdetail<Car>(c));
            Console.WriteLine(c.getinteriordesign());

        }
    }
}

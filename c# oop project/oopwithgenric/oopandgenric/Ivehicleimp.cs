using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public class Ivehicleimp<T> : Ivehicle<T>
    {
        public string getdetail<T1>(T1 obj) where T1 : Vehicle
        {
            return obj.detail();
        }
    }
}

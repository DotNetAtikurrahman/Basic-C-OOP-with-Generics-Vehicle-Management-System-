using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public class Igenricimp<T> : Igenric<T>
    {
        public string getdetail<T1>(T1 obj)
        {
            if (obj is Vehicle)
            {
                Vehicle v = obj as Vehicle;
                return v.detail();
            }
            else
            {
                return "not a vehicle";
            }
        }
    }
}

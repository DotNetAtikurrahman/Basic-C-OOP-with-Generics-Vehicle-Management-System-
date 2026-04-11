using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public interface Ivehicle<T>
    {
        string getdetail<T>(T obj) where T : Vehicle;
    }
}

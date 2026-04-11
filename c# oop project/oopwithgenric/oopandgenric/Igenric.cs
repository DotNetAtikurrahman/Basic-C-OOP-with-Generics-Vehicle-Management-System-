using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public interface Igenric<T>
    {
        string getdetail<T>(T obj);
    }
}

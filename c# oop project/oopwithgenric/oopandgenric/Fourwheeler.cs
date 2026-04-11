using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public class Fourwheeler : Vehicle, Iinteriordesign
    {
        private List<string> indesign  = new List<string>();

        public int  numofseat { get; set; }
        public int numofdoor { get; set; }

        public Fourwheeler()
        {
            
        }
        public Fourwheeler(string modelno, int yearmake, int numofgear, int enginecapcc, Vehicletype vehicletype, int numofseat, int numofdoor) :base( modelno,  yearmake, numofgear,  enginecapcc,  vehicletype)
        {
            this.numofseat = numofseat;
            this.numofdoor = numofdoor;

        }











        public void addinteriordesign(params string[] design)
        {
            this.indesign.AddRange(design);
        }

        public override string detail()
        {
            return $"{modelno}{yearmake}{numofgear}{numofdoor}{enginecapcc}{vehicletype}";
        }

        public string getinteriordesign()
        {
           return string.Join(", ", indesign);  
        }
    }
}

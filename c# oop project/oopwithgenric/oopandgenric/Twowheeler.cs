using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopwithgenric.oopandgenric
{
    public class Twowheeler : Vehicle, Iexteriordesign
    {
        private List<string> exdesign    = new List<string>();

        public string stratm { get; set; }
        public int mbph      { get; set; }

        public int mnm { get; set; }
        public int mileage { get; set; }
        public string cooling { get; set; }
        public string fbrake { get; set; }
        public string  rbrake { get; set; }



        public Twowheeler()
        {
            
        }
        public Twowheeler(string modelno, int yearmake, int numofgear, int enginecapcc, Vehicletype vehicletype, string startm, int mbph, int mnm,int mileage, string cooling, string fbrake, string rbrake):base  ( modelno,  yearmake,  numofgear, enginecapcc,  vehicletype)
        {
            this.stratm = stratm;
            this.mbph = mbph;
            this.mnm = mnm;
            this.mileage = mileage;
            this.cooling = cooling;
            this.fbrake = fbrake;
            this.rbrake = rbrake;

        }





        public void addexteriordesign(params string[] design)
        {
            this.exdesign.AddRange(design);

        }

        public override string detail()
        {
            return $"{modelno}{yearmake}{numofgear}{stratm}{enginecapcc}{mbph}{mnm}{mileage}{cooling}{fbrake}{rbrake}{vehicletype}";
        }

        public string getexteriordesign()
        {
           return string.Join(", ", this.exdesign);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
    public class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //method
        public void PickUpPassager()
        {
            Console.WriteLine("Drive Name: {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty ? "Yes" : "No");
            Console.WriteLine("Number of Passenger: {0}\n", NumPassenger);
            Console.WriteLine("sedang menjemput penumpang");

        }

        public void TaxiInfo()
        {
            Console.WriteLine("Taxi Info");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("selesai mengantar penumpang");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_project
{
    public class Printer
    {
        public string Brand = "HP";
        private string PrinterModel = "LaserJet Pro";
        protected string PrintTechnology = "Laser";
        internal string Connectivity = "Wireless";
        internal protected int TrayCapacity = 250;

        public void DisplayPrinterInfo()
        {
            Console.WriteLine($"PrinterBrand : {Brand}");
            Console.WriteLine($"PrinterModel : {PrinterModel}");
            Console.WriteLine($"PrintTechnology : {PrintTechnology}");
            Console.WriteLine($"Connectivity : {Connectivity}");
            Console.WriteLine($"TrayCapacity : {TrayCapacity}");
        }
    }
    public class PrinterInfo1 : Printer
    {
        public void DisplayPrinterInfo1()
        {
            Console.WriteLine($"PrinterBrand : {Brand}");
            //Console.WriteLine($"PrinterModel : {PrinterModel}");
            Console.WriteLine($"PrintTechnology : {PrintTechnology}");
            Console.WriteLine($"Connectivity : {Connectivity}");
            Console.WriteLine($"TrayCapacity : {TrayCapacity}");
        }

    }
    public class PrinterInfo2
    {
        Printer p = new Printer();
        public void DisplayPrinterInfo2()
        {
            Console.WriteLine($"PrinterBrand : {p.Brand}");
            //Console.WriteLine($"PrinterModel : {p.PrinterModel}");
            //Console.WriteLine($"PrintTechnology : {p.PrintTechnology}");
            Console.WriteLine($"Connectivity : {p.Connectivity}");
            Console.WriteLine($"TrayCapacity : {p.TrayCapacity}");
        }

    }
}

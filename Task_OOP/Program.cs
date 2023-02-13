using Reference_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samsung s = new Samsung();
            Console.WriteLine("Mobile Information");
            Console.WriteLine("----------------");
            Console.WriteLine("IMEI Number: " + s.GetIEMINum());
            Console.WriteLine("Release Year: " + s.ReleaseYear());
            Console.Write("WIFI Connection: ");
            s.GetWIFIConnection();
            Console.Write("Camera Click: ");
            s.CameraClick();
            Console.Write("Camera Click in Night Mode: ");
            s.CameraClick("Night");
            Console.Write("Message Sent: ");
            s.SendMessage();
            Console.WriteLine();

            Book book = new Book();
            book.name = "Blood of Elves";
            book.price = 20.00;
            Console.WriteLine("Book Information");
            Console.WriteLine("----------------");
            book.printInformation();
            Console.WriteLine("Tax: $" + book.computeTax());
            Console.WriteLine();

            Clothing clothing = new Clothing();
            clothing.name = "T-Shirt";
            clothing.price = 30.0;
            Console.WriteLine("Clothing Information");
            Console.WriteLine("--------------------");
            clothing.printInformation();
            Console.WriteLine("Tax: $" + clothing.computeTax());
            Console.WriteLine();


            PrinterInfo1 printerInfo1 = new PrinterInfo1();
            PrinterInfo2 printerInfo2 = new PrinterInfo2();
            PrinterInfo3 printerInfo3 = new PrinterInfo3();
            PrinterInfo4 printerInfo4 = new PrinterInfo4();

            Console.WriteLine("Printer Information using referance project with different access modifiers");
            Console.WriteLine("---------------------------------------------------------------------------");
            printerInfo1.DisplayPrinterInfo1(); Console.WriteLine();
            printerInfo2.DisplayPrinterInfo2(); Console.WriteLine();
            printerInfo3.DisplayPrinterInfo3(); Console.WriteLine();
            printerInfo4.DisplayPrinterInfo4(); Console.WriteLine();
        }
    }

    public class PrinterInfo3 : Printer
    {
        public void DisplayPrinterInfo3()
        {
            Console.WriteLine($"PrinterBrand : {Brand}");
            //Console.WriteLine($"PrinterModel : {PrinterModel}");
            Console.WriteLine($"PrintTechnology : {PrintTechnology}");
            //Console.WriteLine($"Connectivity : {Connectivity}");
            Console.WriteLine($"TrayCapacity : {TrayCapacity}");
        }
    }
    public class PrinterInfo4
    {
        Printer p = new Printer();
        public void DisplayPrinterInfo4()
        {
            Console.WriteLine($"PrinterBrand : {p.Brand}");
            //Console.WriteLine($"PrinterModel : {p.PrinterModel}");
            //Console.WriteLine($"PrintTechnology : {p.PrintTechnology}");
            //Console.WriteLine($"Connectivity : {p.Connectivity}");
            //Console.WriteLine($"TrayCapacity : {p.TrayCapacity}");
        }

    }
}

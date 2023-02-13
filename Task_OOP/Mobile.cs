using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_OOP
{
    public interface IMobile
    {
        string GetIEMINum();
        int ReleaseYear();

    }


    public class Mobile : IMobile  // Implementing Interface
    {

        private string IEMICode { get; set; }
        protected string SIMCard { get; set; }
        public string ROM { get; }
        internal protected int RAM { get; }

        public Mobile() { }
        public Mobile(string iEMICode, string sIMCard, string rOM, int rAM)
        {
            IEMICode = iEMICode;
            SIMCard = sIMCard;
            ROM = rOM;
            RAM = rAM;
        }

        public string GetIEMINum()
        {
            return "IEDF34343435235";
        }
        public int ReleaseYear()
        {
            return 2023;
        }

        public void Dial()
        {
            Console.WriteLine("Dial a number");
        }
        public void Receive()
        {
            Console.WriteLine("Receive a call");
        }
        public virtual void SendMessage()
        {
            Console.WriteLine("Message Sent");
        }

    }

    public class Samsung : Mobile // Inharitance
    {
        public Samsung() { }

        public void GetWIFIConnection()
        {
            Console.WriteLine("WIFI connected");
        }
        public void CameraClick()
        {
            Console.WriteLine("Camera clicked");
        }

        //Method Overloading
        public void CameraClick(string CameraMode)
        {
            Console.WriteLine("Camera clicked in " + CameraMode + " Mode");
        }

        //Method Ovveriding
        public override void SendMessage()
        {
            Console.WriteLine("Message Sent to Group");
        }
    }
}

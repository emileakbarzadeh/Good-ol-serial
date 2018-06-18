using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace GoodOldSerial
{
    internal class Program
    {
        public static SerialPort serial;

        private static void Main(string[] args)
        {
            basicSetup();
            while (true)
            {
                serial.WriteLine(Console.ReadLine());
            }
        }

        private static void basicSetup()
        {
            Console.WriteLine("Port?");
            string port = Console.ReadLine();
            Console.WriteLine("Baud Rate?");
            int rate = Convert.ToInt32(Console.ReadLine());
            serial = new SerialPort(port, rate);
            serial.Open();
            serial.DataReceived += dataReceive;
        }

        private static void dataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine(serial.ReadLine());
        }
    }
}
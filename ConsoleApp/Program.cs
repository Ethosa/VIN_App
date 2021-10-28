using System;
using VIN_LIB;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VIN vin = new VIN();
            Console.WriteLine(vin.CheckVIN("JH4KB16535L011820"));
            Console.WriteLine(vin.CheckVIN("QLAJB82Z2XK338143"));
        }
    }
}

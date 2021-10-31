using System;
using VIN_LIB;
using REG_MARK_LIB;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VIN vin = new VIN();
            Console.WriteLine(vin.CheckVIN("JH4KB16535L011820"));
            Console.WriteLine(vin.CheckVIN("QLAJB82Z2XK338143"));

            RegMark regMark = new RegMark();
            Console.WriteLine(regMark.CheckMark("a999aa999"));
            Console.WriteLine(regMark.GetNextMarkAfter("B123AP999"));
            Console.WriteLine(regMark.GetNextMarkAfter("O999BE999"));
        }
    }
}

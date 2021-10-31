using System;
using VIN_LIB;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VIN vin = new VIN();
            StartMenu();

            //Console.WriteLine(vin.CheckVIN("JH4KB16535L011820"));
            //Console.WriteLine(vin.CheckVIN("QLAJB82Z2XK338143"));

            void StartMenu()
            {
                Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
                    "1) Тестирование CheckVIN\n" +
                    "2) Тестирование GetVINCountry\n" +
                    "3) Тестирование GetTransportYear\n" +
                    "4) Тестирование парсинга\n\n" +
                    "Введите параметр: ");
                int par = Convert.ToInt16(Console.ReadLine());

                switch (par)
                {
                    case 1:
                        Console.Clear();
                        CheckVin();
                        break;
                    case 2:
                        Console.Clear();
                        GetVinCountry();
                        break;
                    case 3:
                        Console.Clear();
                        GetTransportYear();
                        break;
                    case 4:
                        Console.Clear();
                        ParseTest();
                        break;
                    default:
                        Console.Clear();
                        StartMenu();
                        break;
                }

            }

            void CheckVin()
            {
                Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
                    "Проверка валидности VIN-кода\n\n" +
                    "Введите VIN: \n");
                string par = Console.ReadLine();

                Console.WriteLine(vin.CheckVIN(par));
                Shit();

            }
            void GetVinCountry()
            {
                Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
                    "Получение страны-изготовителя из VIN-кода\n\n" +
                    "Введите VIN: \n");
                string par = Console.ReadLine();

                Console.WriteLine(vin.GetVINCountry(par));
            }
            void GetTransportYear()
            {
                Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
                   "Получение года изготовления ТС из VIN-кода\n\n" +
                   "Введите VIN: \n");
                string par = Console.ReadLine();

                Console.WriteLine(vin.GetTransportYear(par));
            }
            void ParseTest()
            {

            }
            
            //Я не знаю зачемя это написал
            void Shit(){
                Console.WriteLine($"\n\n9) Вернуться\n" +
                    $"0) Выход");
                int par = Convert.ToInt16(Console.ReadLine());
                switch (par)
                {
                    case 9:  Console.Clear(); StartMenu(); break;
                    default: Environment.Exit(0); break;

                }
            }

        }


    }
}

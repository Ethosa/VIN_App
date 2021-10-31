using System;
using VIN_LIB;
using REG_MARK_LIB;

namespace ConsoleApp
{
    class Program
    {
        private VIN vin = new VIN();
        private RegMark reg = new RegMark();

        static void Main(string[] args)
        {
            Program main = new Program();
            main.StartMenu();
        }

        private void StartMenu()
        {
            Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
                     "1) Тестирование CheckVIN\n" +
                     "2) Тестирование GetVINCountry\n" +
                     "3) Тестирование GetTransportYear\n" +
                     "4) Тестирование парсинга\n\n" +
                     "Библиотека REG_MARK_LIB.dll\n\n" +
                     "5) Тестирование CheckMark\n" +
                     "6) Тестирование GetNextMarkAfter\n" +
                     "7) Тестирование GetNextMarkAfterInRange\n" +
                     "8) Тестирование GetCombinationsCountInRange\n\n" +
                     "Введите параметр: ");
            int par = Convert.ToInt16(Console.ReadLine());

            switch (par)
            {
                case 1:
                    Console.Clear();
                    CheckVinActivity();
                    break;
                case 2:
                    Console.Clear();
                    GetVinCountryActivity();
                    break;
                case 3:
                    Console.Clear();
                    GetTransportYearActivity();
                    break;
                case 4:
                    Console.Clear();
                    ParseTestActivity();
                    break;
                case 5:
                    Console.Clear();
                    CheckMarkActivity();

                    break;
                case 6:
                    Console.Clear();
                    GetNextMarkAfterActivity();
                    break;
                case 7:
                    //Console.Clear();
                    //GetNextMarkAfterInRangeActivity()
                    break;
                case 8:
                    //Console.Clear();
                    //GetCombinationsCountInRangeActivity()
                    break;
                default:
                    Console.Clear();
                    StartMenu();
                    break;
            }

        }

        public void CheckVinActivity()
        {
            Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
                "Проверка валидности VIN-кода\n\n" +
                "Введите VIN: \n");
            string par = Console.ReadLine();
            bool resp = vin.CheckVIN(par);
            switch (resp)
            {
                case true:
                    Console.WriteLine($"Код {par} является действительным."); 
                    break; 
                case false:
                    Console.WriteLine($"Код {par} не является действительным."); 
                    break;
            }
            ExitActionsActivity();

        }
        public void GetVinCountryActivity()
        {
            Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
                "Получение страны-изготовителя из VIN-кода\n\n" +
                "Введите VIN: \n");
            string arg = Console.ReadLine();

            Console.WriteLine(vin.GetVINCountry(arg));
                ExitActionsActivity();
        }
        public void GetTransportYearActivity()
        {
            Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
               "Получение года изготовления ТС из VIN-кода\n\n" +
               "Введите VIN: \n");
            string arg = Console.ReadLine();

            Console.WriteLine(vin.GetTransportYear(arg));
            ExitActionsActivity();
        }
        public void ParseTestActivity()
        {
         
            Console.WriteLine($"Библиотека VIN_LIB.dll\n\n" +
               "Парсинг VIN-кода\n\n" +
               "Введите VIN: \n");
            string arg = Console.ReadLine();
            string wmi = vin.GetValue(vin.vinRule.Match(arg), "wmi"),
                   vds = vin.GetValue(vin.vinRule.Match(arg), "vds"),
                   vis = vin.GetValue(vin.vinRule.Match(arg), "vis"),
                   csign = vin.GetValue(vin.vinRule.Match(arg), "sign");

            Console.WriteLine($"Детальная информация для {arg}:\n\n" +
                $"WMI: {wmi}\n" +
                $"VDS: {vds}\n" +
                $"VIS: {vis}\n" +
                $"Контрольный знак: {csign}" +
                $"");
            ExitActionsActivity();
        }

        public void CheckMarkActivity()
        {
            Console.WriteLine($"Библиотека REG_MARK_LIB.dll\n\n" +
              "Проверка валидности номерного знака\n\n" +
              "Введите номер в формате а999аа999: \n");
            string pl = Console.ReadLine();
            bool resp = reg.CheckMark(pl);
            switch (resp)
            {
                case true:
                    Console.WriteLine($"Гос.номер {pl} является действительным.");
                    break;
                case false:
                    Console.WriteLine($"Гос.номер {pl} не является действительным.");
                    break;
            }
            ExitActionsActivity();


        }

        public void GetNextMarkAfterActivity()
        {
            Console.WriteLine($"Библиотека REG_MARK_LIB.dll\n\n" +
              "Генерация нового номерного знака\n\n" +
              "Введите номер предыдущего знака в формате а999аа999: \n");
            string pl = Console.ReadLine();

            Console.WriteLine(reg.GetNextMarkAfter(pl));
            ExitActionsActivity();
        }
        public void GetNextMarkAfterInRangeActivity() { }
        public void GetCombinationsCountInRangeActivity() { }

        public void ExitActionsActivity()
        {
            Console.WriteLine($"\n\n9) Вернуться\n" +
                $"0) Выход");
            int par = Convert.ToInt16(Console.ReadLine());
            switch (par)
            {
                case 9:
                    Console.Clear();
                    StartMenu();
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}

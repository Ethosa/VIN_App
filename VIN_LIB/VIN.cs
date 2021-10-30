using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace VIN_LIB
{
    public class VIN
    {
        // Словарь содержит в себе модельные годы автомобилей, начиная с 1980-го
        // A: 1980, B: 1981, etc.
        private Dictionary<char, int> yearsModel = new Dictionary<char, int>();
        
        // Регулярка ниже парсит VIN и режет на отдельные куски.
        // wmi - World Manufacturers entification
        // vds - vehicle description section
        // sign - Control sign
        // modelYear - vehicle model year
        // vis - vehicle identification section
        private Regex vin_rule = new Regex(
            @"^(?<wmi>[a-hj-npr-z1-9]{3})(?<vds>[a-hj-npr-z0-9]{5})(?<sign>[0-9x]{1})(?<modelYear>[a-hj-npr-tv-y1-9]{1})(?<vis>[a-hj-npr-z0-9]{7})$",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// Простой конструктор, заполняющий словарь yearsModel при инициализации.
        /// </summary>
        public VIN()
        {
            int year = 1980;
            for (int i = 65; i <= 89; ++i)  // A..Z
            {
                if (i == 81 || i == 79 || i == 73 || i == 85)
                    continue;
                yearsModel.Add((char)i, year);
                ++year;
            }
            for (int i = 49; i <= 57; ++i)  // 0..9
            {
                yearsModel.Add((char)i, year);
                ++year;
            }
        }

        /// <summary>
        /// Проверяет валидность VIN
        /// </summary>
        /// <param name="vin">VIN, требующий проверки</param>
        /// <returns>true, если VIN валиден</returns>
        public Boolean CheckVIN(String vin)
        {
            return vin_rule.Match(vin).Success;
        }

        /// <summary>
        /// Получает страну-изготовитель транспорта
        /// </summary>
        /// <param name="vin"></param>
        /// <returns></returns>
        public String GetVINCountry(String vin)
        {
            return "";
        }

        public int GetTransportYear(String vin)
        {
            return GetTransportYear(vin_rule.Match(vin));
        }

        /// <summary>
        /// Разбирает значения, полученные с matched.
        /// </summary>
        /// <param name="matched">VIN, прошедший проверку регуляркой</param>
        /// <param name="key">Требуемое значение</param>
        /// <returns>Полученное значение</returns>
        private String getValue(Match matched, String key)
        {
            if (matched.Success)
                return matched.Groups[key].Value;
            return "";
        }

        private int GetTransportYear(Match matched)
        {
            if (!matched.Success)
                return -1;
            char val = matched.Groups["modelYear"].Value[0];
            return yearsModel[val];
        }
    }
}

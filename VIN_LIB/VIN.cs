using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace VIN_LIB
{
    public class VIN
    {
        private Dictionary<char, int> yearsModel = new Dictionary<char, int>();
        private Regex vin_rule = new Regex(
            @"^(?<wmi>[a-z1-9]{3})(?<vds>[a-z0-9]{5})(?<sign>[0-9x]{1})(?<modelYear>[a-hj-npr-tv-y1-9]{1})(?<vis>[a-z0-9]{7})$",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

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

        public Boolean CheckVIN(String vin)
        {
            if (vin.Contains('Q') || vin.Contains('O') || vin.Contains('I'))
                return false;
            return vin_rule.Match(vin).Success;
        }

        public String GetVINCountry(String vin)
        {
            return "";
        }

        public int GetTransportYear(String vin)
        {
            return GetTransportYear(vin_rule.Match(vin));
        }

        /// <summary>
        /// Parses value from matched VIN.
        /// </summary>
        /// <param name="matched"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public String getValue(Match matched, String key)
        {
            if (matched.Success)
                return matched.Groups[key].Value;
            return "";
        }

        public int GetTransportYear(Match matched)
        {
            if (!matched.Success)
                return -1;
            char val = matched.Groups["modelYear"].Value[0];
            return yearsModel[val];
        }
    }
}

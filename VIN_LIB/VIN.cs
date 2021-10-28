using System;
using System.Text.RegularExpressions;

namespace VIN_LIB
{
    public class VIN
    {
        public Boolean CheckVIN(String vin)
        {
            Regex rx = new Regex(
                @"^(?<wmi>[a-z1-9]{3})(?<vds>[a-z0-9]{5})(?<sign>[0-9x]{1})(?<vsi>[a-z0-9]{8})(?<![OQI])$",
                RegexOptions.IgnoreCase | RegexOptions.Compiled);
            return rx.Match(vin).Success;
        }

        public String GetVINCountry(String vin)
        {
            return "";
        }

        public int GetTransportYear(String vin)
        {
            return 0;
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace REG_MARK_LIB
{
    public class RegMark
    {
        private string seriesChars = "ABCEHKMOPTYX";

        private Regex markRule = new Regex(
            @"^(?<before>[abekmhopctyx])(?<number>[0-9]{3})(?<after>[abekmhopctyx]{2})(?<region>[0-9]{2,3})$",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        public Boolean CheckMark(String mark)
        {
            return markRule.Match(mark).Success;
        }

        public String GetNextMarkAfter(String mark)
        {
            Match matched = markRule.Match(mark);
            // Если regMark не прошел проверку - возвращаем пустую строку.
            if (!matched.Success)
                return "";

            // Разбираем regMark
            string series = GetValue(matched, "before") + GetValue(matched, "after");
            string number = GetValue(matched, "number");
            int num = int.Parse(GetValue(matched, "number"), NumberStyles.Number);
            int length = seriesChars.Length;
            string result = "";

            if (num < 999)
            {
                ++num;
                if (num < 10)
                    number = "00" + num.ToString();
                else if (num < 100)
                    number = "0" + num.ToString();
                else
                    number = num.ToString();
                result = GetValue(matched, "before") + number + GetValue(matched, "after");
            } else
            {
                int[] indexes = { seriesChars.IndexOf(series[0]), seriesChars.IndexOf(series[1]), seriesChars.IndexOf(series[2]) };
                if (indexes[0] < length)
                    result = series[0] + "000" + series[1] + seriesChars[indexes[2]+1];
                else if (indexes[1] < length)
                    result = series[0] + "000" + seriesChars[indexes[1] + 1] + seriesChars[0];
                else if (indexes[0] < length)
                    result = seriesChars[indexes[0] + 1] + "000" + seriesChars[0] + seriesChars[0];
                else
                    result = seriesChars[0] + "000" + seriesChars[0] + seriesChars[0];
            }

            return result + GetValue(matched, "region");
        }

        public String GetNextMarkAfterInRange(String prevMark, String rangeStart, String rangeEnd)
        {
            return "";
        }

        public int GetCombinationsCountInRange(String mark1, String mark2)
        {
            return 0;
        }

        private String GetValue(Match matched, String key)
        {
            if (matched.Success)
                return matched.Groups[key].Value;
            return "";
        }
    }
}

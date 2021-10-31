using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace REG_MARK_LIB
{
    public class RegMark
    {
        private string seriesAlphabet = "ABCEHKMOPTYX";

        private Regex markRule = new Regex(
            @"^(?<seriesBefore>[abekmhopctyx])(?<number>[0-9]{3})(?<seriesAfter>[abekmhopctyx]{2})(?<region>[0-9]{2,3})$",
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
            string series = GetValue(matched, "seriesBefore") + GetValue(matched, "seriesAfter");
            int num = int.Parse(GetValue(matched, "number"), NumberStyles.Number);
            int length = seriesAlphabet.Length;
            string result = "";

            if (num < 999)
            {
                ++num;
                result = GetValue(matched, "seriesBefore") + num.ToString() + GetValue(matched, "seriesAfter");
            } else
            {
                int[] indexes = { seriesAlphabet.IndexOf(series[0]), seriesAlphabet.IndexOf(series[1]), seriesAlphabet.IndexOf(series[2]) };
                if (indexes[0] < length)
                    result = series[0] + num.ToString() + series[1] + seriesAlphabet[indexes[2]+1];
                else if (indexes[1] < length)
                    result = series[0] + num.ToString() + seriesAlphabet[indexes[1] + 1] + seriesAlphabet[0];
                else if (indexes[0] < length)
                    result = seriesAlphabet[indexes[0] + 1] + num.ToString() + seriesAlphabet[0] + seriesAlphabet[0];
                else
                    result = seriesAlphabet[0] + num.ToString() + seriesAlphabet[0] + seriesAlphabet[0];
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

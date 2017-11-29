using System;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            int length = 0;
            string biggest = null;
            string pattern = @"\w+[\s\.,:!\?]?";
            foreach (Match match in Regex.Matches(text, pattern))
                if (match.Length > length)
                {
                    length = match.Length;
                    biggest = match.Value.Trim();
                }
            return biggest;
        }
    }
}

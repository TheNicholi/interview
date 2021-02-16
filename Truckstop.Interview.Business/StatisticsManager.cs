using System.Collections.Generic;
using System.Linq;

namespace Truckstop.Interview.Business
{
    public class StatisticsManager : IStatisticsManager
    {
        /// <summary>
        /// Returns the longest word in a list. If multiple words are the longest, the first occurance in the list is returned.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public string GetLongestWord(List<string> words)
        {
            return words.OrderByDescending(w => w.Length).First();
        }
    }
}

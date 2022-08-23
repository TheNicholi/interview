using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        /// <summary>
        /// Retrieves a statistic vocab word using its ID.
        /// </summary>
        /// <param name="id">ID of the vocab word</param>
        /// <returns></returns>
        public async Task<string> GetVocabWordByIdAsync(int id)
        {
            return RealFakeDatabaseContext.VocabWords[id];
        }
    }
}

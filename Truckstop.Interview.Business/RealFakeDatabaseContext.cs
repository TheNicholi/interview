using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Truckstop.Interview.Business
{
    public static class RealFakeDatabaseContext
    {
        public static readonly ReadOnlyDictionary<int, string> VocabWords = new ReadOnlyDictionary<int, string>(new Dictionary<int, string> {
            { 1, "Antecedent" },
            { 2, "Average" },
            { 3, "Bias" },
            { 4, "Bimodal" },
            { 5, "Complement" },
            { 6, "Compound" },
            { 7, "Event" },
            { 8, "Factorial" },
            { 9, "Frequency" },
            { 10, "Graph" },
            { 11, "Intersection" },
            { 12, "Limit" },
            { 13, "Margin" },
            { 14, "Median" },
            { 15, "Mode" }
        });
    }
}

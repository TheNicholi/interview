using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Truckstop.Interview.Business;

namespace Truckstop.Interview.Service.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("statistics/v{version:apiVersion}")]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsManager _statisticsManager;

        public StatisticsController(IStatisticsManager statisticsManager)
        {
            _statisticsManager = statisticsManager;
        }

        [Route("longestword")]
        public string GetLongestWord(List<string> words)
        {
            return _statisticsManager.GetLongestWord(words);
        }
    }
}

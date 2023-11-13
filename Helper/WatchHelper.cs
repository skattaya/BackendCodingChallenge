using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodingChallenge
{
    public static class WatchHelper
    {
        public static Dictionary<string, int> CalculateWatchCount(string[] watches)
        {
            var watchDict = new Dictionary<string, int>();

            foreach (string watch in watches)
            {
                if (watchDict.ContainsKey(watch))
                {
                    watchDict[watch]++;
                }
                else
                {
                    watchDict.Add(watch, 1);
                }
            }

            return watchDict;
        }
    }
}

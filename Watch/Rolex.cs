using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodingChallenge
{
    public class Rolex : BaseWatch
    {
        private readonly Dictionary<string, int> watchDict;

        public Rolex(Dictionary<string, int> dict)
        {
            watchDict = dict;
            /* hard coding is not recommended : need to be moved to a setting file*/
            unitPrice = 100;
            discountTuple = new Tuple<int, long>(3, 200);
        }

        public long GetValueAfterDiscount()
        {
            
            return GetValueAfterDiscount(watchDict, "001");
        }

    }
}

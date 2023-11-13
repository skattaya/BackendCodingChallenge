using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodingChallenge
{
    public class Casio : BaseWatch
    {
        private readonly Dictionary<string, int> watchDict;

        public Casio(Dictionary<string, int> dict)
        {
            watchDict = dict;
            /* hard coding is not recommended : need to be moved to a setting file*/
            unitPrice = 30;
        }

        public long GetValueAfterDiscount()
        {
            return GetValueAfterDiscount(watchDict, "004");
        }
    }
}

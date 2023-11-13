using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodingChallenge
{
    public class MichaelKors : BaseWatch
    {
        private readonly Dictionary<string, int> watchDict;

        public MichaelKors(Dictionary<string, int> dict)
        {
            watchDict = dict;
            /* hard coding is not recommended : need to be moved to a setting file*/
            unitPrice = 80;
            discountTuple = new Tuple<int, long>(2, 120);
        }

        public long GetValueAfterDiscount()
        {
            return GetValueAfterDiscount(watchDict, "002");
        }

    }
}

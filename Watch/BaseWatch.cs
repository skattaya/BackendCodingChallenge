using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendCodingChallenge
{
    public abstract class BaseWatch
    {
        /* Unit price of the watch*/
        protected long unitPrice { get; set; }

        /*
         * Tuple for holding discount value 
         * example : 200 discount for 3 units = (3, 200)
         */
        protected Tuple<int, long> discountTuple = new Tuple<int, long>(0, 0);

        protected long GetValueAfterDiscount(Dictionary<string, int> watchDict, string watchIdentifier)
        {
            int numberOfUnits = 0;
            try
            {
                // To make sure, the return is 0 if the key doesn't exist in the dictionary
                numberOfUnits = watchDict[watchIdentifier];
            }
            catch
            {
                return 0;
            }

            /*
            rolex watch unit price :  100
            units brought 6
            discount per 3 : 200

            Tuple (3, 200)

            output : total price - (number of groups * group discount

            a. 6 rolex watches are brought

            6 % 3 * 100 + (6/3) * 200 = 0 + 400 = 400

            b. 5 rolex watches are brought

            5 % 3 * 100 + (5/3) * 200 = 200 + 200 = 400

            c. 1 rolex watch is brought

            1 % 3 * 100 + (1/3) * 200 = 100 + 0 = 100

            d. 1 casio watch is brought

            1 * 30 = 30 ---- since there's no discount
              
             */

            if(discountTuple.Item1 > 0) // discount exists
            {
                return ((numberOfUnits % discountTuple.Item1) * unitPrice) + ((numberOfUnits / discountTuple.Item1) * discountTuple.Item2);
            }
            else
            {
                return numberOfUnits * unitPrice;
            }

            
        }
    }
}

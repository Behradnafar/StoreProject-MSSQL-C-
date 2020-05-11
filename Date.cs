using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Date
    {
        public static string DateandTime()
        {
            DateTime Time = DateTime.Now;

            // Day of the week,Month 2,Year
            // Saturday,October 17,2019
            return Time.ToShortDateString();

            /*Other Format to show :
            .ToLongTimeString()    Pm 4:14:18
            .ToshortdateString()   10 / 2 / 2019
            .ToshortTimeString()   pm 4:14
            Refrecnce : http://www.w3-farsi.com/%DA%A9%D9%84%D8%A7%D8%B3-datetime/
            */
        }
    }
}

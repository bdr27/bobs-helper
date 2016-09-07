using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobsHelper
{
    public static class BNull
    {
        public static bool AreNull(params object[] nullValues)
        {
            //throw new NotImplementedException();
            var valid = true;
            foreach(var nullValue in nullValues)
            {
                if(nullValue != null)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}

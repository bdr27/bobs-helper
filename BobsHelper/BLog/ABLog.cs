using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BobsHelper.BLog
{
    public abstract class ABLog
    {
        //Potentially need some sort of formatting
        protected string GetPrepartedLine(string value)
        {
            value = string.Format("{0} - {1}", DateTime.Now.ToString("yyyy-MM-dd hh:mm"), value);
            return value;
        }

        public abstract void WriteLine(string value);
    }
}

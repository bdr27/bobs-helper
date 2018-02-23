using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace BobsHelper.BLog
{
    public class BDebugLog : ABLog
    {
        public override void WriteLine(string value)
        {
            Debug.WriteLine(GetPrepartedLine(value));
        }
    }
}

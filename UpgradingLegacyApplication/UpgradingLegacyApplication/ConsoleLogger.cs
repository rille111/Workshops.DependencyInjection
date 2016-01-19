using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpgradingLegacyApplication.Api
{
    public class ConsoleLogger
    {
        public void Log(string input)
        {
            System.Diagnostics.Debug.WriteLine(input);
        }
    }
}
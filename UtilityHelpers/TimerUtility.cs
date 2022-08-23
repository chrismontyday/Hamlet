using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UtilityHelpers
{
    public static class TimerUtility
    {
        public static void WaitFor(int timeoutInSeconds)
        {
            try
            {
                Thread.Sleep(timeoutInSeconds*1000);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GeniyIdiot.Common
{
    public static class GameTimer
    {
        public static int secondsRemaining = 11;

        public static void StartTimer(Object x)
        {
            secondsRemaining--;
            if (secondsRemaining == -1) ResetSecondsRemaining();
        }

        public static void ResetSecondsRemaining()
        {
            secondsRemaining = 10;
        }
        public static int ReturnSecondsRemaining()
        {
            return secondsRemaining;
        }

    }
}

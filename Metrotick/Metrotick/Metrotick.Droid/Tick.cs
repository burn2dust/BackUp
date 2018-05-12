using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media; // For the sound
using System.Timers;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Metrotick.Droid
{
    class Tick
    {
        SystemSound ding = new SystemSound();
        Timer watch = new Timer();

        public void playDing() {
            ding.Play("Windows Ding.wav");
        }

        //initialization of the tick.
        public async Task<Timer> Tick()
        {
            watch.Start;

            fourFourTime = 16;
            watch.Interval = fourFourTime;
            var time = watch.Interval;
            var hadDinged = false;

            await WaitAsync(hadDinged);
        }

        public async bool WaitAsync(bool clockToken)
        {
            bool waiting = clockToken as bool;
            if (waiting)
            {
                return true;
            }
            throw new Exception("Something went very wrong in Wait Async");
        }
    }
}
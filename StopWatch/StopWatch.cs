using System;

namespace StopWatch
{
    public class StopWatch
    {
        //This is at test change
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _totalDuration;
        private bool _watchStarted;
        private bool _watchOn = true;

        public bool IsStopWatchOn()
        {
            return _watchOn;
        }

        public void StartTheWatch()
        {
            if (!_watchStarted)
            {
                _watchStarted = true;
                _startTime = DateTime.Now;
                Console.WriteLine("Watch started!");
            }
            else
            {
                Console.WriteLine("The watch is already started!");
            }
        }

        public void StopTheWatch()
        {
            if (_watchStarted)
            {
                _watchStarted = false;
                _endTime = DateTime.Now;
                var duration = _endTime - _startTime;
                _totalDuration += duration;
                Console.WriteLine($"Time Elapsed: {_totalDuration}");
            }
            else
            {
                Console.WriteLine("The watch is already stopped!");
            }
        }

        public void ClearTheWatch()
        {
            if (!_watchStarted) 
            {
                _totalDuration = TimeSpan.Zero;
                Console.WriteLine("Stopwatch cleared!");
            }
            else
            {
                Console.WriteLine("Watch must be stopped to clear!");
            }
        }

        public void End()
        {
            _watchOn = false;
        }
    }
}
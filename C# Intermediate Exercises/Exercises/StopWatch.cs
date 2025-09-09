using System;

namespace C__Intermediate_Exercises.Exercises
{
    internal class StopWatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }
        private bool _isRunning = false;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("The StopWatch is already Started!");
            }
            _isRunning = true;
            StartTime = DateTime.Now;
        }
        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("The StopWatch is not Started yet!");
            }
            _isRunning = false;
            StopTime = DateTime.Now;
        }
        public TimeSpan Duration
        {
            get
            {
                if (_isRunning)
                {
                    throw new Exception("The StopWatch is still running!");
                }
                return StopTime - StartTime;
            }
        }
    }
}

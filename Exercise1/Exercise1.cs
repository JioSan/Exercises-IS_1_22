using System;

namespace Exercise1
{
    class Engine
    {
        private const int STATE_STOPPED = 1;
        private const int STATE_STARTED = 2;
        public int engineState;

        public void Start()
        {
            Console.Out.WriteLine("Start");
            engineState = STATE_STARTED;
        }

        public void Stop()
        {
            Console.Out.WriteLine("Stop");
            engineState = STATE_STOPPED;
        }

        public string GetState()
        {
            string state;

            if (engineState == STATE_STOPPED)
                state = "Stopped";
            else if (engineState == STATE_STARTED)
                state = "Started";
            else
                state = "Error";

            return state;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LogicalProgramming
{
    class StopWatch
    {
        public void ElapsedTime()
        {
            Console.WriteLine("\nInstructions For StopWatch Simulation...\n\n-->Press ' Spacebar ' To Start");
            Console.WriteLine("-->Press ' Spacebar ' At Anytime To Stop");
            Console.ReadKey();   //It Reads any Key as input. So I Takes This To Read " START " & " STOP " Inputs For StopWatch
            Console.WriteLine("\nStopWatch Started...");
            Stopwatch stopwatch = new Stopwatch();   //I Take StopWatch Class From " System.Diagnostics "
            stopwatch.Start();                       //This Start() Starts the StopWatch
            while (!Console.KeyAvailable)            //It Checks For Key is Available or Not. returns boolean true/false
            {
                Thread.Sleep(1);                     //It Suspends Thread for 1 millisecond in Unlimited While Loop
            }
            stopwatch.Stop();                        //This Stop() Stops the StopWatch
            Console.WriteLine("\nStopWatch Stoped !");
            TimeSpan timeSpan = stopwatch.Elapsed;   //In This Statement, Elapsed Time is saved in timeSpan  
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds / 10);
            Console.WriteLine("\nThe Elapsed time is: " + elapsedTime);
        }
    }
}

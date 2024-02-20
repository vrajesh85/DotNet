using System;
using System.Threading;

namespace DotNetConsole.Multithreading
{
    internal class ThreadingClass
    {
        public void FirstThread()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("The value of first is " + i.ToString());
            }
        }

        public void SecondThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("The value of second is " + i.ToString());
            }
        }
    }
}

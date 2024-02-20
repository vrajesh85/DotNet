using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetConsole.Inheritance
{
    public class CricketerClass
    {
        public string State { get; set; }
        public CricketerClass() {
            Console.WriteLine("This is a base class cricketer");
        }
    }
}

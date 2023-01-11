using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.Threading;

namespace ConsoleApp3
{
    internal class Student
    {
        private static int _counter = 100;

        public Student()
        {
            _counter++;
            No = _counter;
        }

        public int No;
        public string FullName;
        public string GroupNo;

    }
}

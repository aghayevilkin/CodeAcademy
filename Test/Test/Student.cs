using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Student
    {

       private static int _TotalNo { get; set; }
        public static int TotalNo { get => _TotalNo; }

        private int _no { get; set; }
        public int No { get => _no; }


     
        public string name;
        public string surname;

        public Student(string name, string surname)
        {
            _TotalNo++;
            _no = _TotalNo;
            this.name = name;
            this.surname = surname;

        }
    }
}

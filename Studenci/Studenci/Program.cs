using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenci
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Student
    {
        public string imie;
        public int ZIOP, SO, Grafika, MySql;

        public Student(string imie, int ziop, int so, int graf, int mysql)
        {
            this.imie = imie;
            ZIOP = ziop;
            SO = so;
            Grafika = graf;
            MySql = mysql;
        }
    }
}

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
            Student[] studenci = new Student[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj nazwisko " + (i + 1) + " studenta: ");
                studenci[i].Nazwisko = Console.ReadLine();
                Console.Write(Environment.NewLine);
                Console.Write("Podaj ocenę z ZIOP: ");
                studenci[i].ZIOP = Int32.Parse(Console.ReadLine());
                Console.Write(Environment.NewLine);
                Console.Write("Podaj ocenę z SO: ");
                studenci[i].SO = Int32.Parse(Console.ReadLine());
                Console.Write(Environment.NewLine);
                Console.Write("Podaj ocenę z Grafika: ");
                studenci[i].Grafika = Int32.Parse(Console.ReadLine());
                Console.Write(Environment.NewLine);
                Console.Write("Podaj ocenę z Sql: ");
                studenci[i].Sql = Int32.Parse(Console.ReadLine());
                Console.Write(Environment.NewLine);
            }
        }
    }
}

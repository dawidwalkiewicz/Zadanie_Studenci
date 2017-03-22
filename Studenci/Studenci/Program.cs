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
                studenci[i] = new Student();
                studenci[i].Nazwisko = Console.ReadLine();
                Console.Write("Podaj ocenę z ZIOP: ");
                studenci[i].Oceny[0].ocena = Int32.Parse(Console.ReadLine());
                Console.Write("Podaj ocenę z SO: ");
                studenci[i].Oceny[1].ocena = Int32.Parse(Console.ReadLine());
                Console.Write("Podaj ocenę z Grafika: ");
                studenci[i].Oceny[2].ocena = Int32.Parse(Console.ReadLine());
                Console.Write("Podaj ocenę z Sql: ");
                studenci[i].Oceny[3].ocena = Int32.Parse(Console.ReadLine());
                Console.Write(Environment.NewLine);
            }

            Console.WriteLine("Odczytywanie ocen:");

            while (true)
            {
                Console.Write("Podaj indeks ucznia [1-5]: ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 0)
                    break;

                Student b = studenci[a - 1];

                Console.Write("Podaj indeks przedmiotu [1-4]: ");
                a = Convert.ToInt32(Console.ReadLine());
                Ocena c = b.Oceny[a-1];

                Console.WriteLine("Dla ucznia " + b.Nazwisko + " ocena z przedmiotu " + c.nazwa + " to " + c.ocena);
            }
        }
    }

    class Student
    {
        public string Nazwisko;
        public Ocena[] Oceny = new Ocena[4];

        public Student()
        {
            Oceny[0] = new Ocena("ZIOP");
            Oceny[1] = new Ocena("SO");
            Oceny[2] = new Ocena("Grafika");
            Oceny[3] = new Ocena("MySql");
        }
    }

    class Ocena
    {
        public string nazwa;
        public int ocena;

        public Ocena(string nazwa)
        {
            this.nazwa = nazwa;
            ocena = 0;
        }
    }
}

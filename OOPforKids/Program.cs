using System;

namespace OOPforKids
{
    class Program
    {
        static void Main(string[] args)
        {
            Opilane o = new Opilane("Kati", "Kask", "TARpv21", 15, "");
            o.Hinne = 4;
            o.Tervist();
            Person naine = new Person();
            naine.Palk = 100;
            naine.Name = "Kask";











            /*
            Person[] inimesed = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new Person();
                Console.WriteLine("What's your name?");
                inimesed[i].Name = Console.ReadLine();
                Console.WriteLine("Lastname: ");
                inimesed[i].Eesnimi = Console.ReadLine();
                Console.WriteLine("Age: ");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
                Console.WriteLine("What's your salary?");
                inimesed[i].Height = int.Parse(Console.ReadLine());
                Console.WriteLine("What's your salary?");
                inimesed[i].Salary = int.Parse(Console.ReadLine());
            }
            foreach (Person inimene in inimesed)
            {
                inimene.Tervitame();
                inimene.Bye();
            }
            */

           

            Console.ReadLine();
        }
    }
}

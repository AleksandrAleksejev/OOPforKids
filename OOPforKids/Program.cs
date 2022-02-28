using System;

namespace OOPforKids
{
    class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("What's your height?");
                inimesed[i].Height = int.Parse(Console.ReadLine());
                Console.WriteLine("What's your salary?");
                inimesed[i].Salary = int.Parse(Console.ReadLine());
            }
            foreach (Person inimene in inimesed)
            {
                inimene.Tervitame();
                inimene.Bye();
            }


            Person mees = new Person();
            mees.Eesnimi = "Topolja";
            mees.Vanus = 44;
            mees.Name = "Timophei";
            mees.Height = 180;
            mees.Salary = 1600;
            Console.WriteLine($"{mees.Eesnimi} is {mees.Vanus},{mees.Height},{mees.Salary}");
            mees.Tervitame();
            Person naine = new Person("Marina",Emakeel.saksa);
            naine.Tervitame();



            Console.ReadLine();
        }
    }
}

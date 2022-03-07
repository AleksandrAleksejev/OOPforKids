using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPforKids
{
    public class Person
    {
        string eesnimi;//поля
        int vanus;
        int salary;// поля2
        string name;
        int height;
        string status;
        int palk;
        Sugu sugu;
        Emakeel emakeel;
        public Person() { }//конструктор
        public Person(string Eesnimi,string Name)
        {
            eesnimi = Eesnimi;
            name = Name;
        }
        public Emakeel Emakeel
        {
            get { return emakeel; }
        }
        public Sugu Sugu
        {
            get { return sugu; }
        }
        public string Eesnimi
        {
            set { if (eesnimi == null) eesnimi = value; }
            get { return eesnimi; }
        }
        //св-во
        public int Palk
        {
            set { palk = value; }
            get { return palk; }
        }
        public int Vanus
        {
            set
            { vanus = value;}
            get { return vanus; }
        }
        public string Status
        {
            get {
                var status = "";
                if (vanus < 7)
                {
                    status = "vaike laps";
                }
                else if (vanus < 17)
                {
                    status = "kooli laps";
                }
                else if (vanus < 65)
                {
                    status = "tooline inimene";
                }
                else
                {
                    status = "senior";
                }
                return status; }
        }
        public void Tervitame()//метод
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("Minu nimi on {0}; Olen {1} aastat vana.Minu status on {2}", Eesnimi, Vanus, Status);
        }
        public string Name
        {
            set { if (name == null) name = value; }
            get { return name; }
        }
        public int Height
        {
            set
            {
                height = value;
                if (height < 140)
                {
                    status = "Short";
                }
                else if (height < 180)
                {
                    status = "Normal";
                }
                else
                {
                    status = "Very tall";
                }
            }
            get { return height; }
        }// св-во
        public int Salary
        {
            set
            {
                salary = value;
                if (salary < 600)
                {
                    status = "Minnimum salary";
                }
                else if (salary < 1200)
                {
                    status = "Medium salary";
                }
                else
                {
                    status = "High salary ";
                }
            }
            get { return salary; }
        }

        public void Bye()
        {
            Console.WriteLine("My name is " + name);
            Console.WriteLine($"I'm {height} cm and my salary {salary}");
            Console.WriteLine($"My gender is {sugu}");
            Console.WriteLine("Good Bye");
        }// метод 2 
        public double Tulumaks()
        {
            double tulu = 0;
            tulu = palk * 0.2;
            return tulu;
        }

    }
}

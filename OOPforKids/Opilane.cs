using System;
using System.Collections.Generic;
using System.Text;

namespace OOPforKids
{
    public class Opilane:Person
    {
        string ruhm;
        double hinne;
        bool toetus;

        public Opilane() { }

        public Opilane(string Eesnimi,string Name,string Ruhm) : base(Eesnimi, Name)
        {
            ruhm = Ruhm;

        }
        public string Ruhm
        {
            get { return ruhm; }
            set { ruhm = value;}
        }
        public double Hinne
        {
            set
            { if(value>1 && value<5) hinne = value; }
            get { return hinne; }
        }
        public bool Toetus
        {
            get
            {
                if (hinne > 3)
                {
                    toetus = true;
                }
                else
                {
                    toetus = false;
                }
                return toetus;
            }
        }
        public void Tervist()
        {
            string t = "";
            Console.WriteLine("Tere! Minu nimi on {0}{1}", Eesnimi, Name);
            if (Toetus == true)
            {
                t = "Saan toetust kitte:))";
            }
            else if (Toetus == false && hinne>4)
            {
                t = "Ei saa toetust :((";
            }
            else
            {
                t = "Andmed hinnedest puuduvad";
            }
            Console.WriteLine("Minu keskmine hinne on {0}. olen {1}", hinne, t );
            
        }
    }
}

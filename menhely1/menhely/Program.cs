using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menhely
{
    class Allat
    {
        private string nev;
        private int szuletesiEv;

        private int szepsegPont, viselkedesPont;
        private int pontSzam;

        private static int aktualisEv;
        private static int korHatar;

        public Allat(string nev, int szuletesiEv)
        {
            this.nev = nev;
            this.szuletesiEv = szuletesiEv;
        }

        public int Kor()
        {
            return aktualisEv - szuletesiEv;
        }

        public void Pontozzak(int szepsegPont, int viselkedesPont)
        {
            this.szepsegPont = szepsegPont;
            this.viselkedesPont = viselkedesPont;
            if (Kor() <= korHatar)
            {
                pontSzam = viselkedesPont * Kor() + szepsegPont * (korHatar - Kor());
            }
            else
            {
                pontSzam = 0;
            }
        }

        public override string ToString()
        {
            return nev + " pontszama: " + pontSzam + " pont";
        }

        public string Nev
        {
            get { return nev; }
        }

        public int SzuletesiEv
        {
            get { return szuletesiEv; }
        }

        public int SzepsegPont
        {
            get { return szepsegPont; }
        }

        public int ViselkedesPont
        {
            get { return viselkedesPont; }
        }

        public int PontSzam
        {
            get { return pontSzam; }
        }

        public static int AktualisEv
        {
            get { return aktualisEv; }
            set { aktualisEv = value; }
        }

        public static int KorHatar
        {
            get { return korHatar; }
            set { korHatar = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Allat allat;

            int aktEv = 2015, korhatar = 10;

            string nev;
            int szulEv;
            int szepseg, viselkedes;

            Allat.AktualisEv = aktEv;
            Allat.KorHatar = korhatar;

            nev = "Vakarcs";
            szulEv = 2010;
            szepseg = 5;
            viselkedes = 3;

            allat = new Allat(nev, szulEv);

            allat.Pontozzak(szepseg, viselkedes);

            Console.WriteLine(allat);

            Console.ReadKey();
        }
    }
}

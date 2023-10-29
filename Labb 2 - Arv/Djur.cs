using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    public class Djur
    {
        public string Namn { get; set; }
        public int Ålder { get; set; }
        public string Färg { get; set; }
        public string ÖgonFärg { get; set; }
        public double Vikt { get; set; }
        public string Art { get; set; }
        public string Egenskap { get; set; }

        public Djur(string namn, int ålder, string färg, double vikt, string art, string egenskap)
        {
            Namn = namn;
            Ålder = ålder;
            Färg = färg;
            Vikt = vikt;
            Art = art;
            Egenskap = egenskap;
        }
        public void Sträcka()
        {
            Console.WriteLine($"{Namn} Sträcker på sig långsamt");
        }
        public void Äta()
        {

            Console.WriteLine($"{Namn} äter.");
        }

        public void Sova()
        {
            Console.WriteLine($"{Namn} sover.");

        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Namn} gör lite ljud av sig");
        }

        public void kissa()
        {
            Console.WriteLine($"{Namn} som är en {Art} behöver kissa");
        }

        public virtual void klia()
        {
            Console.WriteLine($"{Namn} kliar sig med foten");
        }

        public void gäspa()
        {
            Console.WriteLine($"{Namn} gäspar högt");
        }


        public void Svans()
        {
            Console.WriteLine($"{Namn} viftar på svansen");
        }


    }

  

    class Tax : Djur
    {
        public string Egenskap { get; set; }
        public int AntalBen { get; set; }

        public Tax(string namn, int ålder, string färg, double vikt, string ras, string egenskap, int antalBen)
        : base(namn, ålder, färg, vikt, "Hund", egenskap)
        {
            Egenskap = egenskap;
            AntalBen = 4;

        }

       

        public void Skälla()
        {
            Console.WriteLine($"{Namn} skäller högt!");
        }


    }
    class Franskbulldog : Djur
    {
        public string Egenskap { get; set; }
        public bool KanSima { get; set; }

        public Franskbulldog(string namn, int ålder, string färg, double vikt, string ras,string egenskap, bool kanSima)
        : base(namn, ålder, färg, vikt, "Hund", egenskap)
        {
            Egenskap = egenskap;
            KanSima = true;

        }


        public void Snarka()
        {
            Console.WriteLine($"{Namn} snarkar sött.");
        }



    }
    
    class Chihuahua : Djur
    {

        public string Egenskap { get; set; }
        public string FavoritLeksak { get; set; }
        public Chihuahua(string namn, int ålder, string färg, double vikt, string ras, string egenskap, string favoritleksak)
       : base(namn, ålder, färg, vikt, "Hund", egenskap)
        {

            Egenskap = egenskap;
            FavoritLeksak = FavoritLeksak;

        }

        public void Skutta()
        {
            Console.WriteLine($"{Namn} skuttar glatt runt.");
        }


    }


    class StorTax : Tax
    {
        public string Egenskap { get; set; }
        public double Snabb {  get; set; }

        public StorTax(string namn, int ålder, string färg, double vikt, string ras, string egenskap, int antalBen, double snabb)
          : base(namn, ålder, färg, vikt, ras, egenskap, antalBen)
        {
            Egenskap = egenskap;
            Snabb = snabb;
        }

        public void JagaByten()
        {
            Console.WriteLine($"{Namn} jagar byten med stor entusiasm.");
        }
    }


    class LitenTax : Tax
    {
        public string Egenskap { get; set; }
        public int Djup {  get; set; }

        public LitenTax(string namn, int ålder, string färg, double vikt, string ras, string egenskap, int antalBen, int djup)
          : base(namn, ålder, färg, vikt, ras, egenskap, antalBen)
        {
            Egenskap = egenskap;
            Djup = djup;
        }

        public void Grävahål()
        {
            Console.WriteLine($"{Namn} Gräver ett hål med sina små tassar");
        }


    }


}

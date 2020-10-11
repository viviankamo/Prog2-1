using System;

namespace oop.labb
{
    class Program
    {
        static void Main(string[] args)
        {
            var kund = new Kund();
            var produkt = new Produkt();
            produkt.produktTyp = "gris";
            kund.kundkorg.Add(produkt);

            foreach(var prod in kund.kundkorg){
                Console.WriteLine(prod.produktTyp);
            }
        }
    }
}

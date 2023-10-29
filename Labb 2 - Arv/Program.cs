using Microsoft.Win32.SafeHandles;

namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tax tax = new Tax("Ubbe", 3, "Svart", 5.6, "Dvärg-Tax", "kan se ut som en lakrits", 4);
            Franskbulldog Fransk = new Franskbulldog("Berit", 7, "beige", 11, "Franskbulldog", "kan simma baklänges", false);
            Chihuahua Chi = new Chihuahua("Einar", 5, "Vit", 3, "Chihuahua", "gillar att sola", "bollar");
            StorTax Nippe = new StorTax("Nippe", 11, "Brun", 6.1, "Strävhårig Tax", "Gillar att rymma", 4, 20.0);
            LitenTax Helge = new LitenTax("Helge", 9, "Grå", 5.9, "Dvärg Tax", "Korta ben", 4, 2);


            Console.WriteLine($"{tax.Namn} är en {tax.Art}, hans päls är {tax.Färg}, han är också {tax.Ålder} gammal och väger {tax.Vikt} kg, {tax.Egenskap}");
            tax.MakeSound();
            tax.Sträcka();
            tax.Skälla();
            
            Console.WriteLine(" ");


            Console.WriteLine($"{Fransk.Namn} är en {Fransk.Art}, hennes päls är {Fransk.Färg}, hon är också {Fransk.Ålder} gammal och väger {Fransk.Vikt} kg, {Fransk.Egenskap}");
            Fransk.MakeSound();
            Fransk.Snarka();
            
            Console.WriteLine(" ");


            Console.WriteLine($"{Chi.Namn} är en {Chi.Art}, hans päls är {Chi.Färg}, han är också {Chi.Ålder} gammal och väger {Chi.Vikt} kg och kan {Chi.Egenskap}");
            Chi.MakeSound();
            Chi.Äta();
            Chi.Skutta();
            
            Console.WriteLine(" ");


            Console.WriteLine($"{Nippe.Namn} är en {Nippe.Art}, hans päls är {Nippe.Färg}, han är också {Nippe.Ålder} gammal och väger {Nippe.Vikt} kg och kan {Nippe.Egenskap}");
            Nippe.MakeSound();
            Nippe.JagaByten();

            Console.WriteLine(" ");

           
            Console.WriteLine($"{Helge.Namn} är en {Helge.Art}, hans päls är {Helge.Färg}, han är också {Helge.Ålder} gammal och väger {Helge.Vikt} kg och kan {Helge.Egenskap}");
            Helge.MakeSound();
            Helge.Grävahål();
            
            Console.WriteLine(" ");
            
        }
    }
}
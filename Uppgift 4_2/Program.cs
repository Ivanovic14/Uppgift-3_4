using System;
namespace Uppgift_3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Om din låt är exempelvis 3 minuter och 20 sekunder lång, så ska du skriva den som 320. Varsågod.");
            string låt = Console.ReadLine();
            int längd = int.Parse(låt);

            switch (längd)
            {
                case 1:
                    if (längd >= 245 && längd <= 420)
                    {
                        Console.WriteLine("Okej, din låt passar bra.");
                    }
                    break;
                        case 2:
                    if (längd < 245 && längd > 420)
                    {
                        Console.WriteLine("Din låt passar ej bra");
                    }
                    break;
            }
            
            

        }
    }
}
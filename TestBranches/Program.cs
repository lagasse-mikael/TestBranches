using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBranches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour!");

            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("Veuillez entrer un chiffre");
            try
            {
                int nombre = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Votre chiffre est {0}", nombre);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ouai non.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir votre nom, prénom et année de naissance : ");
            string nom = Console.ReadLine();
            string prenom = Console.ReadLine();
            int annee = int.Parse(Console.ReadLine());
            DateTime date = DateTime.Now;
            Console.WriteLine("Fiches de renseignement :");
            Console.WriteLine("\t - Nom : " + nom);
            Console.WriteLine("\t - Prénom : " + prenom);
            Console.WriteLine("\t - Age : " + (int.Parse(date.ToString("yyyy")) - annee));
        }
    }
}

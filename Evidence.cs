using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce2
{
    internal class Evidence
    {
        private Databaze databaze;
       


        public Evidence()
        {
            databaze = new Databaze();
        }


        public void PridejPojisteneho()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno = Console.ReadLine();

            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();

            Console.WriteLine("Zadejte telefonní číslo: ");
            int vek = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte věk: ");
            int telefon = int.Parse(Console.ReadLine());
            
            databaze.PridejPojistence(jmeno, prijmeni, vek, telefon);
            Console.WriteLine();
            Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou....");
            Console.WriteLine();

        }

        public void VypisPojistenych()
        {

            List<Pojistenec> seznamPojistenych = databaze.getPojistenci();
            if (seznamPojistenych.Count() > 0)
            {
                Console.WriteLine("Seznam všech pojištěných klientů: ");
                foreach (Pojistenec i in seznamPojistenych)
                    Console.WriteLine(i);
            }
            else
                Console.WriteLine("Žádní tu nejsou..");
        }

        public void VyhledejPojisteneho()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Chybné zadání, zadejte znovu: ");
            }

            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Chybné zadání, zadejte znovu: ");
            }

            Pojistenec nalezenyPojistenec = databaze.VyhledejPojistence(jmeno, prijmeni);
            Console.WriteLine("Nalezený pojištěnec:");
            Console.WriteLine(nalezenyPojistenec);                                 
        }       
    }
}

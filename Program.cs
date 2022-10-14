namespace Projekt_ke_zkoušce2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evidence evidence = new Evidence();

            char volba = '0';
            while (volba != '4')
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Evidence pojištěných");
                Console.WriteLine("-------------------------");
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (volba)
                {
                    case '1':
                        evidence.PridejPojisteneho();
                        break;
                    case '2':
                        evidence.VypisPojistenych();
                        break;
                    case '3':
                        evidence.VyhledejPojisteneho();
                        break;
                    case '4':
                        Console.WriteLine("Libovolnou klávesou ukončíte program.");
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a opakujte volbu.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}

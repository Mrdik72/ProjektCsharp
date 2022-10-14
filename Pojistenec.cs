using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce2
{
    internal class Pojistenec
    {
        private string Jmeno { get; set; }
        private string Prijmeni { get; set; }
        private int Vek { get; set; }
        private int Telefon { get; set; }
      

        public Pojistenec(string jmeno, string prijmeni, int vek, int telefon)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Telefon = telefon;
        }

        public string getJmeno()
        {
            return Jmeno;
        }

        public string getPrijmeni()
        {
            return Prijmeni;
        }

        
    public override string ToString()
        {

            return string.Format("\nJméno: {0} \nPříjmení: {1} \nVěk: {2} \nTelefonní číslo: {3} ", Jmeno, Prijmeni, Vek, Telefon);
        }
    }
}

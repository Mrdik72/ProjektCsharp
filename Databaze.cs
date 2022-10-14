using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_ke_zkoušce2
{
    internal class Databaze
    {
        private List<Pojistenec> pojistenci;

        public Databaze()
        {
            pojistenci = new List<Pojistenec>();
        }

        public void PridejPojistence(string jmeno, string prijmeni, int vek, int telefon)
        {
            Pojistenec pojistenec = new Pojistenec(jmeno, prijmeni, vek, telefon);
            pojistenci.Add(pojistenec);
        }

        public List<Pojistenec> getPojistenci()
        {
            return pojistenci;
        }

        public Pojistenec VyhledejPojistence(string jmeno, string prijmeni)
        {
            
            foreach (Pojistenec pojistenec in pojistenci)
            {
                if (pojistenec.getJmeno() == jmeno && pojistenec.getPrijmeni() == prijmeni)
                {               
                    return pojistenec;                       
                }
                
            }
            return null; 
        }
    }
}

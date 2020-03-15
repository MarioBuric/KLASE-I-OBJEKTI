using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricmariovjezba
{
    class Vozilo
    {
        private string vrsta; 
        private double maxBrzina;
        private int brojKotaca;
        public Vozilo()
        { }
        public void setVrsta(string vrsta)
        {
            this.vrsta = vrsta;
        }
        public string getVrsta()
        {
            return vrsta;
        }
        public void setMaxBrzina(double maxBrzina)
        {
            this.maxBrzina = maxBrzina;
        }
        public double getMaxBrzina()
        {
            return maxBrzina;
        }
        public void setBrojKotaca(int brojKotaca)
        {
            this.brojKotaca = brojKotaca;
        }
        public int getBrojKotaca()
        {
            return brojKotaca;
        }
        public override string ToString()
        {
            string poruka = "Vrsta: " + vrsta +
                "\nMaksinalna brzina: " + maxBrzina +
                "\nBroj kotača: " + brojKotaca;
            return poruka;
        }
    }
}

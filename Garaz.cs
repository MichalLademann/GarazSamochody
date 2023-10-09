using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SamochodyBasic
{
    class Garaz
    {
        private string adres;
        private int pojemnosc;
        private List<Samochod> samochody = new List<Samochod>();
        private int liczbaSamochodow = 0;

        // Konstruktor bezparametrowy
        public Garaz()
        {
            this.adres = "nieznany";
            this.pojemnosc = 0;
        }

        // Konstruktor parametrowy
        public Garaz(string adres, int pojemnosc)
        {
            this.adres = adres;
            this.pojemnosc = pojemnosc;
        }

        // Właściwość pojemności garażu
        public int Pojemnosc
        {
            get { return this.pojemnosc; }
            set { this.pojemnosc = value; }
        }

        // Właściwość adresu garażu
        public string Adres
        {
            get { return this.adres; }
            set { this.adres = value; }
        }

        // Metoda dodawania samochodu do garażu
        public void WprowadzSamochod(Samochod nowySamochod)
        {
            if (this.liczbaSamochodow >= this.pojemnosc)
            {
                this.samochody.Add(nowySamochod as Samochod);
                this.liczbaSamochodow++;
            }
            else
            {
                Console.WriteLine("Garaż jest pełny. Nie można wprowadzić samochodu.");
            }
        }

        // Metoda wyprowadzania samochodu z garażu
        public Samochod WyprowadzSamochod()
        {
            if (this.liczbaSamochodow > 0)
            {
                Samochod ostatniSamochod = samochody[liczbaSamochodow - 1];
                this.samochody.RemoveAt(this.liczbaSamochodow - 1);
                this.liczbaSamochodow--;
                return ostatniSamochod;
            }
            else
            {
                Console.WriteLine("Garaż jest pusty. Nie można wyprowadzić samochodu.");
                return null;
            }
        }

        // Metoda wypisująca informacje o garażu
        public void WypiszInfo()
        {
            Console.WriteLine($"Adres garażu: {this.adres}");
            Console.WriteLine($"Pojemnosc garażu: {this.pojemnosc}");
            Console.WriteLine($"Liczba Samochodow w garażu: {this.liczbaSamochodow}");

            Console.WriteLine("Samochody w garażu:");
            foreach (Samochod s in this.samochody)
            {
                s.WypiszInfo();
            }
            
        }
    }
}
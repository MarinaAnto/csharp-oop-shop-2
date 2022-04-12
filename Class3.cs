using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class CiboScatola : Prodotto
    {
        private double peso;
        private string cibo;
        private int scadenza;

        //----------COSTRUTTORE----------------
        public CiboScatola(string nome, string descrizione, double prezzo, int iva, double peso, string cibo,int scadenza) : base(nome, descrizione, prezzo, iva)
        {
            this.peso = peso;
            this.cibo = cibo;
            this.scadenza = scadenza;
        }
        //-----------SET---GET---------------------
        public string GetCibo()
        {
            return cibo;
        }
        public int GetScedenza() { return scadenza; }
        public void SetPeso(double nuovopeso)
        {
            if (nuovopeso > 300 || nuovopeso < 0)
            {
                return;
            }
            else
            {
                peso = nuovopeso;
            }
        }
        public void SetCibo(string nuovocibo)
        {
            cibo = nuovocibo;
        }
        //---------------METODI---------------------
        public void cibomangiati(int grammi)
        {
            if (this.peso - grammi > 0)
            {
                this.peso = this.peso - grammi;
                Console.WriteLine("Hai mangiato" + grammi + " grammi su 300 g");
            }
            else
            {
                Console.WriteLine("Hai mangiato tutto");
            }
        }
        public override void NomeEsteso()
        {
            Console.WriteLine("Il codice + nome è: " + base.codice + "-" + base.nome);
            Console.WriteLine("Peso: " + this.peso + "\nCibo: " + this.cibo + "\nScadenza: " + this.scadenza);
        }

    }
}

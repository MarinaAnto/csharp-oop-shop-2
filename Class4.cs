using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class FruttaPezzi : Prodotto
    {
        private int quantita;
        private string frutta;
        private bool marcito;

        //--------------COSTRUTTORE------------------
        public FruttaPezzi(string nome, string descrizione, double prezzo, int iva, int quantita, string frutta,bool marcito) : base(nome, descrizione, prezzo, iva)
        {
            this.frutta = frutta;
            this.quantita = quantita;
            this.marcito = marcito;
        }
        //------------SET---GET-----------------------
        public int GetQuantita()
        {
            return quantita;
        }
        public string GetFrutta() { return frutta; }
        public void SetFrutta(string nuovafrutta)
        {
            frutta = nuovafrutta;
        }

        public void SetQuantita(int nuovaquantita)
        {
            if (nuovaquantita > 5 || nuovaquantita < 0)
            {
                return;
            }
            else
            {
                quantita = nuovaquantita;
            }
        }
        //--------------METODI--------------------------------
        public void Pezzimangiati(int pezzi)
        {
            if (this.quantita - pezzi > 0)
            {
                this.quantita = this.quantita - pezzi;
                Console.WriteLine("Hai mangiato" + pezzi + " pezzi di frutta");
            }
            else
            {
                Console.WriteLine("Hai mangiato tutto");
            }
        }
        public override void NomeEsteso()
        {
            Console.WriteLine("Il codice + nome è: " + base.codice + "-" + base.nome);
            Console.WriteLine("Frutta: " + this.frutta + "\nQuantita: " + this.quantita + "\nScaduto: " + this.marcito);
        }



    }
}

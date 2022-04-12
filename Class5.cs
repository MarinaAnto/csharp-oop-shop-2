using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Elettrodomestico : Prodotto
    {
        //--------ATTRIBUTTI------------------
        private string durata;
        private bool acceso;

        //----------COSTRUTTORE--------------------
        public Elettrodomestico(string nome, string descrizione, double prezzo, int iva, string durata, bool acceso) : base(nome, descrizione, prezzo, iva)
        {
            this.durata = durata;
            this.acceso = acceso;
        }
        //----------------SET---GET------------------
        public bool GetAcceso()
        {
            return acceso;
        }
        public string Getluogo()
        {
            return durata;
        }
       

        //------------------METODI----------------------

        public void Accendi()
        {
            acceso = true;
        }
        public void Spegni()
        {
            acceso = false;
        }
        public override void NomeEsteso()
        {
            Console.WriteLine("Il codice + nome è: " + base.codice + "-" + base.nome);
            Console.WriteLine("Durata: " + this.durata + "\nAcceso: " + this.acceso);
        }




    }
} 
    



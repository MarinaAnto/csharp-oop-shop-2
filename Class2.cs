using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal class Acqua : Prodotto 
    {
        //----------------------------------ATTIBUTI----------------------------

        private double litri;
        private double ph;
        private  string sorgente;
        //-------------------------COSTRUTTORE-------------------------------------


        public Acqua(string nome,string descrizione,double litri,double ph, string sorgente,double prezzo,int iva) : base(nome, descrizione, prezzo, iva)
        {
            this.sorgente = sorgente;
            this.litri = litri;
            this.ph = ph;
        }
        //--------------------SET---GET------------------------------------
        public string Sorgente { get => sorgente; set => sorgente = value; }
        public double GetPh()
        {
            return ph;
        }
        public double GetLitri()
        {
            return litri;
        }

        //-----------------------METODI------------------------------------
        public void riempi(double nuovilitri)
        {
            if(this.litri < 1.5 || this.litri==0)
            {
                this.litri+=nuovilitri;
            }
        }
        public void svuota()
        {
            if (this.litri>0)
            {
                this.litri -=this.litri;
            }
        }


        public void bevi(double litribevuti)
        {
            if(this.litri -litribevuti > 0)
            {
                this.litri=this.litri - litribevuti;
                Console.WriteLine("Hai bevuto" + litribevuti + "litri di acqua su 1.5 l");
            }else
            {
                Console.WriteLine("Hai bevuto tutto");
            }
                    
        }

        public override void NomeEsteso()
        {
            Console.WriteLine("Il codice + nome è: " + base.codice + "-" + base.nome);
            Console.WriteLine("Sorgente: " + this.sorgente + "\nPh: " + this.ph +"\nLitri: "+this.litri);
        }

    }
}

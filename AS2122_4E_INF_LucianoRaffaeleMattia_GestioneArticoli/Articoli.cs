using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_LucianoRaffaeleMattia_GestioneArticoli
{
    internal class Articoli
    {
        public string codice;
        public string descrizione;
        public string unitadimisura;
        public double prezzo;

       
       

       

        public Articoli(string codice, string descrizione, string unitadimisura, double prezzo)
        { 
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitadimisura = unitadimisura;
            this.prezzo = prezzo;

        
        }
        public string Codice { get { return codice; } }
        public string Descrizione { get { return descrizione; } }
        public string UnitaDiMisura { get { return unitadimisura; } }
        public double Prezzo { get { return prezzo; } }
        public string Visualizzati()
        {
            return $"{Descrizione} {UnitaDiMisura} {Prezzo} ({codice})";
        }
    }
}

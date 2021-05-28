using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEsami
{
  public  class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime AnnoDiNascita { get ; set; }
        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();
        public CorsoDiLaurea CorsoDiLaurea { get; set; } = new CorsoDiLaurea();
        //public int RichiestaLaurea { get; set; }

        public Studente()
        {
                
        }
        public Studente(string nome, string cognome, DateTime annodinascita, Immatricolazione immatricolazione )
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annodinascita;
            Immatricolazione = immatricolazione;
            List<Corso> Esami = new List<Corso>();
        }


    }
}

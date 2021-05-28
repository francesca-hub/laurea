using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEsami
{
  public  class CorsoDiLaurea
    {
        public string NomeCorsoLaurea { get; set; } 
        public int AnniDiCorso { get; set; }
        public int CFUperOttenerelaurea { get; set; }
        public List<Corso> Esame { get; set; } = new List<Corso>();
  

        public CorsoDiLaurea()
        {

        }
        public CorsoDiLaurea(string nomecorsolaurea, int annidicorso, int cfutot)
        {
            NomeCorsoLaurea = nomecorsolaurea;
            AnniDiCorso = annidicorso;
            CFUperOttenerelaurea = cfutot;
            List<Corso> Esame = new List<Corso>();
        }

        public string GetInfoCorsoDiLaurea()
        {
            return $"Corso di Laurea:{NomeCorsoLaurea} \t Durata Corso: {AnniDiCorso} \t CFU Tot Corso: {CFUperOttenerelaurea} \t Lista Esami: {Esame} ";
        }
    }
}

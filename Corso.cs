using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEsami
{
  public  class Corso
    {
        public string NomeEsame { get; set; }

        public int CFUEsame { get; set; }
        public bool Passato { get; set; }

        public Corso()
        {

        }
        public Corso(string nomeesame, int cfuesame, bool passato)
        {
            NomeEsame = nomeesame;
            CFUEsame = cfuesame;
            Passato = passato;
        }

        public string GetInfoEsame()
        {
            return $"Nome esame: {NomeEsame} \t CFU esame:{CFUEsame} \t Stato esame: {Passato}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEsami
{
    public class Immatricolazione
    {
        public int Matricola = 123;
        public DateTime DataInizio { get; set; }
        public CorsoDiLaurea CorsoDiLaurea { get; set; }
        public FuoriC FuoriCorso { get; set; }
        public int CFUaccumulati { get; set; }
    }
    public enum FuoriC{
        SI=0,
        NO=1
    };
}

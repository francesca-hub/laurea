using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneEsami
{
   public static class Universita
    {
        public static List<CorsoDiLaurea> CorsiL = new List<CorsoDiLaurea>();

        public static List<CorsoDiLaurea> AggiungiCorsiL()
        {
            CorsoDiLaurea cl1 = new CorsoDiLaurea("Matematica", 5, 570);
            CorsoDiLaurea cl2 = new CorsoDiLaurea("Fisica", 5, 590);
            CorsoDiLaurea cl3 = new CorsoDiLaurea("Informatica", 3, 150);
            CorsoDiLaurea cl4 = new CorsoDiLaurea("Ingegneria", 3, 180);
            CorsoDiLaurea cl5 = new CorsoDiLaurea("Lettere", 5, 480);

            CorsiL.Add(cl1);
            CorsiL.Add(cl2);
            CorsiL.Add(cl3);
            CorsiL.Add(cl4);
            CorsiL.Add(cl5);
            return CorsiL;



        }

        public static List<Corso> Esame = new List<Corso>();
        public static List<Corso> AggiungiEsame()
        {
            Corso e1 = new Corso("Algebra", 6,true);
            Corso e2 = new Corso("Analisi 1", 12, false);

            Esame.Add(e1);
            Esame.Add(e2);
            return Esame;
        }

        public static List<Studente> Studenti = new List<Studente>()
        {
            new Studente{Nome= "Mario", Cognome="Rossi"}
        };

        public static Studente CercaStudenteperMatricola(int matricola)
        {
            foreach (var item in Studenti)
            {
                if (item.Immatricolazione.Matricola == matricola)
                {
                    
                    return item;
                }
            }
            return null;
        }

        
        }
    }
    }

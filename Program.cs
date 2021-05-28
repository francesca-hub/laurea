using System;

namespace EsercitazioneEsami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto Studente!");

            Console.WriteLine("-------------------Menù----------------------");
            //verifico che lo studente sia iscritto ad un corso di laurea

            Console.WriteLine("Inserisci il tuo n° di matricola:");
            int matricola = int.Parse(Console.ReadLine());
            Studente studente = new Studente();
            studente = Universita.CercaStudenteperMatricola(matricola);

            if (studente == null)
            {
                Console.WriteLine("Non sei iscritto a nessun Corso di laurea, vuoi iscriverti? SI/NO");
                string risposta = Console.ReadLine();
                if (risposta.ToUpper() == "SI")
                {
                    Console.Write("\n Completa la registrazione. \n Inserisci Nome:");
                    string nome = Console.ReadLine();
                    Console.Write("\nInserisci Cognome: ");
                    string cognome = Console.ReadLine();
                    Console.Write("\nInserisci data di nascita: ");
                    DateTime datadinascita = DateTime.Parse(Console.ReadLine());
                    Immatricolazione immatricolazione1 = new Immatricolazione();

                    //ho tutte le info necessarie per creare un utente 
                    Studente s = new Studente(nome, cognome, datadinascita, immatricolazione1);
                    //devo aggiungerlo alla lista degli utenti del sito
                    Universita.Studenti.Add(s);
                    Console.WriteLine("Complimenti! Ti sei iscritto!");
                    studente = s;


                }
                else
                {
                    Console.WriteLine("Ciao!");
                    return;
                }
            }
            do
            {
                Console.WriteLine("Premi 1- Prenotazione esame ");
                Console.WriteLine("Premi 2- Verbalizzazione esame prenotato");
                Console.WriteLine("Premi 0- Exit");

                int scelta;

                do
                {
                    Console.Write("\nFai la tua scelta:");
                } while (!int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 2);

                switch (scelta)
                {
                    case 1:
                        Console.Write("A quale esame vuoi iscriverti?:");
                        string esame = Console.ReadLine();
                        // creo un metodo che controlla se l'esame è presente nella lista degli esami del corso di laurea
                        // se è presente, controllo che i CFUesame< CFUtot
                        //aggiungo questo esame alla lista degli esami associata allo studente 
                        break;

                    case 2: //richiamo la funzione
                        EsamePassato();


                        break;

                    case 0:
                        return;

                }

            } while (true);
        }

        private static void EsamePassato()
        {
            Corso c4 = new Corso();
            bool passato = false;
            foreach (var item in Universita.Esame)
            {
                //cerco l'esame nella lista
            }
        }
    }
}

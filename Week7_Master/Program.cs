using System;
using System.Linq;
using ProvaWeek7_CassanoValentina.Core.Entities;
using ProvaWeek7_CassanoValentina.Core.InterfaceRepositories;
using ProvaWeek7_CassanoValentina.RepositoryEF.RepositoryEF;




namespace ProvaWeek7_CassanoValentina
{
    public class Program
    {
        private static IBusinessLayer bl = new MainBusinessLayer(new RepositoryContattiEF(), new RepositoryIndirizziEF());
        static void Main(string[] args)
        {
            bool continua = true;
            while (continua)
            {
                int scelta = Start();
                continua = AnalizzaScelta(scelta);
            }
        }
        private static int Start()
        {
            Console.WriteLine("** Programma in avvio **");

            Console.WriteLine("** Rubrica aperta! **");
            Console.WriteLine("Digita la tua scelta:");


            Console.WriteLine("\nRUBRICA:");
            Console.WriteLine("1. Visualizza tutti i Contatti");
            Console.WriteLine("2. Aggiungi nuovo Contatto");
            Console.WriteLine("3. Aggiungi un Indirizzo"); //nome e descrizione
            Console.WriteLine("4. Elimina un Contatto");
            Console.WriteLine("0. Esci");
 

            int scelta;
            Console.Write("Inserisci scelta: ");
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 4)
            {
                Console.Write("Scelta errata. Riprova.");
            }
            return scelta;

        }
        private static bool AnalizzaScelta(int scelta)
        {
            switch (scelta)
            {
                case 1:
                    VisualizzaContatti();
                    break;
                case 2:
                    InserisciNuovoContatto();
                    break;
                case 3:
                    AggiungiIndirizzo(); 
                    break;
                case 4:
                    EliminaContatto();
                    break;

                case 0:
                    return false;
            }
            return true;
        }

     

        #region Gestione Contatti

        private static void VisualizzaContatti()
        {
            var contatti = bl.GetAllContatti();
            if (contatti.Count == 0)
            {
                Console.WriteLine("Non ci sono contatti salvati in rubrica");
            }
            else
            {
                Console.WriteLine("Contatti presenti:");
                foreach (var obj in contatti) { Console.WriteLine(obj.ToString()); }
            }
        }

        private static void InserisciNuovoContatto()
        {
            Console.WriteLine("Inserisci il Nome della Persona");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il Cognome della Persona");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci  il tipo d'indirizzo della Persona");
            string tipoindirizzo = Console.ReadLine();
            Console.WriteLine("Inserisci la via della Persona");
            string via = Console.ReadLine();
            Console.WriteLine("Inserisci la Città della Persona");
            string citta = Console.ReadLine();
            Console.WriteLine("Inserisci il CAP della Persona");
            int cap = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la Provincia della Persona");
            string provincia = Console.ReadLine();
            Console.WriteLine("Inserisci la Nazione della Persona");
            string nazione = Console.ReadLine();


            Contatto nuovoContatto = new Contatto();
            Indirizzo nuovoIndirizzo = new Indirizzo();

            nuovoContatto.Nome = nome;
            nuovoContatto.Cognome = cognome;
            nuovoIndirizzo.TipoIndirizzo = tipoindirizzo;
            nuovoIndirizzo.Via = via;
            nuovoIndirizzo.Città = citta;
            nuovoIndirizzo.CAP = cap;
            nuovoIndirizzo.Provincia = provincia;
            nuovoIndirizzo.Nazione = nazione;


            bl.InserisciNuovoContatto(nuovoContatto, nuovoIndirizzo);
        }

        private static void EliminaContatto()
        {
            Console.WriteLine("Lista Rubrica:");
            VisualizzaContatti();
            Console.WriteLine("Quale contatto vuoi eliminare? Inserisci l'id");
            int IDContattoDaElminare = int.Parse(Console.ReadLine());
            string esito = bl.EliminaContatto(IDContattoDaElminare);
            Console.WriteLine(esito);
        }

        #endregion

        #region Gestione Indirizzi
        private static void AggiungiIndirizzo()
        {
            Console.WriteLine("Inserisci l'ID del Contatto");

            int id = int.Parse(Console.ReadLine());
            var contatti = bl.GetContattoById(id);
            
            if(contatti == null) 
            { 
                Console.WriteLine("Il contatto non esiste, riprova"); }
            else
            {

                Console.WriteLine("Inserisci  il tipo d'indirizzo della Persona");
                string tipoindirizzo = Console.ReadLine();
                Console.WriteLine("Inserisci la via della Persona");
                string via = Console.ReadLine();
                Console.WriteLine("Inserisci la Città della Persona");
                string citta = Console.ReadLine();
                Console.WriteLine("Inserisci il CAP della Persona");
                int cap = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci la Provincia della Persona");
                string provincia = Console.ReadLine();
                Console.WriteLine("Inserisci la Nazione della Persona");
                string nazione = Console.ReadLine();


                Indirizzo nuovoIndirizzo = new Indirizzo();

                nuovoIndirizzo.TipoIndirizzo = tipoindirizzo;
                nuovoIndirizzo.Via = via;
                nuovoIndirizzo.Città = citta;
                nuovoIndirizzo.CAP = cap;
                nuovoIndirizzo.Provincia = provincia;
                nuovoIndirizzo.Nazione = nazione;


                string esito = bl.AggiungiIndirizzo(nuovoIndirizzo);
                Console.WriteLine(esito);

            }
        }
             
    
    #endregion
}
}
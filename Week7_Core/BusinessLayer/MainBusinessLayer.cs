using ProvaWeek7_CassanoValentina.Core.Entities;
using ProvaWeek7_CassanoValentina.Core.InterfaceRepositories;
using ProvaWeek7_CassanoValentina.Master;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProvaWeek7_CassanoValentina
{
    public class MainBusinessLayer : IBusinessLayer
    {

        private readonly IRepositoryContatti contattiRepo;
        private readonly IRepositoryIndirizzi indirizziRepo;


        public MainBusinessLayer(IRepositoryContatti contatti, IRepositoryIndirizzi indirizzi)
        {
            contattiRepo = contatti;
            indirizziRepo = indirizzi;
        }
        #region Gestione Contatti


        public List<Contatto> GetAllContatti()
        {
            return contattiRepo.GetAll();
        }

        public void InserisciNuovoContatto(Contatto newContatto)
        {
            Contatto contattoEsistente = contattiRepo.GetById(newContatto.IDContatto);
            if (contattoEsistente != null)
            {
                Console.WriteLine("Errore: Codice contatto già presente");
            }
            contattiRepo.Add(newContatto);
            Console.WriteLine("Contatto aggiunto!");

        }


        public List<Contatto> GetContattoById(int IDContatto)
        {
            var contatto = contattiRepo.GetById(IDContatto);
            if (contatto == null)
            {
                return null;
            }
            return contattiRepo.GetAll().Where(c => c.IDContatto == contatto.IDContatto).ToList();
        }

        public string ModificaContatto(int IDContattoDaModificare, string nuovoNomeDaModificare, string nuovoCognomeDaModificare, string NuovoTipoIndirizzo, string NuovaViaDaModificare, string NuovaCittàDaModificare, int CAPDaModificare, string ProvinciaDaModificare, string NazioneDaModificare)
        {
            var contatto = contattiRepo.GetById(IDContattoDaModificare);
            if (contatto == null)
            {
                return "Id errato/non esiste!";
            }
            contattiRepo.Update(contatto);
            return "Dati contatto aggiornati!";
        }

        public string EliminaContatto(int IDContattoDaEliminare)
        {
            var contatto = contattiRepo.GetById(IDContattoDaEliminare);
            if (contatto == null)
            {
                return "Id errato/non esiste!";
            }
            contattiRepo.Delete(contatto);
            return "Dati contatto aggiornati!";
        }


        #endregion Gestione Contatti

        #region Gestione Indirizzi
        public string AggiungiIndirizzo(Indirizzo nuovoIndirizzo)
        {
            Contatto contattoEsistente = contattiRepo.GetById(nuovoIndirizzo.IDContatto);
            if (contattoEsistente == null)
            {
                return "Codice errato";
            }
            indirizziRepo.Add(nuovoIndirizzo);
            return "Indrizzo aggiunto";


            #endregion Gestione Contatti
        }

        public void InserisciNuovoContatto(Contatto nuovoContatto, Indirizzo nuovoIndirizzo)
        {
            throw new NotImplementedException();
        }
    }
}
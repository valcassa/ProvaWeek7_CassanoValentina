using ProvaWeek7_CassanoValentina.Core.Entities;
using System.Collections.Generic;

namespace ProvaWeek7_CassanoValentina
{
    public interface IBusinessLayer
    {
        #region Gestione Contatti

        public List<Contatto> GetAllContatti();
        public void InserisciNuovoContatto(Contatto nuovoContatto, Indirizzo nuovoIndirizzo);

        public string ModificaContatto(int IDContattoDaModificare, string nuovoNomeDaModificare, string nuovoCognomeDaModificare, string NuovoTipoIndirizzo, string NuovaViaDaModificare, string NuovaCittàDaModificare, int CAPDaModificare, string ProvinciaDaModificare, string NazioneDaModificare);

        public string EliminaContatto(int IDContattoDaEliminare);
        public List<Contatto> GetContattoById(int IDContatto);

        #endregion Gestione Contatti

        #region Gestione Indirizzi
        public string AggiungiIndirizzo(Indirizzo nuovoIndirizzo);

        #endregion Gestione Indirizzi

    }
}

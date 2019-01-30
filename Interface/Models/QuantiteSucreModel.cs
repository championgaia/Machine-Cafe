using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface.Models
{
    #region QuantiteSucreModel
    public class QuantiteSucreModel
    {
        public int IdM { get; set; }
        public string QuantiteM { get; set; }
    }
    #endregion
    #region class ListQuantiteSucreMetier
    public class ListQuantiteSucreModel
    {
        public List<QuantiteSucreModel> ListeLibelle { get; set; }
        #region Constructeur de la classes ListQuantiteSucreMetier
        public ListQuantiteSucreModel(int idSucre)
        {
            RepoMetier repo = new RepoMetier();
            ListeLibelle = new List<QuantiteSucreModel>();
            foreach (var item in repo.GetSucreRepoMetier(idSucre))
            {
                ListeLibelle.Add(new QuantiteSucreModel { IdM = item.IdDto, QuantiteM = item.QuantiteDto });
            }
        }
        #endregion
    }
    #endregion
}
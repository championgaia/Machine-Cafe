using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface.Models
{
    #region MyRegion
    public class BoissonModel
    {
        public int IdM { get; set; }
        public string NomBoissonM { get; set; }
    }
    #endregion
    #region class ListBoissonModel
    public class ListBoissonModel
    {
        public List<BoissonModel> ListeBoissonM { get; set; }
        #region Constructeur de la classes ListBoissonModel
        public ListBoissonModel(int idBoisson)
        {
            RepoMetier repo = new RepoMetier();
            ListeBoissonM = new List<BoissonModel>();
            var liste = repo.GetBoissonRepoMetier(idBoisson);
            foreach (var item in liste)
            {
                ListeBoissonM.Add(new BoissonModel { IdM = item.IdDto, NomBoissonM = item.NomBoissonDto });
            }
        }
        #endregion

    }
    #endregion
}
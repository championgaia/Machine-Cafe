using Donnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    #region QuantiteSucreMetier
    internal class QuantiteSucreMetier
    {
        public int Id { get; set; }
        public string Quantite { get; set; }
    }
    #endregion
    #region class ListQuantiteSucreMetier
    internal class ListQuantiteSucreMetier
    {
        public List<QuantiteSucreMetier> ListeLibelle { get; set; }
        #region Constructeur de la classes ListQuantiteSucreMetier
        public ListQuantiteSucreMetier(int idSucre)
        {
            RepoDonnes repo = new RepoDonnes();
            ListeLibelle = new List<QuantiteSucreMetier>();
            foreach (var item in repo.GetSucreRepoDonnes(idSucre))
            {
                ListeLibelle.Add(new QuantiteSucreMetier { Id = item.IdDto, Quantite = item.QuantiteDto });
            }
        }
        #endregion
    }
    #endregion
}

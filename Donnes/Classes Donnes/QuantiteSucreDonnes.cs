using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donnes
{
    #region classe QuantiteSucreDonnes
    internal class QuantiteSucreDonnes
    {
        public int Id { get; set; }
        public string Quantite { get; set; }
    }
    #endregion
    #region class ListQuantiteSucreDonnes
    internal class ListQuantiteSucreDonnes
    {
        public List<QuantiteSucreDonnes> ListeLibelle { get; set; }
        #region Constructeur de la classes ListQuantiteSucreDonnes
        public ListQuantiteSucreDonnes(int idSucre)
        {
            MachineCafeContext context = new MachineCafeContext();
            ListeLibelle = new List<QuantiteSucreDonnes>();
            foreach (var item in context.GetSucre(idSucre))
            {
                ListeLibelle.Add(new QuantiteSucreDonnes { Id = item.Id, Quantite = item.Quantite });
            }
        }
        #endregion
    }
    #endregion
}

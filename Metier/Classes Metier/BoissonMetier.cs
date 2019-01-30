using Donnes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    #region MyRegion
    internal class BoissonMetier
    {
        public int Id { get; set; }
        public string NomBoisson { get; set; }
    }
    #endregion
    #region class ListBoissonMetier
    internal class ListBoissonMetier
    {
        public List<BoissonMetier> ListeBoisson { get; set; }
        #region Constructeur de la classes ListBoissonMetier
        public ListBoissonMetier(int idBoisson)
        {
            RepoDonnes repo = new RepoDonnes();
            ListeBoisson = new List<BoissonMetier>();
            var liste = repo.GetBoissonRepoDonnes(idBoisson);
            foreach (var item in liste)
            {
                ListeBoisson.Add(new BoissonMetier { Id = item.IdDto, NomBoisson = item.NomBoissonDto });
            }
        }
        #endregion

    }
    #endregion
}

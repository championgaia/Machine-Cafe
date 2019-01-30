using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donnes
{
    #region class BoissonDonnes
    internal class BoissonDonnes
    {
        public int Id { get; set; }
        public string NomBoisson { get; set; }
    }
    #endregion
    #region class ListBoissonDonnes
    internal class ListBoissonDonnes
    {
        public List<BoissonDonnes> ListeBoisson { get; set; }
        #region Constructeur de la classes ListeBoissonDonnes
        public ListBoissonDonnes(int idBoisson)
        {
            MachineCafeContext context = new MachineCafeContext();
            ListeBoisson = new List<BoissonDonnes>();
            foreach (var item in context.GetBoisson(idBoisson))
            {
                ListeBoisson.Add(new BoissonDonnes { Id = item.Id, NomBoisson = item.Nom });
            }
        }
        #endregion

    }
    #endregion
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donnes
{
    #region class LastSelection
    internal class SelectionDonnes
    {
        public int Id { get; set; } //nullable????
        public int FkBoisson { get; set; }
        public int FkQuantiteSucre { get; set; }
        public string NomBoisson { get; set; }
        public string QuantitySucre { get; set; }
        public bool MugPerson { get; set; }
        MachineCafeContext context = new MachineCafeContext();
        #region CreatSelectionDonnes
        public void CreatSelectionDonnes(SelectionDonnes selection)
        {
            context.CreatSelection(selection.FkQuantiteSucre, selection.MugPerson == true ? "oui" : "non", selection.FkBoisson);
        }
        #endregion
        #region Methode GetLastSelectionDonnes
        public SelectionDonnes GetLastSelectionDonnes()
        {
            var dernierSelection = context.GetLastSelection().FirstOrDefault();
            return new SelectionDonnes
            {
                Id = dernierSelection.Id,
                FkBoisson = dernierSelection.FkBoisson,
                FkQuantiteSucre = dernierSelection.FkQuantiteSucre,
                NomBoisson = dernierSelection.Nom,
                QuantitySucre = dernierSelection.Quantite,
                MugPerson = dernierSelection.MugPerso.Equals("non") ? false : true
            };
        }
        #endregion
        
    }
    #endregion
}

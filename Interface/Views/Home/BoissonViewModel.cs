using Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface.Views.Home
{
    #region BoissonViewModel
    public class BoissonViewModel
    {
        public int IdVM { get; set; }
        public string NomBoissonVM { get; set; }
    }
    #endregion
    #region class ListBoissonViewModel
    public class ListBoissonViewModel
    {
        public List<BoissonViewModel> ListeBoissonVM { get; set; }
        public SelectionModel LastSelectionVM { get; set; }
        #region Constructeur de la classes ListBoissonViewModel
        public ListBoissonViewModel(int idBoisson)
        {
            #region ListeBoissonVM
            ListBoissonModel listeModel = new ListBoissonModel(idBoisson);
            ListeBoissonVM = new List<BoissonViewModel>();
            foreach (var item in listeModel.ListeBoissonM)
            {
                ListeBoissonVM.Add(new BoissonViewModel { IdVM = item.IdM, NomBoissonVM = item.NomBoissonM });
            }
            #endregion
            #region LastSelectionVM
            LastSelectionVM = new SelectionModel().GetLastSelectionModel();
            #endregion
        }
        #endregion

    }
    #endregion

}
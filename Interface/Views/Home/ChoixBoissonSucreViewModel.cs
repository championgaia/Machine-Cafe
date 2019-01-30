using Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface.Views.Home
{
    #region ChoixBoissonSucreViewModel
    public class ChoixBoissonSucreViewModel
    {
        public BoissonModel Boisson { get; set; }
        public ListQuantiteSucreModel Libelles { get; set; }
        #region Construteur de la classe ChoixBoissonSucreViewModel
        public ChoixBoissonSucreViewModel(int idBoisson)
        {
            Boisson = new ListBoissonModel(idBoisson).ListeBoissonM.FirstOrDefault();
            Libelles = new ListQuantiteSucreModel(0);
        }
        #endregion
    }
    #endregion
}
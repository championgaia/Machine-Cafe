using Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface.Views.Home
{
    #region ChoixBoissonSucreMugViewModel
    public class ChoixBoissonSucreMugViewModel
    {
        public BoissonModel Boisson { get; set; }
        public QuantiteSucreModel Sucre { get; set; }
        public bool MugPerso { get; set; }
        #region Construteur de la classe ChoixBoissonSucreViewModel
        public ChoixBoissonSucreMugViewModel(int idBoisson, int idSucre)
        {
            Boisson = new ListBoissonModel(idBoisson).ListeBoissonM.FirstOrDefault();
            Sucre = new ListQuantiteSucreModel(idSucre).ListeLibelle.FirstOrDefault();
            MugPerso = false;
        }
        #endregion
        #region CreateSelectionViewModel
        public void CreateSelectionViewModel(ChoixBoissonSucreMugViewModel selection)
        {
            SelectionModel selectionModel = new SelectionModel
            {
                FkBoissonM = selection.Boisson.IdM,
                FkQuantiteSucreM = selection.Sucre.IdM,
                MugPersonM = selection.MugPerso
            };
            selectionModel.CreatSelectionModel(selectionModel);
        }
        #endregion
    }
    #endregion
}
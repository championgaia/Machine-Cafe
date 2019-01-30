using DTO_UIL_BOL;
using Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interface.Models
{
    public class SelectionModel
    {
        public int IdM { get; set; } //nullable????
        public int FkBoissonM { get; set; }
        public int FkQuantiteSucreM { get; set; }
        public string NomBoissonM { get; set; }
        public string QuantitySucreM { get; set; }
        public bool MugPersonM { get; set; }
        RepoMetier repo = new RepoMetier();
        #region CreatSelection Model
        public void CreatSelectionModel(SelectionModel selection)
        {
            repo.CreatSelectionRepoMetier(new SelectionDto
            {
                FkBoissonDto = selection.FkBoissonM,
                FkQuantiteSucreDto = selection.FkQuantiteSucreM,
                MugPersonDto = selection.MugPersonM
            });
        }
        #endregion
        #region GetLastSelectionModel
        public SelectionModel GetLastSelectionModel()
        {
            var dernierSelection = repo.GetLastSelectionRepoMetier();
            SelectionModel lastSelectionModel = new SelectionModel
            {
                IdM = dernierSelection.IdDto,
                FkBoissonM = dernierSelection.FkBoissonDto,
                FkQuantiteSucreM = dernierSelection.FkQuantiteSucreDto,
                NomBoissonM = dernierSelection.NomBoissonDto,
                QuantitySucreM = dernierSelection.QuantitySucreDto,
                MugPersonM = dernierSelection.MugPersonDto
            };
            return lastSelectionModel;
        }
        #endregion
    }
}
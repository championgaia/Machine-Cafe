using Donnes;
using DTO_BOL_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    #region MyRegion
    internal class SelectionMetier
    {
        public int Id { get; set; } //nullable????
        public int FkBoisson { get; set; }
        public int FkQuantiteSucre { get; set; }
        public string NomBoisson { get; set; }
        public string QuantitySucre { get; set; }
        public bool MugPerson { get; set; }
        RepoDonnes repo = new RepoDonnes();
        #region CreatSelection Metier
        public void CreatSelectionMetier(SelectionMetier selection)
        {
            repo.CreatSelectionRepoDonnes(new SelectionDto
            {
                FkBoissonDto = selection.FkBoisson,
                FkQuantiteSucreDto = selection.FkQuantiteSucre,
                MugPersonDto = selection.MugPerson
            });
        }
        #endregion
        #region GetLastSelectionMetier
        public SelectionMetier GetLastSelectionMetier()
        {
            var dernierSelectionDto = repo.GetLastSelectionRepoDonnes();
            return new SelectionMetier
            {
                Id = dernierSelectionDto.IdDto,
                FkBoisson = dernierSelectionDto.FkBoissonDto,
                FkQuantiteSucre = dernierSelectionDto.FkQuantiteSucreDto,
                NomBoisson = dernierSelectionDto.NomBoissonDto,
                QuantitySucre = dernierSelectionDto.QuantitySucreDto,
                MugPerson = dernierSelectionDto.MugPersonDto
            };
        }
        #endregion
    }
    #endregion

}

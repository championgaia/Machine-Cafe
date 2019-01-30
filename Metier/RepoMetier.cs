using DTO_UIL_BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class RepoMetier
    {
        #region GetBoisson RepoMetier
        public List<BoissonDto> GetBoissonRepoMetier(int idBoisson)
        {
            ListBoissonMetier boissons = new ListBoissonMetier(idBoisson);
            List<BoissonDto> listeDto = new List<BoissonDto>();
            foreach (var item in boissons.ListeBoisson)
            {
                listeDto.Add(new BoissonDto { IdDto = item.Id, NomBoissonDto = item.NomBoisson });
            }
            return listeDto;
        }
        #endregion
        #region GetSucre RepoMetier
        public List<QuantiteSucreDto> GetSucreRepoMetier(int idSucre)
        {
            ListQuantiteSucreMetier libelles = new ListQuantiteSucreMetier(idSucre);
            List<QuantiteSucreDto> listeDto = new List<QuantiteSucreDto>();
            foreach (var item in libelles.ListeLibelle)
            {
                listeDto.Add(new QuantiteSucreDto { IdDto = item.Id, QuantiteDto = item.Quantite });
            }
            return listeDto;
        }
        #endregion
        #region CreatSelection RepoMetier
        public void CreatSelectionRepoMetier(SelectionDto selection)
        {
            SelectionMetier selectionMetier = new SelectionMetier
            {
                FkBoisson = selection.FkBoissonDto,
                FkQuantiteSucre = selection.FkQuantiteSucreDto,
                MugPerson = selection.MugPersonDto
            };
            selectionMetier.CreatSelectionMetier(selectionMetier);
        }
        #endregion
        #region GetLastSelection RepoMetier
        public SelectionDto GetLastSelectionRepoMetier()
        {
            var lastSelection = new SelectionMetier().GetLastSelectionMetier();
            return new SelectionDto
            {
                IdDto = lastSelection.Id,
                FkBoissonDto = lastSelection.FkBoisson,
                FkQuantiteSucreDto = lastSelection.FkQuantiteSucre,
                NomBoissonDto = lastSelection.NomBoisson,
                MugPersonDto = lastSelection.MugPerson,
                QuantitySucreDto = lastSelection.QuantitySucre
            };
        }
        #endregion
    }
}

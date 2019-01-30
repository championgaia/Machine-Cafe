using DTO_BOL_DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donnes
{
    public class RepoDonnes
    {
        #region GetBoisson RepoDonnes
        public List<BoissonDto> GetBoissonRepoDonnes(int idBoisson)
        {
            ListBoissonDonnes boissons = new ListBoissonDonnes(idBoisson);
            List<BoissonDto> listeDto = new List<BoissonDto>();
            foreach (var item in boissons.ListeBoisson)
            {
                listeDto.Add(new BoissonDto {IdDto = item.Id, NomBoissonDto = item.NomBoisson});
            }
            return listeDto;
        }
        #endregion
        #region GetSucre RepoDonnes
        public List<QuantiteSucreDto> GetSucreRepoDonnes(int idSucre)
        {
            ListQuantiteSucreDonnes libelles = new ListQuantiteSucreDonnes(idSucre);
            List<QuantiteSucreDto> listeDto = new List<QuantiteSucreDto>();
            foreach (var item in libelles.ListeLibelle)
            {
                listeDto.Add(new QuantiteSucreDto { IdDto = item.Id, QuantiteDto = item.Quantite });
            }
            return listeDto;
        }
        #endregion
        #region CreatSelection RepoDonnes
        public void CreatSelectionRepoDonnes(SelectionDto selection)
        {
            SelectionDonnes selectionDonnes = new SelectionDonnes
            {
                FkBoisson = selection.FkBoissonDto,
                FkQuantiteSucre = selection.FkQuantiteSucreDto,
                MugPerson = selection.MugPersonDto
            };
            selectionDonnes.CreatSelectionDonnes(selectionDonnes);
        }
        #endregion
        #region GetLastSelection RepoDonnes
        public SelectionDto GetLastSelectionRepoDonnes()
        {
            var lastSelection = new SelectionDonnes().GetLastSelectionDonnes();
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

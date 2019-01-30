using Donnes;
using DTO_BOL_DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class WebAPIController : ApiController
    {
        RepoDonnes repo = new RepoDonnes();
        #region Choix Boisson
        public List<BoissonDto> GetBoissonAPI (int idBoisson)
        {
            return repo.GetBoissonRepoDonnes(idBoisson);
        }
        #endregion
        #region Choix Sucre
        public List<QuantiteSucreDto> GetSucreAPI(int idSucre)
        {
            return repo.GetSucreRepoDonnes(idSucre);
        }
        #endregion
        #region Last Selection
        public SelectionDto GetLastSelectionAPI(int idSelection)
        {
            return repo.GetLastSelectionRepoDonnes();
        }
        #endregion
        [HttpPost]
        #region Create Selection
        public IHttpActionResult CreatSelectionAPI(SelectionDto data3)
        {
            repo.CreatSelectionRepoDonnes(data3);
            return Ok();
        }
        #endregion
    }
}

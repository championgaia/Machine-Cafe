using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BOL_DAL
{
    #region classe BoisoinDto BOL DAL
    public class BoissonDto
    {
        public int IdDto { get; set; }
        public string NomBoissonDto { get; set; }
    }
    #endregion
    #region classe LastSelectionDto BOL DAL
    public class SelectionDto
    {
        public int IdDto { get; set; }
        public int FkBoissonDto { get; set; }
        public int FkQuantiteSucreDto { get; set; }
        public string NomBoissonDto { get; set; }
        public string QuantitySucreDto { get; set; }
        public bool MugPersonDto { get; set; } 
    }
    #endregion
    #region classe QuantiteSucreDto BOL DAL
    public class QuantiteSucreDto
    {
        public int IdDto { get; set; }
        public string QuantiteDto { get; set; }
    }
    #endregion
}

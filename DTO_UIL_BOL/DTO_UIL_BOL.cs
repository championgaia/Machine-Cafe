using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_UIL_BOL
{
    #region BoisoinDto BOL UIL
    public class BoissonDto
    {
        public int IdDto { get; set; }
        public string NomBoissonDto { get; set; }
    }
    #endregion
    #region classe LastSelectionDto BOL UIL
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
    #region classe QuantiteSucreDto BOL UIL
    public class QuantiteSucreDto
    {
        public int IdDto { get; set; }
        public string QuantiteDto { get; set; }
    }
    #endregion
}

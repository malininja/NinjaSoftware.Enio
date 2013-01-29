using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using System.ComponentModel.DataAnnotations;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
    [MetadataType(typeof(TarifaMetadata))]
    public partial class TarifaEntity
    {
        #region DataAnnotations

        public class TarifaMetadata
        {
            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            [StringLength(100, ErrorMessage = "Naziv ne može imati više od 100 znakova.")]
            public object Naziv;

            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            [RegularExpression(DataAnnotationConstants.CurrencyRegex, ErrorMessage = "Neispravno unesena stopa.")]
            public object Stopa;
        }

        #endregion
    }
}
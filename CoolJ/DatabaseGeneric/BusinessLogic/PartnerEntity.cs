using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using System.ComponentModel.DataAnnotations;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
    [MetadataType(typeof(PartnerMetadata))]
    public partial class PartnerEntity
    {
        #region DataAnnotations

        public class PartnerMetadata
        {
            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            [StringLength(100, ErrorMessage = "Naziv ne može imati više od 100 znakova.")]
            public object Naziv;

            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            [RegularExpression(@"^(\d{11})+$", ErrorMessage = "OIB mora biti broj sa 11 znamenki.")]
            public object Oib;

            [StringLength(100, ErrorMessage = "Adresa ne može imati više od 100 znakova.")]
            public object Adresa;

            [StringLength(20, ErrorMessage = "Mjesto ne može imati više od 20 znakova.")]
            public object Mjesto;

            [StringLength(10, ErrorMessage = "Pošta ne može imati više od 10 znakova.")]
            public object Posta;

            [Range(0, 65000, ErrorMessage = "Neispravna valuta.")]
            public object Valuta;
        }

        #endregion
    }
}
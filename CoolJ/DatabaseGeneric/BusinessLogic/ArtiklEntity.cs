using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using System.ComponentModel.DataAnnotations;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
    [MetadataType(typeof(ArtiklMetadata))]
    public partial class ArtiklEntity
    {
        #region DataAnnotations

        public class ArtiklMetadata
        {
            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            [StringLength(100, ErrorMessage = "Naziv ne može imati više od 100 znakova.")]
            public object Naziv;

            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            [StringLength(10, ErrorMessage = "Jedinica mjere ne može imati više od 10 znakova.")]
            public object Jm;

            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            public object PdvId;
        }

        #endregion
    }
}
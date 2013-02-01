using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using System.ComponentModel.DataAnnotations;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
    [MetadataType(typeof(CjenikMetadata))]
    public partial class CjenikEntity
    {
        #region DataAnnotations

        public class CjenikMetadata
        {
            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            public object ArtiklId;

            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            [RegularExpression(DataAnnotationConstants.CurrencyRegex, ErrorMessage = "Neispravno unesena cijena.")]
            public object Cijena;
        }

        #endregion

        #region static methods

        public static PredicateExpression FilterByPartner(long? partnerId)
        {
            PredicateExpression predicateExpression = new PredicateExpression();

            if (partnerId.HasValue)
            {
                predicateExpression.Add(CjenikFields.PartnerId == partnerId.Value);
            }
            else
            {
                predicateExpression.Add(CjenikFields.PartnerId == DBNull.Value);
            }

            return predicateExpression;
        }

        #endregion
    }
}
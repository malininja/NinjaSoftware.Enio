using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using System.ComponentModel.DataAnnotations;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
    [MetadataType(typeof(RacunGlavaMetadata))]
    public partial class RacunGlavaEntity
    {
        #region DataAnnotations

        public class RacunGlavaMetadata
        {
            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            public object Datum;
        }

        #endregion

        #region dynamic methods

        private decimal? _iznos;
        public decimal Iznos
        {
            get
            {
                if (!_iznos.HasValue)
                {
                    _iznos = 0;

                    foreach (RacunStavkaEntity racunStavka in this.RacunStavkaCollection)
                    {
                        _iznos += racunStavka.Iznos;
                    }
                }

                return _iznos.Value;
            }
        }
        #endregion
    }
}
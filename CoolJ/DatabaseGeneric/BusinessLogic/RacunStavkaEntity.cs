using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using System.ComponentModel.DataAnnotations;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
    [MetadataType(typeof(RacunStavkaMetadata))]
    public partial class RacunStavkaEntity
    {
        #region DataAnnotations

        public class RacunStavkaMetadata
        {
            [Required(ErrorMessage = DataAnnotationConstants.Required)]
            public object Datum;
        }

        #endregion

        #region dynamic methods

        public void RefreshCalculatedData(decimal tarifaStopa)
        {
            this.TarifaIznos = this.Kolicina * this.Cijena * tarifaStopa / 100;
            this.PdvIznos = (this.Kolicina * this.Cijena + this.TarifaIznos) * this.PdvPosto / 100;
            this.Iznos = this.Kolicina * this.Cijena + this.TarifaIznos + this.PdvIznos;
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;

namespace NinjaSoftware.Enio.Models
{
    public class ArtiklViewModel: IViewModel
    {
        #region Constructor

        public ArtiklViewModel(DataAccessAdapterBase adapter, long? artiklId)
        {
            if (artiklId.HasValue)
            {
                this.Artikl = ArtiklEntity.FetchArtikl(adapter, null, artiklId.Value);
            }
            else
            {
                this.Artikl = new ArtiklEntity();
                this.Artikl.IsActive = true;
            }
        }

        #endregion Constructor

        #region Public methods

        public void Save(DataAccessAdapterBase adapter)
        {
            this.Artikl.Save(adapter, true, false);
        }

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            this.PdvCollection = PdvEntity.FetchPdvCollection(adapter, null, null).OrderBy(pdv => pdv.Naziv);
        }

        #endregion Public methods

        #region Properties

        public ArtiklEntity Artikl { get; set; }
        public IEnumerable<PdvEntity> PdvCollection { get; set; }

        #endregion Properties
    }
}
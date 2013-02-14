using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;
using NinjaSoftware.Enio.CoolJ;

namespace NinjaSoftware.Enio.Models
{
    public class RacunViewModel : IViewModel
    {
        #region Constructors

        public RacunViewModel(DataAccessAdapterBase adapter)
        {
            this.RacunGlava = new RacunGlavaEntity();
        }

        public RacunViewModel(DataAccessAdapterBase adapter, long racunGlavaId)
        {
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection).
                SubPath.Add(RacunStavkaEntity.PrefetchPathArtikl);

            this.RacunGlava = RacunGlavaEntity.FetchRacunGlava(adapter, prefetchPath, racunGlavaId);
            this.RacunStavkaCollection = this.RacunGlava.RacunStavkaCollection;
        }

        #endregion Constructors

        #region Public methods

        public void Save(DataAccessAdapterBase adapter)
        {
            throw new NotImplementedException();
        }

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            this.ArtiklCollection = ArtiklEntity.FetchArtiklCollection(adapter, null, null).OrderBy(a => a.Naziv);
            this.PartnerCollection = PartnerEntity.FetchPartnerCollection(adapter, null, null).OrderBy(p => p.Naziv);
            this.TarifaCollection = TarifaEntity.FetchTarifaCollection(adapter, null, null).OrderBy(t => t.Naziv);
            this.StatusCollection = StatusRoEntity.FetchStatusRoCollection(adapter, null, null).OrderBy(s => s.Name);
        }

        public void UpdateRacunStavkaCollection(string racunStavkaCollectionJson)
        {
        
        }

        #endregion Public methods

        #region Properties

        public RacunGlavaEntity RacunGlava { get; set; }
        public IEnumerable<RacunStavkaEntity> RacunStavkaCollection { get; set; }
        public IEnumerable<ArtiklEntity> ArtiklCollection { get; set; }
        public IEnumerable<PartnerEntity> PartnerCollection { get; set; }
        public IEnumerable<TarifaEntity> TarifaCollection { get; set; }
        public IEnumerable<StatusRoEntity> StatusCollection { get; set; }

        #endregion Properties
    }
}
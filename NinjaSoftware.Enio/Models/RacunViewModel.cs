using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;
using NinjaSoftware.Enio.CoolJ;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using Newtonsoft.Json;
using System.Globalization;

namespace NinjaSoftware.Enio.Models
{
    public class RacunViewModel : IViewModel
    {
        #region Constructors

        public RacunViewModel(DataAccessAdapterBase adapter, long? racunGlavaId)
        {
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection).
                SubPath.Add(RacunStavkaEntity.PrefetchPathArtikl);

            if (racunGlavaId.HasValue)
            {
                this.RacunGlava = RacunGlavaEntity.FetchRacunGlava(adapter, prefetchPath, racunGlavaId.Value);
                this.RacunStavkaCollection = this.RacunGlava.RacunStavkaCollection;
            }
            else
            {
                this.RacunGlava = new RacunGlavaEntity();
                this.RacunStavkaCollection = new List<RacunStavkaEntity>();
            }
        }

        #endregion Constructors

        #region Public methods

        public void Save(DataAccessAdapterBase adapter)
        {
            this.RacunGlava.Save(adapter, false, false);
        }

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            this.ArtiklCollection = ArtiklEntity.FetchArtiklCollection(adapter, null, null).OrderBy(a => a.Naziv);
            this.PartnerCollection = PartnerEntity.FetchPartnerCollection(adapter, null, null).OrderBy(p => p.Naziv);
            this.TarifaCollection = TarifaEntity.FetchTarifaCollection(adapter, null, null).OrderBy(t => t.Naziv);
            this.StatusCollection = StatusRoEntity.FetchStatusRoCollection(adapter, null, null).OrderBy(s => s.Name);
        }

        public void UpdateRacunStavkaCollection(DataAccessAdapterBase adapter, string racunStavkaCollectionJson)
        {
            List<RacunStavkaEntity> deletedRacunStavkaCollection = this.RacunGlava.RacunStavkaCollection.GetEntitiesNotIncludedInJson(racunStavkaCollectionJson);
            foreach (RacunStavkaEntity racunStavka in deletedRacunStavkaCollection)
            {
                this.RacunGlava.RacunStavkaCollection.Remove(racunStavka);
                racunStavka.Delete(adapter);
            }

            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            jsonSettings.Culture = currentCulture;
            
            this.RacunGlava.RacunStavkaCollection.UpdateEntityCollectionFromJson(racunStavkaCollectionJson, RacunStavkaFields.RacunStavkaId, null, null, jsonSettings);
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
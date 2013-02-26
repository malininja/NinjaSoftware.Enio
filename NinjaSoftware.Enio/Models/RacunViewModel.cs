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
            SortExpression racunStavkaSort = new SortExpression(RacunStavkaFields.Pozicija | SortOperator.Ascending);

            prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection, 0, null, null, racunStavkaSort).
                SubPath.Add(RacunStavkaEntity.PrefetchPathArtikl);

            if (racunGlavaId.HasValue && racunGlavaId.Value > 0)
            {
                this.RacunGlava = RacunGlavaEntity.FetchRacunGlava(adapter, prefetchPath, racunGlavaId.Value);
                this.RacunStavkaCollection = this.RacunGlava.RacunStavkaCollection;
            }
            else
            {
                this.RacunGlava = new RacunGlavaEntity();
                this.RacunGlava.Datum = DateTime.Now;
                this.RacunStavkaCollection = new List<RacunStavkaEntity>();
            }
        }

        #endregion Constructors

        #region Public methods

        public void Save(DataAccessAdapterBase adapter)
        {
            foreach (RacunStavkaEntity racunStavka in this.RacunStavkaCollectionToDelete)
            {
                racunStavka.Delete(adapter);
            }

            foreach (RacunStavkaEntity racunStavka in this.RacunGlava.RacunStavkaCollection)
            {
                if (racunStavka.IsDirty)
                {
                    this.RacunGlava.IsDirty = true;
                }

                racunStavka.Save(adapter, false, false);
            }

            this.RacunGlava.Save(adapter, false, false);
        }

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            PrefetchPath2 prefetchPathArtikl = new PrefetchPath2(EntityType.ArtiklEntity);
            prefetchPathArtikl.Add(ArtiklEntity.PrefetchPathPdv);
            this.ArtiklCollection = ArtiklEntity.FetchArtiklCollection(adapter, null, prefetchPathArtikl).OrderBy(a => a.Naziv);

            this.PartnerCollection = PartnerEntity.FetchPartnerCollection(adapter, null, null).OrderBy(p => p.Naziv);
            this.TarifaCollection = TarifaEntity.FetchTarifaCollection(adapter, null, null).OrderBy(t => t.Naziv);
            this.StatusCollection = StatusRoEntity.FetchStatusRoCollection(adapter, null, null).OrderBy(s => s.Name);
        }

        public void UpdateModelFromJson(DataAccessAdapterBase adapter, string racunGlavaJson, string racunStavkaCollectionJson)
        {
            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            jsonSettings.Culture = currentCulture;

            RacunGlavaEntity racunGlavaDeserialized = JsonConvert.DeserializeObject<RacunGlavaEntity>(racunGlavaJson, jsonSettings);
            this.RacunGlava.UpdateDataFromOtherObject(racunGlavaDeserialized, null, null);

            this.RacunStavkaCollectionToDelete = this.RacunGlava.RacunStavkaCollection.GetEntitiesNotIncludedInJson(racunStavkaCollectionJson);
            foreach (RacunStavkaEntity racunStavka in this.RacunStavkaCollectionToDelete)
            {
                this.RacunGlava.RacunStavkaCollection.Remove(racunStavka);
            }
            
            this.RacunGlava.RacunStavkaCollection.UpdateEntityCollectionFromJson(racunStavkaCollectionJson, RacunStavkaFields.RacunStavkaId, null, null, jsonSettings);

            TarifaEntity tarifa = TarifaEntity.FetchTarifa(adapter, null, this.RacunGlava.TarifaId);

            short counter = 0;
            foreach (RacunStavkaEntity racunStavka in this.RacunStavkaCollection)
            {
                racunStavka.Pozicija = counter++;
                racunStavka.RefreshCalculatedData(tarifa.Stopa);
            }
        }

        #endregion Public methods

        #region Properties

        public RacunGlavaEntity RacunGlava { get; set; }
        public IEnumerable<RacunStavkaEntity> RacunStavkaCollection { get; set; }
        public List<RacunStavkaEntity> RacunStavkaCollectionToDelete { get; set; }
        public IEnumerable<ArtiklEntity> ArtiklCollection { get; set; }
        public IEnumerable<PartnerEntity> PartnerCollection { get; set; }
        public IEnumerable<TarifaEntity> TarifaCollection { get; set; }
        public IEnumerable<StatusRoEntity> StatusCollection { get; set; }

        #endregion Properties
    }
}
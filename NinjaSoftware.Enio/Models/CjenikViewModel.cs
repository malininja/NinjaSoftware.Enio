﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;
using NinjaSoftware.Enio.CoolJ;
using NinjaSoftware.Enio.CoolJ.HelperClasses;

namespace NinjaSoftware.Enio.Models
{
    public class CjenikViewModel: IViewModel
    {
        #region Constructors 

        public CjenikViewModel(DataAccessAdapterBase adapter, long? cjenikId, long? partnerId)
        {
            if (cjenikId.HasValue && 0 != cjenikId.Value)
            {
                PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.CjenikEntity);
                prefetchPath.Add(CjenikEntity.PrefetchPathArtikl);
                prefetchPath.Add(CjenikEntity.PrefetchPathPartner);

                this.Cjenik = CjenikEntity.FetchCjenik(adapter, prefetchPath, cjenikId.Value);
            }
            else
            {
                this.Cjenik = new CjenikEntity();

                if (partnerId.HasValue)
                {
                    this.Cjenik.Partner = PartnerEntity.FetchPartner(adapter, null, partnerId.Value);
                }
            }
        }

        #endregion Constructors

        #region Public methods

        public void Save(SD.LLBLGen.Pro.ORMSupportClasses.DataAccessAdapterBase adapter)
        {
            this.Cjenik.Save(adapter, false, false);
        }

        public void LoadViewSpecificData(SD.LLBLGen.Pro.ORMSupportClasses.DataAccessAdapterBase adapter)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(ArtiklFields.IsActive == true);
            this.ArtiklCollecton = ArtiklEntity.FetchArtiklCollection(adapter, bucket, null).OrderBy(a => a.Naziv);
        }

        #endregion Public methods

        #region Properties

        public CjenikEntity Cjenik { get; set; }
        public IEnumerable<ArtiklEntity> ArtiklCollecton { get; set; }

        #endregion Properties
    }
}
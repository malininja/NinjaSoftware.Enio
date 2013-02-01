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
    public class CjenikPager: PagerBase
    {
        public long? PartnerId { get; private set; }
        public PartnerEntity Partner { get; set; }

        public CjenikPager(DataAccessAdapterBase adapter, long? partnerId)
        {
            this.PartnerId = partnerId;

            if (this.PartnerId.HasValue)
            {
                this.Partner = PartnerEntity.FetchPartner(adapter, null, this.PartnerId.Value);
            }
        }

        protected override void SetDataSource(DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(CjenikEntity.FilterByPartner(this.PartnerId));
            bucket.Relations.Add(CjenikEntity.Relations.ArtiklEntityUsingArtiklId);

            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.CjenikEntity);
            prefetchPath.Add(CjenikEntity.PrefetchPathArtikl);

            this.DataSource = CjenikEntity.FetchCjenikCollectionForPaging(adapter, bucket, prefetchPath, pageNumber, pageSize, sortField, isSortAscending);
            this.NoOfRecords = CjenikEntity.GetNumberOfEntities(adapter, bucket);
        }

        public override string DefaultSortField
        {
            get { return "Artikl.Naziv"; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return true; }
        }
    }
}
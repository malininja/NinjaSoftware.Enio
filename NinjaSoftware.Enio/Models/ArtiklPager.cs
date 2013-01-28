using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ;
using NinjaSoftware.Enio.CoolJ.EntityClasses;

namespace NinjaSoftware.Enio.Models
{
    public class ArtiklPager: PagerBase
    {
        protected override void SetDataSource(DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.ArtiklEntity);
            prefetchPath.Add(ArtiklEntity.PrefetchPathPdv);

            IEnumerable<ArtiklEntity> artiklCollection =
                ArtiklEntity.FetchArtiklCollectionForPaging(adapter, null, prefetchPath, pageNumber, pageSize, sortField, isSortAscending);
            this.DataSource = artiklCollection;
            this.NoOfRecords = ArtiklEntity.GetNumberOfEntities(adapter, null);
        }

        public override string DefaultSortField
        {
            get { return ArtiklFields.Naziv.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return true; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;
using NinjaSoftware.Enio.CoolJ;

namespace NinjaSoftware.Enio.Models
{
    public class RacunGlavaPager: PagerBase
    {
        protected override void SetDataSource(DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            PrefetchPath2 prefetchPath = new PrefetchPath2(EntityType.RacunGlavaEntity);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathPartner);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathStatus);
            prefetchPath.Add(RacunGlavaEntity.PrefetchPathRacunStavkaCollection);

            this.DataSource = RacunGlavaEntity.FetchRacunGlavaCollectionForPaging(adapter, null, prefetchPath, pageNumber, pageSize, sortField, isSortAscending);
            this.NoOfRecords = RacunGlavaEntity.GetNumberOfEntities(adapter, null);
        }

        public override string DefaultSortField
        {
            get { return RacunGlavaFields.Datum.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return false; }
        }
    }
}
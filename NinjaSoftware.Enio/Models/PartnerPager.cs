using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;

namespace NinjaSoftware.Enio.Models
{
    public class PartnerPager : PagerBase
    {
        protected override void SetDataSource(SD.LLBLGen.Pro.ORMSupportClasses.DataAccessAdapterBase adapter, int pageNumber, int pageSize, string sortField, bool isSortAscending)
        {
            IEnumerable<PartnerEntity> partnerCollection = PartnerEntity.FetchPartnerCollectionForPaging(adapter, null, null, pageNumber, pageSize, sortField, isSortAscending);
            this.DataSource = partnerCollection;

            this.NoOfRecords = PartnerEntity.GetNumberOfEntities(adapter, null);
        }

        public override string DefaultSortField
        {
            get { return PartnerFields.Naziv.Name; }
        }

        public override bool IsDefaultSortDirectionAscending
        {
            get { return true; }
        }
    }
}
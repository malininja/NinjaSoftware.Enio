using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.Enio.Models;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;
using NinjaSoftware.Api.Mvc;

namespace NinjaSoftware.Enio.Controllers
{
    [Authorize(Roles = "User, Admin")]
    public class HomeController : NsController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        #region Partner

        [HttpGet]
        public ActionResult PartnerList()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                IEnumerable<PartnerEntity> partnerCollection = PartnerEntity.FetchPartnerCollection(adapter, null, null).OrderBy(p => p.Naziv);
                return View(partnerCollection);
            }
        }

        [HttpGet]
        public ActionResult PartnerEdit(long? partnerId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                PartnerEntity partner = FetchPartner(adapter, partnerId);

                return View(partner);
            }
        }

        [HttpPost]
        public ActionResult PartnerEdit(long? partnerId, FormCollection formCollection)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);

            PartnerEntity partner = FetchPartner(adapter, partnerId);

            if (TryUpdateAndSaveIEntity2(partner, adapter, false, false))
            {
                return RedirectToAction("PartnerList");
            }
            else
            {
                return View(partner);
            }
        }

        private PartnerEntity FetchPartner(DataAccessAdapterBase adapter, long? partnerId)
        {
            PartnerEntity partner;

            if (partnerId.HasValue && 0 != partnerId.Value)
            {
                partner = PartnerEntity.FetchPartner(adapter, null, partnerId.Value);
            }
            else
            {
                partner = new PartnerEntity();
                partner.IsActive = true;
            }

            return partner;
        }

        #endregion Partner
    }
}

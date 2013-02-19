using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.Enio.Models;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;
using NinjaSoftware.Api.Mvc;
using NinjaSoftware.Enio.CoolJ;
using System.Configuration;

namespace NinjaSoftware.Enio.Controllers
{
    [Authorize(Roles = "User, Admin")]
    public class HomeController : NsController
    {
        public int PageSize
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["PageSize"]);
            }
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        #region Artikl

        [HttpGet]
        public ActionResult ArtiklList(int? pageNumber, string sortField, bool? isSortAscending)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                ArtiklPager artiklPager = new ArtiklPager();
                artiklPager.LoadData(adapter, pageNumber, this.PageSize, sortField, isSortAscending);
                return View(artiklPager);
            }
        }

        [HttpGet]
        public ActionResult ArtiklEdit(long? artiklId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                ArtiklViewModel viewModel = new ArtiklViewModel(adapter, artiklId);
                viewModel.LoadViewSpecificData(adapter);
                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult ArtiklEdit(long? artiklId, FormCollection formCollection)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                ArtiklViewModel viewModel = new ArtiklViewModel(adapter, artiklId);
                if (TryUpdateAndSaveIViewModel(viewModel, adapter))
                {
                    return RedirectToAction("ArtiklList");
                }
                else
                {
                    return View(viewModel);
                }
            }
        }

        #endregion Artikl

        #region Partner

        [HttpGet]
        public ActionResult PartnerList(int? pageNumber, string sortField, bool? isSortAscending)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                PartnerPager partnerPager = new PartnerPager();
                partnerPager.LoadData(adapter, pageNumber, this.PageSize, sortField, isSortAscending);
                return View(partnerPager);
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
            using (adapter)
            {
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

        #region Pdv

        [HttpGet]
        public ActionResult PdvList()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                IEnumerable<PdvEntity> pdvCollection = PdvEntity.FetchPdvCollection(adapter, null, null);
                return View(pdvCollection);
            }
        }

        [HttpGet]
        public ActionResult PdvEdit(long? pdvId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                PdvEntity pdv = FetchPdv(adapter, pdvId);
                return View(pdv);
            }
        }

        [HttpPost]
        public ActionResult PdvEdit(long? tarifaId, FormCollection formCollection)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                PdvEntity pdv = FetchPdv(adapter, tarifaId);

                if (TryUpdateAndSaveIEntity2(pdv, adapter, false, false))
                {
                    return RedirectToAction("PdvList");
                }
                else
                {
                    return View(pdv);
                }
            }
        }

        private PdvEntity FetchPdv(DataAccessAdapterBase adapter, long? pdvId)
        {
            PdvEntity pdv;

            if (pdvId.HasValue && 0 != pdvId.Value)
            {
                pdv = PdvEntity.FetchPdv(adapter, null, pdvId.Value);
            }
            else
            {
                pdv = new PdvEntity();
            }

            return pdv;
        }

        #endregion Pdv

        #region Tarifa

        [HttpGet]
        public ActionResult TarifaList()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                IEnumerable<TarifaEntity> tarifaCollection = TarifaEntity.FetchTarifaCollection(adapter, null, null);
                return View(tarifaCollection);
            }
        }

        [HttpGet]
        public ActionResult TarifaEdit(long? tarifaId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                TarifaEntity tarifa = FetchTarifa(adapter, tarifaId);
                return View(tarifa);
            }
        }

        [HttpPost]
        public ActionResult TarifaEdit(long? tarifaId, FormCollection formCollection)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                TarifaEntity tarifa = FetchTarifa(adapter, tarifaId);

                if (TryUpdateAndSaveIEntity2(tarifa, adapter, false, false))
                {
                    return RedirectToAction("TarifaList");
                }
                else
                {
                    return View(tarifa);
                }
            }
        }

        private TarifaEntity FetchTarifa(DataAccessAdapterBase adapter, long? tarifaId)
        {
            TarifaEntity tarifa;

            if (tarifaId.HasValue && 0 != tarifaId.Value)
            {
                tarifa = TarifaEntity.FetchTarifa(adapter, null, tarifaId.Value);
            }
            else
            {
                tarifa = new TarifaEntity();
            }

            return tarifa;
        }

        #endregion Tarifa

        #region Racun

        [HttpGet]
        public ActionResult RacunGlavaList(int? pageNumber, string sortField, bool? isSortAscending)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                RacunGlavaPager pager = new RacunGlavaPager();
                pager.LoadData(adapter, pageNumber, this.PageSize, sortField, isSortAscending);

                return View(pager);
            }
        }

        [HttpGet]
        public ActionResult RacunEdit(long? racunGlavaId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                RacunViewModel racunViewModel = new RacunViewModel(adapter, racunGlavaId);
                racunViewModel.LoadViewSpecificData(adapter);

                return View(racunViewModel);
            }
        }

        #endregion Racun
    }
}

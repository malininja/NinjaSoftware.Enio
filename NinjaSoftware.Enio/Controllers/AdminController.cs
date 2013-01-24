using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.Models;
using NinjaSoftware.Enio.CoolJ.EntityClasses;
using NinjaSoftware.Api.Mvc;

namespace NinjaSoftware.Enio.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : NsController
    {
        #region User

        [HttpGet]
        public ActionResult UserList()
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                IEnumerable<UserEntity> userCollection = UserEntity.FetchUserCollection(adapter, null, null);
                return View(userCollection);
            }
        }

        [HttpGet]
        public ActionResult UserEdit(long? userId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            using (adapter)
            {
                UserViewModel viewModel = new UserViewModel(adapter, userId);
                viewModel.LoadViewSpecificData(adapter);

                return View(viewModel);
            }
        }

        [HttpPost]
        public ActionResult UserEdit(FormCollection formCollecton, long? userId)
        {
            DataAccessAdapterBase adapter = Helper.GetDataAccessAdapterFactory(User.Identity.Name);
            UserViewModel viewModel = new UserViewModel(adapter, userId);

            if (TryUpdateAndSaveIViewModel(viewModel, adapter))
            {
                return RedirectToAction("UserList");
            }
            else
            {
                return View(viewModel);
            }
        }

        #endregion
    }
}

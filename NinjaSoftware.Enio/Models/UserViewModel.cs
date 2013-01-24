using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NinjaSoftware.Api.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.EntityClasses;

namespace NinjaSoftware.Enio.Models
{
    public class UserViewModel: IViewModel
    {
        #region Constructor

        public UserViewModel(DataAccessAdapterBase adapter, long? userId)
        {
            if (userId.HasValue)
            {
                this.User = UserEntity.FetchUser(adapter, null, userId.Value);
            }
            else
            {
                this.User = new UserEntity();
            }
        }

        #endregion Constructor

        #region Public methods

        public void Save(DataAccessAdapterBase adapter)
        {
            this.User.Save(adapter, false, false);
        }

        public void LoadViewSpecificData(DataAccessAdapterBase adapter)
        {
            this.RoleCollection = RoleRoEntity.FetchRoleRoCollection(adapter, null, null).OrderBy(r => r.Name);
        }

        #endregion Public methods

        #region Properties

        public UserEntity User { get; set; }
        public IEnumerable<RoleRoEntity> RoleCollection { get; set; }

        #endregion Properties
    }
}
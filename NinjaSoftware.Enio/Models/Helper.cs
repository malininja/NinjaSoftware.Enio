using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Configuration;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.Enio.CoolJ.EntityClasses;

namespace NinjaSoftware.Enio.Models
{
    public static class Helper
    {
        public static DataAccessAdapterBase GetDataAccessAdapterFactory()
        {
            DataAccessAdapterBase adapter;
            switch (ConfigurationManager.ConnectionStrings[1].ProviderName)
            {
                case "System.Data.SqlClient":
                    adapter = new NinjaSoftware.Enio.CoolJ.SqlServer.DatabaseSpecific.DataAccessAdapter();
                    break;
                case "Npgsql":
                    adapter = new NinjaSoftware.Enio.CoolJ.PostgreSql.DatabaseSpecific.DataAccessAdapter();
                    break;
                default:
                    throw new Exception("Unsupported provider.");
            }

            return adapter;
        }

        public static DataAccessAdapterBase GetDataAccessAdapterFactory(string userName)
        {
            DataAccessAdapterBase adapter = GetDataAccessAdapterFactory();

            ((INsDataAccessAdapter)adapter).UserId = UserEntity.FetchUser(userName, null, adapter).UserId;

            return adapter;
        }
    }
}
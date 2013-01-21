using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
    public partial class UserEntity
    {
        public static UserEntity FetchUser(DataAccessAdapterBase adapter, string userName, PrefetchPath2 prefetchPath)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket(UserFields.Username == userName);
            return FetchUserCollection(adapter, bucket, prefetchPath).SingleOrDefault();
        }

        public static UserEntity FetchUser(DataAccessAdapterBase adapter, string userName, string passwordHash)
        {
            RelationPredicateBucket bucket = new RelationPredicateBucket();
            bucket.PredicateExpression.Add(UserFields.Username == userName);
            bucket.PredicateExpression.Add(UserFields.Password == passwordHash);

            return FetchUserCollection(adapter, bucket, null).SingleOrDefault();
        }

        public static bool ChangePassword(DataAccessAdapterBase adapter,
            string userName,
            string oldPasswordHash,
            string newPasswordHash)
        {
            UserEntity user = UserEntity.FetchUser(adapter, userName, oldPasswordHash);

            if (null == user)
            {
                return false;
            }
            else
            {
                user.Password = newPasswordHash;
                user.Save(adapter, false, false);

                return true;
            }
        }
    }
}
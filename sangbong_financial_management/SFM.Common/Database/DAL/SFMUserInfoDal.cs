using sangbong_financial_management.SFM.Common.Database.EFModel;
using sangbong_financial_management.SFM.Common.Database.Entity;
using System;
using System.Data;

namespace sangbong_financial_management.SFM.Common.Database.DAL
{
    public class SFMUserInfoDal
    {
        SFM_USER_INFO sfmUserInfo = new SFM_USER_INFO();
        SFMDatabaseModel sfmDatabaseModel = new SFMDatabaseModel();

        public int GetUserInfo(string userId, string userPw)
        {
            var selectQuery = $@"SELECT COUNT(1) AS COUNT FROM SFM_USER_INFO (NOLOCK)
                                    WHERE 1=1
                                    AND USER_ID = '{userId}'
                                    AND USER_PW = '{userPw}'";

            var resultRows = sfmDatabaseModel.ReadQuery(selectQuery);

            return Int32.Parse(resultRows.Rows[0]["COUNT"].ToString());
        }

        public void InsertUserInfo()
        {
            //sfmUserInfo.USER_ID = "dd";
            //sfmUserInfo.USER_PW = "dd";
            //sfmDatabaseModel.SFM_USER_INFO.Add(sfmUserInfo);

            //sfmDatabaseModel.SaveChanges();
        }
    }
}

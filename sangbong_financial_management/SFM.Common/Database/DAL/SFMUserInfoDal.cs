using sangbong_financial_management.SFM.Common.Database;
using sangbong_financial_management.SFM.Common.Database.Entity;
using System;

namespace sangbong_financial_management.SFM.Common.Database.DAL
{
    public class SFMUserInfoDal
    {
        SFM_USER_INFO sfmUserInfo = new SFM_USER_INFO();
        SFMDatabaseSetting sfmDatabaseSetting = new SFMDatabaseSetting();

        public int UserExistCheck(string userId, string userPw)
        {
            var selectQuery = $@"SELECT COUNT(1) AS RESULT_COUNT 
                                    FROM SFM_USER_INFO (NOLOCK)
                                    WHERE 1=1
                                    AND USER_ID = '{userId}'
                                    AND 1 = Pwdcompare('{userPw}', USER_PW)";

            var resultRows = sfmDatabaseSetting.ReadQuery(selectQuery);

            return Int32.Parse(resultRows.Rows[0]["RESULT_COUNT"].ToString());
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

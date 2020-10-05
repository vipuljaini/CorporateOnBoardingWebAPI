using BusinessLibrary;
using EntityDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Encryptions;
using System.Web.Http;

namespace CorporateOnBoarding.Models
{
    public class DataAccessLayer
    {
        QuickCheck_AngularEntities1 context = new QuickCheck_AngularEntities1();


        public Dictionary<string, object> BindCountry()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "BindCountry"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindState(string CountryID)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType","@CountryID", "BindState", Dbsecurity.Decrypt(CountryID)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindCity(string CountryID,string StateID)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@CountryID", "@StateID", "BindCity", Dbsecurity.Decrypt(CountryID), Dbsecurity.Decrypt(StateID)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindPSM([FromBody] PSMRequest bindPSMDropdown)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@BankID", "@SubMemberBank", "@AppId", "@EntityId", "BindPSM", bindPSMDropdown.BankId,bindPSMDropdown.SubMemberId,Dbsecurity.Decrypt(bindPSMDropdown.AppId),Dbsecurity.Decrypt(bindPSMDropdown.EntityId)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> SaveData([FromBody] DataSaveRequest SaveRequest)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@BankID", "@SubMemberBank", "@AppId", "@EntityId", "BindPSM", SaveRequest.UtilityCode, SaveRequest.UtilityCode, Dbsecurity.Decrypt(SaveRequest.UtilityCode), Dbsecurity.Decrypt(SaveRequest.EntityId)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
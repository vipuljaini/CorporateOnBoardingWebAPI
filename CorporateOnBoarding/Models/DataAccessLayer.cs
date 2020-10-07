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

                string @XmlCorporateEntity = "";
                @XmlCorporateEntity = "<dtXml>";

                @XmlCorporateEntity += "<dtXml ";
                @XmlCorporateEntity += " CustomerName=" + @"""" + SaveRequest.txtCustomerName + @"""";
                @XmlCorporateEntity += " CustomerAddress=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                // @XmlCorporateEntity += " BankID=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                // @XmlCorporateEntity += " SubMemberBankID=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                @XmlCorporateEntity += " Country=" + @"""" + SaveRequest.ddlCountry  + @"""";
                @XmlCorporateEntity += " State=" + @"""" + SaveRequest.ddlState + @"""";
                @XmlCorporateEntity += " City=" + @"""" + SaveRequest.ddlCity + @"""";
                @XmlCorporateEntity += " UtilityCodeFirst=" + @"""" + SaveRequest.txtUtilityCode + @"""";
                @XmlCorporateEntity += " UtilityCodeSec=" + @"""" + SaveRequest.txtUtilityCode + @"""";
                @XmlCorporateEntity += " UtilityCodeThird=" + @"""" + SaveRequest.txtUtilityCode + @"""";
                @XmlCorporateEntity += " UtilityCodeFourth=" + @"""" + SaveRequest.txtUtilityCode + @"""";
                // @XmlCorporateEntity += " BusinessSegmentCode=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                // @XmlCorporateEntity += " RMID=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                @XmlCorporateEntity += " PSMID=" + @"""" + SaveRequest.ddlPSM + @"""";
                @XmlCorporateEntity += " ContactPersonFirst=" + @"""" + SaveRequest.txtContactPerson1 + @"""";
                @XmlCorporateEntity += " ContactPersonDesg=" + @"""" + SaveRequest.txtContactPersonDesignation + @"""";
                @XmlCorporateEntity += " ContactNo=" + @"""" + SaveRequest.txtContactNo + @"""";
                @XmlCorporateEntity += " FAX=" + @"""" + SaveRequest.txtFAX + @"""";
                @XmlCorporateEntity += " Arrangement=" + @"""" + SaveRequest.txtArrangement + @"""";
                @XmlCorporateEntity += " PickUpPoint=" + @"""" + SaveRequest.txtPickUpPoint + @"""";
                @XmlCorporateEntity += " Location=" + @"""" + SaveRequest.txtLocation + @"""";
                @XmlCorporateEntity += " ContactPesonSecond=" + @"""" + SaveRequest.txtContactPerson2 + @"""";
                @XmlCorporateEntity += " ContactPersonName=" + @"""" + SaveRequest.txtContactPersonName + @"""";
                @XmlCorporateEntity += " CustomerEmail=" + @"""" + SaveRequest.txtCustomerEmail + @"""";
                // @XmlCorporateEntity += " EntityId=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                //  @XmlCorporateEntity += " AppId=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                // @XmlCorporateEntity += " TokenID=" + @"""" + SaveRequest.txtCustomerAddress + @"""";



                @XmlCorporateEntity += " />";

                @XmlCorporateEntity += "</dtXml>";


                string @XmlCorporateFinancial = "";
                @XmlCorporateFinancial = "<dtXml>";

                @XmlCorporateFinancial += "<dtXml ";
                @XmlCorporateFinancial += " PAN=" + @"""" + SaveRequest.txtPAN + @"""";
                @XmlCorporateFinancial += " TAN=" + @"""" + SaveRequest.txtTAN + @"""";
                // @XmlCorporateEntity += " BankID=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                // @XmlCorporateEntity += " SubMemberBankID=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                @XmlCorporateFinancial += " GST=" + @"""" + SaveRequest.txtGST + @"""";
                @XmlCorporateFinancial += " AHRM=" + @"""" + SaveRequest.ddlAHRM + @"""";

                @XmlCorporateFinancial += " AHPSM=" + @"""" + SaveRequest.ddlAHPSM + @"""";
                @XmlCorporateFinancial += " />";
                @XmlCorporateFinancial += "</dtXml>";



                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@XmlCorporateEntity", "@XmlCorporateFinancial", "SaveData", @XmlCorporateEntity,@XmlCorporateFinancial));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
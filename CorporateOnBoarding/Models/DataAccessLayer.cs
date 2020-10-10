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

        public Dictionary<string, object> BindRM([FromBody] PSMRequest bindRMDropdown)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@BankID", "@SubMemberBank", "@AppId", "@EntityId", "BindRM", bindRMDropdown.BankId, bindRMDropdown.SubMemberId, Dbsecurity.Decrypt(bindRMDropdown.AppId), Dbsecurity.Decrypt(bindRMDropdown.EntityId)));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Dictionary<string, object> BindRegionalManager([FromBody] PSMRequest bindRegionalManagerDropdown)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@BankID", "@SubMemberBank", "@AppId", "@EntityId", "BindRegionalManager", bindRegionalManagerDropdown.BankId, bindRegionalManagerDropdown.SubMemberId, Dbsecurity.Decrypt(bindRegionalManagerDropdown.AppId), Dbsecurity.Decrypt(bindRegionalManagerDropdown.EntityId)));
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
                @XmlCorporateEntity += " BankID=" + @"""" + SaveRequest.BankId + @"""";
                // @XmlCorporateEntity += " SubMemberBankID=" + @"""" + SaveRequest.txtCustomerAddress + @"""";
                @XmlCorporateEntity += " Country=" + @"""" + SaveRequest.ddlCountry  + @"""";
                @XmlCorporateEntity += " State=" + @"""" + SaveRequest.ddlState + @"""";
                @XmlCorporateEntity += " City=" + @"""" + SaveRequest.ddlCity + @"""";
                @XmlCorporateEntity += " UtilityCodeFirst=" + @"""" + SaveRequest.txtUtilityCode + @"""";
                @XmlCorporateEntity += " UtilityCodeSec=" + @"""" + SaveRequest.txtUtilityCode + @"""";
                @XmlCorporateEntity += " UtilityCodeThird=" + @"""" + SaveRequest.txtUtilityCode + @"""";
                @XmlCorporateEntity += " UtilityCodeFourth=" + @"""" + SaveRequest.txtUtilityCode + @"""";
                @XmlCorporateEntity += " BusinessSegmentCode=" + @"""" + SaveRequest.BusinessSegmentCode + @"""";
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

                string @XmlContactPersonArray = "";
                @XmlContactPersonArray = "<dtXml>";

                foreach (var corporatedata in SaveRequest.ContactPersonArray)
                {

                    @XmlContactPersonArray += "<dtXml ";
                    @XmlContactPersonArray += " Name=" + @"""" + corporatedata.ContactPesonName + @"""";
                    @XmlContactPersonArray += " Designation=" + @"""" + corporatedata.ContactPesonDesignation + @"""";
                    @XmlContactPersonArray += " ContactNo=" + @"""" + corporatedata.ContactPesonContact + @"""";
                    @XmlContactPersonArray += " FaxNo=" + @"""" + corporatedata.ContactPesonFax + @"""";
                    @XmlContactPersonArray += " Address=" + @"""" + corporatedata.ContactPesonAddress + @"""";
                    @XmlContactPersonArray += " />";

                }
                @XmlContactPersonArray += "</dtXml>";

                //var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@XmlCorporateEntity", "@XmlCorporateFinancial", "SaveData", @XmlCorporateEntity,@XmlCorporateFinancial));

                //---- Save Service Offered XML Code -------------//

                string @XmlPhysicalMandateData = "";
                @XmlPhysicalMandateData = "<dtXml>";
                if (SaveRequest.ddlPhysicalMandate=="1") {
                    @XmlPhysicalMandateData += "<dtXml ";
                    @XmlPhysicalMandateData += " PMPerTransCharge=" + @"""" + SaveRequest.PMPerTransCharge + @"""";
                    @XmlPhysicalMandateData += " PMSetupInteCharge=" + @"""" + SaveRequest.PMSetupInteCharge + @"""";
                    @XmlPhysicalMandateData += " PMUserIdChargePerMonth=" + @"""" + SaveRequest.PMUserIdChargePerMonth + @"""";
                    @XmlPhysicalMandateData += " PMTrainningCharge=" + @"""" + SaveRequest.PMTrainningCharge + @"""";
                    @XmlPhysicalMandateData += " PMAnnualMaintenance=" + @"""" + SaveRequest.PMAnnualMaintenance + @"""";
                    @XmlPhysicalMandateData += " IsPhysicalMandate=" + @"""" + SaveRequest.ddlPhysicalMandate + @"""";
                    @XmlPhysicalMandateData += " />";
                }
                @XmlPhysicalMandateData += "</dtXml>";

                string @XmlEMandateData = "";
                @XmlEMandateData = "<dtXml>";
                if (SaveRequest.ddlEMandate == "1")
                {
                    @XmlEMandateData += "<dtXml ";
                    @XmlEMandateData += " EMPerTransCharge=" + @"""" + SaveRequest.EMPerTransCharge + @"""";
                    @XmlEMandateData += " EMSetupInteCharge=" + @"""" + SaveRequest.EMSetupInteCharge + @"""";
                    @XmlEMandateData += " EMUserIdChargePerMonth=" + @"""" + SaveRequest.EMUserIdChargePerMonth + @"""";
                    @XmlEMandateData += " EMTrainningCharge=" + @"""" + SaveRequest.EMTrainningCharge + @"""";
                    @XmlEMandateData += " EMAnnualMaintenance=" + @"""" + SaveRequest.EMAnnualMaintenance + @"""";
                    @XmlEMandateData += " IsEMandate=" + @"""" + SaveRequest.ddlEMandate + @"""";
                    @XmlEMandateData += " />";
                }
                @XmlEMandateData += "</dtXml>";

                string @XmlAadharMandateData = "";
                @XmlAadharMandateData = "<dtXml>";
                if (SaveRequest.ddlAadharMandate == "1")
                {
                    @XmlAadharMandateData += "<dtXml ";
                    @XmlAadharMandateData += " ABMPerTransCharge=" + @"""" + SaveRequest.ABMPerTransCharge + @"""";
                    @XmlAadharMandateData += " ABMSetupInteCharge=" + @"""" + SaveRequest.ABMSetupInteCharge + @"""";
                    @XmlAadharMandateData += " ABMUserIdChargePerMonth=" + @"""" + SaveRequest.ABMUserIdChargePerMonth + @"""";
                    @XmlAadharMandateData += " ABMTrainningCharge=" + @"""" + SaveRequest.ABMTrainningCharge + @"""";
                    @XmlAadharMandateData += " ABMAnnualMaintenance=" + @"""" + SaveRequest.ABMAnnualMaintenance + @"""";
                    @XmlAadharMandateData += " IsAadharMandate=" + @"""" + SaveRequest.ddlAadharMandate + @"""";
                    @XmlAadharMandateData += " />";
                }
                @XmlAadharMandateData += "</dtXml>";

                string @XmlDirectDebitMandateData = "";
                @XmlDirectDebitMandateData = "<dtXml>";
                if (SaveRequest.ddlDirectDebitMandate == "1")
                {
                    @XmlDirectDebitMandateData += "<dtXml ";
                    @XmlDirectDebitMandateData += " DDMPerTransCharge=" + @"""" + SaveRequest.DDMPerTransCharge + @"""";
                    @XmlDirectDebitMandateData += " DDMSetupInteCharge=" + @"""" + SaveRequest.DDMSetupInteCharge + @"""";
                    @XmlDirectDebitMandateData += " DDMUserIdChargePerMonth=" + @"""" + SaveRequest.DDMUserIdChargePerMonth + @"""";
                    @XmlDirectDebitMandateData += " DDMTrainningCharge=" + @"""" + SaveRequest.DDMTrainningCharge + @"""";
                    @XmlDirectDebitMandateData += " DDMAnnualMaintenance=" + @"""" + SaveRequest.DDMAnnualMaintenance + @"""";
                    @XmlDirectDebitMandateData += " IsDirectDebitMandate=" + @"""" + SaveRequest.ddlDirectDebitMandate + @"""";
                    @XmlDirectDebitMandateData += " />";
                }
                @XmlDirectDebitMandateData += "</dtXml>";

                string @XmlDebitPresentationData = "";
                @XmlDebitPresentationData = "<dtXml>";
                if (SaveRequest.ddlDebitPresentation == "1")
                {
                    @XmlDebitPresentationData += "<dtXml ";
                    @XmlDebitPresentationData += " NTPPerTransCharge=" + @"""" + SaveRequest.NTPPerTransCharge + @"""";
                    @XmlDebitPresentationData += " NTPSetupInteCharge=" + @"""" + SaveRequest.NTPSetupInteCharge + @"""";
                    @XmlDebitPresentationData += " NTPUserIdChargePerMonth=" + @"""" + SaveRequest.NTPUserIdChargePerMonth + @"""";
                    @XmlDebitPresentationData += " NTPTrainningCharge=" + @"""" + SaveRequest.NTPTrainningCharge + @"""";
                    @XmlDebitPresentationData += " NTPAnnualMaintenance=" + @"""" + SaveRequest.NTPAnnualMaintenance + @"""";
                    @XmlDebitPresentationData += " IsDebitPresentation=" + @"""" + SaveRequest.ddlDebitPresentation + @"""";
                    @XmlDebitPresentationData += " />";
                }
                @XmlDebitPresentationData += "</dtXml>";

                string @XmlUPICollectionData = "";
                @XmlUPICollectionData = "<dtXml>";
                if (SaveRequest.ddlUPICollection == "1")
                {
                    @XmlUPICollectionData += "<dtXml ";
                    @XmlUPICollectionData += " UCPerTransCharge=" + @"""" + SaveRequest.UCPerTransCharge + @"""";
                    @XmlUPICollectionData += " UCSetupInteCharge=" + @"""" + SaveRequest.UCSetupInteCharge + @"""";
                    @XmlUPICollectionData += " UCUserIdChargePerMonth=" + @"""" + SaveRequest.UCUserIdChargePerMonth + @"""";
                    @XmlUPICollectionData += " UCTrainningCharge=" + @"""" + SaveRequest.UCTrainningCharge + @"""";
                    @XmlUPICollectionData += " UCAnnualMaintenance=" + @"""" + SaveRequest.UCAnnualMaintenance + @"""";
                    @XmlUPICollectionData += " IsUPICollection=" + @"""" + SaveRequest.ddlUPICollection + @"""";
                    @XmlUPICollectionData += " />";
                }
                @XmlUPICollectionData += "</dtXml>";

                string @XmlBBPSData = "";
                @XmlBBPSData = "<dtXml>";
                if (SaveRequest.ddlBBPS == "1")
                {
                    @XmlBBPSData += "<dtXml ";
                    @XmlBBPSData += " BBPerTransCharge=" + @"""" + SaveRequest.BBPerTransCharge + @"""";
                    @XmlBBPSData += " BBSetupInteCharge=" + @"""" + SaveRequest.BBSetupInteCharge + @"""";
                    @XmlBBPSData += " BBUserIdChargePerMonth=" + @"""" + SaveRequest.BBUserIdChargePerMonth + @"""";
                    @XmlBBPSData += " BBTrainningCharge=" + @"""" + SaveRequest.BBTrainningCharge + @"""";
                    @XmlBBPSData += " BBAnnualMaintenance=" + @"""" + SaveRequest.BBAnnualMaintenance + @"""";
                    @XmlBBPSData += " IsBBPS=" + @"""" + SaveRequest.ddlBBPS + @"""";
                    @XmlBBPSData += " />";
                }
                @XmlBBPSData += "</dtXml>";

                string @XmlAPBSData = "";
                @XmlAPBSData = "<dtXml>";
                if (SaveRequest.ddlAPBS == "1")
                {
                    @XmlAPBSData += "<dtXml ";
                    @XmlAPBSData += " APPerTransCharge=" + @"""" + SaveRequest.APPerTransCharge + @"""";
                    @XmlAPBSData += " APSetupInteCharge=" + @"""" + SaveRequest.APSetupInteCharge + @"""";
                    @XmlAPBSData += " APUserIdChargePerMonth=" + @"""" + SaveRequest.APUserIdChargePerMonth + @"""";
                    @XmlAPBSData += " APTrainningCharge=" + @"""" + SaveRequest.APTrainningCharge + @"""";
                    @XmlAPBSData += " APAnnualMaintenance=" + @"""" + SaveRequest.APAnnualMaintenance + @"""";
                    @XmlAPBSData += " IsAPBS=" + @"""" + SaveRequest.ddlAPBS + @"""";
                    @XmlAPBSData += " />";
                }
                @XmlAPBSData += "</dtXml>";

                //---- End Save Service Offered XML Code -------------//


                //----  Save Billing/Other Details XML Code -------------//

                string @XmlBilling_OtherDetailsData = "";
                @XmlBilling_OtherDetailsData = "<dtXml>";
                @XmlBilling_OtherDetailsData += "<dtXml ";

                @XmlBilling_OtherDetailsData += " BillingContactPerson=" + @"""" + SaveRequest.BillingContactPerson + @"""";             
                @XmlBilling_OtherDetailsData += " BillingDesignation=" + @"""" + SaveRequest.BillingDesignation + @""""; 
                @XmlBilling_OtherDetailsData += " BillingContactNo=" + @"""" + SaveRequest.BillingContactNo + @""""; 
                @XmlBilling_OtherDetailsData += " BillingFaxNo=" + @"""" + SaveRequest.BillingFaxNo + @""""; 
                @XmlBilling_OtherDetailsData += " BillingAddress=" + @"""" + SaveRequest.BillingAddress + @"""";  
                @XmlBilling_OtherDetailsData += " PickupContactPerson=" + @"""" + SaveRequest.PickupContactPerson + @""""; 
                @XmlBilling_OtherDetailsData += " PickupLocationAddress=" + @"""" + SaveRequest.PickupLocationAddress + @""""; 
                if (SaveRequest.ddlArrangmentDays == "")
                { @XmlBilling_OtherDetailsData += " ddlArrangmentDays=" + @"""" + "0" + @""""; }
                else { @XmlBilling_OtherDetailsData += " ddlArrangmentDays=" + @"""" + SaveRequest.ddlArrangmentDays + @""""; }
                @XmlBilling_OtherDetailsData += " CommMail_Primary=" + @"""" + SaveRequest.CommMail_Primary + @"""";
                @XmlBilling_OtherDetailsData += " CommMail_Billing=" + @"""" + SaveRequest.CommMail_Billing + @""""; 
                @XmlBilling_OtherDetailsData += " ChargeDebitAccNo=" + @"""" + SaveRequest.ChargeDebitAccNo + @"""";
                @XmlBilling_OtherDetailsData += " BankCorpID=" + @"""" + SaveRequest.BankCorpID + @"""";
                @XmlBilling_OtherDetailsData += " BranchName=" + @"""" + SaveRequest.BranchName + @"""";
                @XmlBilling_OtherDetailsData += " BranchCode=" + @"""" + SaveRequest.BranchCode + @"""";
                @XmlBilling_OtherDetailsData += " IFSC=" + @"""" + SaveRequest.IFSC + @""""; 
                if (SaveRequest.Settlement == "")
                { @XmlBilling_OtherDetailsData += " Settlement=" + @"""" + "0"  + @""""; }
                else { @XmlBilling_OtherDetailsData += " Settlement=" + @"""" + SaveRequest.Settlement + @""""; }

                @XmlBilling_OtherDetailsData += " />";
                @XmlBilling_OtherDetailsData += "</dtXml>";

                //---- End Save Billing/Other Details XML Code -------------//


                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Success>().Execute("@QueryType", "@BankID", "@SubMemberBank", "@XmlPhysicalMandateData", "@XmlEMandateData", "@XmlAadharMandateData", "@XmlDirectDebitMandateData", "@XmlDebitPresentationData", "@XmlUPICollectionData", "@XmlBBPSData", "@XmlAPBSData", "@XmlBilling_OtherDetailsData", "@AppId", "@EntityId", "@UserId","@XmlCorporateEntity", "@XmlCorporateFinancial", "@XmlContactPersonArray", "SaveData", "1", "2", @XmlPhysicalMandateData, @XmlEMandateData, @XmlAadharMandateData, @XmlDirectDebitMandateData, @XmlDebitPresentationData, @XmlUPICollectionData, @XmlBBPSData, @XmlAPBSData, @XmlBilling_OtherDetailsData, "123456", Dbsecurity.Decrypt(HttpContext.Current.Server.UrlDecode(SaveRequest.EntityId.Replace("_", "%"))), Dbsecurity.Decrypt(HttpContext.Current.Server.UrlDecode(SaveRequest.UserId.Replace("_", "%"))), @XmlCorporateEntity,@XmlCorporateFinancial, @XmlContactPersonArray));
                //var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@BankID", "@SubMemberBank", "@XmlPhysicalMandateData", "@XmlEMandateData", "@XmlAadharMandateData", "@XmlDirectDebitMandateData", "@XmlDebitPresentationData", "@XmlUPICollectionData", "@XmlBBPSData", "@XmlAPBSData", "@AppId", "@EntityId","@UserId", "BindPSM",SaveRequest.BankId, SaveRequest.SubMemberId, @XmlPhysicalMandateData, @XmlEMandateData, @XmlAadharMandateData, @XmlDirectDebitMandateData, @XmlDebitPresentationData, @XmlUPICollectionData, @XmlBBPSData, @XmlAPBSData, SaveRequest.UtilityCode, SaveRequest.UtilityCode, Dbsecurity.Decrypt(SaveRequest.UtilityCode), Dbsecurity.Decrypt(SaveRequest.EntityId), Dbsecurity.Decrypt(HttpContext.Current.Server.UrlDecode(SaveRequest.UserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindAllCorporateGrid(PSMRequest Data)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<BindAllCorporateGrid>().Execute("@QueryType", "@UserId", "@EntityId", "BindAllCorporateGrid","2","2" ));  //Data.UserId,Data.EntityId
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindBank()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<BindBank>().Execute("@QueryType", "BindBank"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindBusinessSegmentCode()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<BindBusinessSegmentCode>().Execute("@QueryType", "BindBusinessSegmentCode"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindSettlement()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<BindSettlement>().Execute("@QueryType", "BindSettlement"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> EditData([FromBody] DataSaveRequest SaveRequest)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Success>().Execute("@QueryType", "EditData"));
                //var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@BankID", "@SubMemberBank", "@XmlPhysicalMandateData", "@XmlEMandateData", "@XmlAadharMandateData", "@XmlDirectDebitMandateData", "@XmlDebitPresentationData", "@XmlUPICollectionData", "@XmlBBPSData", "@XmlAPBSData", "@AppId", "@EntityId","@UserId", "BindPSM",SaveRequest.BankId, SaveRequest.SubMemberId, @XmlPhysicalMandateData, @XmlEMandateData, @XmlAadharMandateData, @XmlDirectDebitMandateData, @XmlDebitPresentationData, @XmlUPICollectionData, @XmlBBPSData, @XmlAPBSData, SaveRequest.UtilityCode, SaveRequest.UtilityCode, Dbsecurity.Decrypt(SaveRequest.UtilityCode), Dbsecurity.Decrypt(SaveRequest.EntityId), Dbsecurity.Decrypt(HttpContext.Current.Server.UrlDecode(SaveRequest.UserId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

    }
}
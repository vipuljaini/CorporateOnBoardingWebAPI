﻿using BusinessLibrary;
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

                if (SaveRequest.BillingContactPerson != "")
                { @XmlBilling_OtherDetailsData += " BillingContactPerson=" + @"""" + SaveRequest.BillingContactPerson + @""""; }
                else { @XmlBilling_OtherDetailsData += " BillingContactPerson=" + @"""" + "" + @""""; }

                if (SaveRequest.BillingDesignation != "")
                { @XmlBilling_OtherDetailsData += " BillingDesignation=" + @"""" + SaveRequest.BillingDesignation + @""""; }
                else { @XmlBilling_OtherDetailsData += " BillingDesignation=" + @"""" + "" + @""""; }

                if (SaveRequest.BillingContactNo != "")
                { @XmlBilling_OtherDetailsData += " BillingContactNo=" + @"""" + SaveRequest.BillingContactNo + @""""; }
                else { @XmlBilling_OtherDetailsData += " BillingContactNo=" + @"""" + "" + @""""; }

                if (SaveRequest.BillingFaxNo != "")
                { @XmlBilling_OtherDetailsData += " BillingFaxNo=" + @"""" + SaveRequest.BillingFaxNo + @""""; }
                else { @XmlBilling_OtherDetailsData += " BillingFaxNo=" + @"""" + "" + @""""; }
              
                if (SaveRequest.BillingAddress != "")
                { @XmlBilling_OtherDetailsData += " BillingAddress=" + @"""" + SaveRequest.BillingAddress + @""""; }
                else { @XmlBilling_OtherDetailsData += " BillingAddress=" + @"""" + "" + @""""; }

                if (SaveRequest.PickupContactPerson != "")
                { @XmlBilling_OtherDetailsData += " PickupContactPerson=" + @"""" + SaveRequest.PickupContactPerson + @""""; }
                else { @XmlBilling_OtherDetailsData += " PickupContactPerson=" + @"""" + "" + @""""; }

                if (SaveRequest.PickupLocationAddress != "")
                { @XmlBilling_OtherDetailsData += " PickupLocationAddress=" + @"""" + SaveRequest.PickupLocationAddress + @""""; }
                else { @XmlBilling_OtherDetailsData += " PickupLocationAddress=" + @"""" + "" + @""""; }

                if (SaveRequest.ddlArrangmentDays != "")
                { @XmlBilling_OtherDetailsData += " ddlArrangmentDays=" + @"""" + SaveRequest.ddlArrangmentDays + @""""; }
                else { @XmlBilling_OtherDetailsData += " ddlArrangmentDays=" + @"""" + "" + @""""; }

                if (SaveRequest.CommMail_Primary != "")
                { @XmlBilling_OtherDetailsData += " CommMail_Primary=" + @"""" + SaveRequest.CommMail_Primary + @""""; }
                else { @XmlBilling_OtherDetailsData += " CommMail_Primary=" + @"""" + "" + @""""; }

                if (SaveRequest.CommMail_Billing != "")
                { @XmlBilling_OtherDetailsData += " CommMail_Billing=" + @"""" + SaveRequest.CommMail_Billing + @""""; }
                else { @XmlBilling_OtherDetailsData += " CommMail_Billing=" + @"""" + "" + @""""; }

                if (SaveRequest.ChargeDebitAccNo != "")
                { @XmlBilling_OtherDetailsData += " ChargeDebitAccNo=" + @"""" + SaveRequest.ChargeDebitAccNo + @""""; }
                else { @XmlBilling_OtherDetailsData += " ChargeDebitAccNo=" + @"""" + "" + @""""; }

                if (SaveRequest.BankCorpID != "")
                { @XmlBilling_OtherDetailsData += " BankCorpID=" + @"""" + SaveRequest.BankCorpID + @""""; }
                else { @XmlBilling_OtherDetailsData += " BankCorpID=" + @"""" + "" + @""""; }

                if (SaveRequest.BranchName != "")
                { @XmlBilling_OtherDetailsData += " BranchName=" + @"""" + SaveRequest.BranchName + @""""; }
                else { @XmlBilling_OtherDetailsData += " BranchName=" + @"""" + "" + @""""; }

                if (SaveRequest.BranchCode != "")
                { @XmlBilling_OtherDetailsData += " BranchCode=" + @"""" + SaveRequest.BranchCode + @""""; }
                else { @XmlBilling_OtherDetailsData += " BranchCode=" + @"""" + "" + @""""; }

                if (SaveRequest.IFSC != "")
                { @XmlBilling_OtherDetailsData += " IFSC=" + @"""" + SaveRequest.IFSC + @""""; }
                else { @XmlBilling_OtherDetailsData += " IFSC=" + @"""" + "" + @""""; }

                if (SaveRequest.Settlement != "")
                { @XmlBilling_OtherDetailsData += " Settlement=" + @"""" + SaveRequest.Settlement + @""""; }
                else { @XmlBilling_OtherDetailsData += " Settlement=" + @"""" + "" + @""""; }

                @XmlBilling_OtherDetailsData += " />";
                @XmlBilling_OtherDetailsData += "</dtXml>";

                //---- End Save Billing/Other Details XML Code -------------//


                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_CorporateOnBoarding]").With<Country>().Execute("@QueryType", "@BankID", "@SubMemberBank", "@XmlPhysicalMandateData", "@XmlEMandateData", "@XmlAadharMandateData", "@XmlDirectDebitMandateData", "@XmlDebitPresentationData", "@XmlUPICollectionData", "@XmlBBPSData", "@XmlAPBSData", "@XmlBilling_OtherDetailsData", "@AppId", "@EntityId", "@UserId", "SaveData", "1", "2", @XmlPhysicalMandateData, @XmlEMandateData, @XmlAadharMandateData, @XmlDirectDebitMandateData, @XmlDebitPresentationData, @XmlUPICollectionData, @XmlBBPSData, @XmlAPBSData, @XmlBilling_OtherDetailsData, "123456", "2", "2"));
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
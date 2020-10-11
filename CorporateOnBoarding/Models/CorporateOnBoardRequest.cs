using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorporateOnBoarding.Models
{
    public class CorporateOnBoardRequest
    {
    }
    public class PSMRequest
    {
        public string AppId { get; set; }
        public string UserId { get; set; }
        public string EntityId { get; set; }
        public string BankId { get; set; }
        public string SubMemberId { get; set; }
        public string TCEDID { get; set; }
    }

    public class Success
    {
        public Nullable<Int32> Result { get; set; }

    }
    public class BindBank
    {
        public Nullable<double> BankId { get; set; }
        public string BankName { get; set; }

    }
    public class BindBusinessSegmentCode
    {
        public Nullable<Int32> BusinessSegmentCodeId { get; set; }
        public string BusinessSegmentCodeName { get; set; }

    }
    public class BindSettlement
    {
        public Nullable<Int32> SettlementId { get; set; }
        public string SettlementName { get; set; }

    }

    public class BindAllCorporateGrid
    {
        public Nullable<Int64> TCEDID { get; set; }
        public string BankName { get; set; }
        public string SubBankName { get; set; }
        public string CustomerName { get; set; }
        public string UtilityCode { get; set; }
        public string CustomerAddress { get; set; }
        public string RMName { get; set; }
        public string BusinessSegmentcode { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonDesg { get; set; }
        public string ContactNo { get; set; }
    }

    public class DataSaveRequest
    {
        public string AppId { get; set; }
        public string UserId { get; set; }
        public string EntityId { get; set; }

        public string BankId { get; set; }
        public string BusinessSegmentCode { get; set; }
        public string SubMemberId { get; set; }
        public string txtCustomerName { get; set; }
        public string txtUtilityCode { get; set; }
        public string txtCustomerAddress { get; set; }
        public string ddlCity { get; set; }
        public string ddlState { get; set; }
        public string ddlCountry { get; set; }
        public string ddlPSM { get; set; }
        public string txtContactPerson1 { get; set; }
        public string txtContactPersonDesignation { get; set; }
        public string txtContactNo { get; set; }
        public string txtFAX { get; set; }
        public string txtArrangement { get; set; }
        public string txtPickUpPoint { get; set; }
        public string txtLocation { get; set; }
        public string txtContactPerson2 { get; set; }
        public string txtContactPersonName { get; set; }
        public string txtCustomerEmail { get; set; }
        public string txtTAN { get; set; }
        public string txtGST { get; set; }
        public string ddlAHPSM { get; set; }
        public string ddlAHRM { get; set; }
        public string txtPAN { get; set; }
        public List<ContactPersonArray> ContactPersonArray { get; set; }

        //---- Save Service Offered Fields -------------//
        public string ddlPhysicalMandate { get; set; }
        public string ddlEMandate { get; set; }
        public string ddlAadharMandate { get; set; }
        public string ddlDirectDebitMandate { get; set; }
        public string ddlDebitPresentation { get; set; }
        public string ddlUPICollection { get; set; }
        public string ddlBBPS { get; set; }
        public string ddlAPBS { get; set; }
        public string PMPerTransCharge { get; set; }
        public string PMSetupInteCharge { get; set; }
        public string PMUserIdChargePerMonth { get; set; }
        public string PMTrainningCharge { get; set; }
        public string PMAnnualMaintenance { get; set; }
        public string EMPerTransCharge { get; set; }
        public string EMSetupInteCharge { get; set; }
        public string EMUserIdChargePerMonth { get; set; }
        public string EMTrainningCharge { get; set; }
        public string EMAnnualMaintenance { get; set; }
        public string DDMPerTransCharge { get; set; }
        public string DDMSetupInteCharge { get; set; }
        public string DDMUserIdChargePerMonth { get; set; }
        public string DDMTrainningCharge { get; set; }
        public string DDMAnnualMaintenance { get; set; }
        public string ABMPerTransCharge { get; set; }
        public string ABMSetupInteCharge { get; set; }
        public string ABMUserIdChargePerMonth { get; set; }
        public string ABMTrainningCharge { get; set; }
        public string ABMAnnualMaintenance { get; set; }
        public string NTPPerTransCharge { get; set; }
        public string NTPSetupInteCharge { get; set; }
        public string NTPUserIdChargePerMonth { get; set; }
        public string NTPTrainningCharge { get; set; }
        public string NTPAnnualMaintenance { get; set; }
        public string UCPerTransCharge { get; set; }
        public string UCSetupInteCharge { get; set; }
        public string UCUserIdChargePerMonth { get; set; }
        public string UCTrainningCharge { get; set; }
        public string UCAnnualMaintenance { get; set; }
        public string BBPerTransCharge { get; set; }
        public string BBSetupInteCharge { get; set; }
        public string BBUserIdChargePerMonth { get; set; }
        public string BBTrainningCharge { get; set; }
        public string BBAnnualMaintenance { get; set; }
        public string APPerTransCharge { get; set; }
        public string APSetupInteCharge { get; set; }
        public string APUserIdChargePerMonth { get; set; }
        public string APTrainningCharge { get; set; }
        public string APAnnualMaintenance { get; set; }

        //---- End Save Billing/Other Details Fields -------------//

        //---- Save Billing/Other Details Fields -------------//
        public string BillingContactPerson { get; set; }
        public string BillingDesignation { get; set; }
        public string BillingContactNo { get; set; }
        public string BillingFaxNo { get; set; }
        public string BillingAddress { get; set; }
        public string PickupContactPerson { get; set; }
        public string PickupLocationAddress { get; set; }
        public string ddlArrangmentDays { get; set; }
        public string CommMail_Primary { get; set; }
        public string CommMail_Billing { get; set; }
        public string ChargeDebitAccNo { get; set; }
        public string BankCorpID { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string IFSC { get; set; }
        public string Settlement { get; set; }

        //---- End Save Billing/Other Details Fields -------------//


    }
    public class ContactPersonArray
    {
        public string ContactPesonName { get; set; }
        public string ContactPesonDesignation { get; set; }
        public string ContactPesonContact { get; set; }
        public string ContactPesonFax { get; set; }
        public string ContactPesonAddress { get; set; }
    }

    public class ServiceOfferedFields
    {
        public Nullable<Boolean> IsPhysicalMandate { get; set; }
        public Nullable<Boolean> IsEMandate { get; set; }
        public Nullable<Boolean> IsAadharBasedMandate { get; set; }
        public Nullable<Boolean> IsDirectDebitMandate { get; set; }
        public Nullable<Boolean> IsNACHTransPresent { get; set; }
        public Nullable<Boolean> IsUPICollection { get; set; }
        public Nullable<Boolean> IsBBPS { get; set; }
        public Nullable<Boolean> IsAPBS { get; set; }
        public Nullable<decimal> PerTransCharge { get; set; }
        public Nullable<decimal> Setup_IntegrationCharge { get; set; }
        public Nullable<decimal> UserIdChargePerMonth { get; set; }
        public Nullable<decimal> TrainingCharge { get; set; }
        public Nullable<decimal> AnnualMaintenance { get; set; }
    }

    public class Billing_OtherDetailsFields
    {
        public string BillingContactPerson { get; set; }
        public string BillingDesignation { get; set; }
        public string BillingContactNo { get; set; }
        public string BillingFaxNo { get; set; }
        public string BillingAddress { get; set; }
        public string PickupContactPerson { get; set; }
        public string PickupLocationAddress { get; set; }
        public Nullable<Int32> ArrangmentDays { get; set; }
        public string CommuMail_Primary { get; set; }
        public string CommuMail_Billing { get; set; }
        public string ChargeDebitAccNo { get; set; }
        public string BankCorpID { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string IFSC { get; set; }
        public Nullable<Int64> Settlement { get; set; }
    }
}






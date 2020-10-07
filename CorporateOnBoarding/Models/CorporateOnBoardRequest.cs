﻿using System;
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
    }

    public class DataSaveRequest
    {
        //public string AppId { get; set; }
        public string UserId { get; set; }
        public string EntityId { get; set; }
        public string BankId { get; set; }
        public string SubMemberId { get; set; }
        public string CustomerName { get; set; }
        public string UtilityCode { get; set; }
        public string CustomerAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PSMName { get; set; }
        public string ContactPersonFirst { get; set; }
        public string ContactPersonDesignation { get; set; }
        public string ContactNo { get; set; }
        public string FAX { get; set; }
        public string Arrangement { get; set; }
        public string PickUpPoint { get; set; }
        public string Location { get; set; }
        public string ContactPersonSecond { get; set; }
        public string ContactPersonName { get; set; }
        public string CustomerEmail { get; set; }

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
}
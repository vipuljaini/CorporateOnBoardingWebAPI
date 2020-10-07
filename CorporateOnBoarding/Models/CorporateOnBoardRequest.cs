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
    }

    public class DataSaveRequest
    {
        //public string AppId { get; set; }
        public string UserId { get; set; }
        public string EntityId { get; set; }
        //public string BankId { get; set; }
       // public string SubMemberId { get; set; }
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

    }
}
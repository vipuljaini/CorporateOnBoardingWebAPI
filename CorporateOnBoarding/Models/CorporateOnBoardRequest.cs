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
    }
}
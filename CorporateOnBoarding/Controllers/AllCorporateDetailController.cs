using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLibrary;
using CorporateOnBoarding.Models;
using EntityDAL;

namespace CorporateOnBoarding.Controllers
{
    public class AllCorporateDetailController : ApiController
    {
        QuickCheck_AngularEntities1 context = new QuickCheck_AngularEntities1();
        DataAccessLayer objCorporateOnBoarding = new DataAccessLayer();
        DataTable dt = new DataTable();

        [HttpGet]
        [Route("api/CorporateOnBoarding/BindCountry")]
        public Dictionary<string, object> BindCountry()
        {
             return objCorporateOnBoarding.BindCountry();

        }

        [HttpGet]
        [Route("api/CorporateOnBoarding/BindState/{CountryID}")]
        public Dictionary<string, object> BindState(string CountryID)
        {
            return objCorporateOnBoarding.BindState(CountryID);

        }


        [HttpGet]
        [Route("api/CorporateOnBoarding/BindCity/{CountryID}/{StateID}")]
        public Dictionary<string, object> BindCity(string CountryID,string StateID)
        {
            return objCorporateOnBoarding.BindCity(CountryID, StateID);

        }


        [HttpPost]
        [Route("api/CorporateOnBoarding/BindPSM")]
        public Dictionary<string, object> BindPSM([FromBody] PSMRequest bindPSMDropdown)
        {
            return objCorporateOnBoarding.BindPSM(bindPSMDropdown);

        }


        [HttpPost]
        [Route("api/CorporateOnBoarding/BindRM")]
        public Dictionary<string, object> BindRM([FromBody] PSMRequest bindRMDropdown)
        {
            return objCorporateOnBoarding.BindRM(bindRMDropdown);

        }


        [HttpPost]
        [Route("api/CorporateOnBoarding/BindRegionalManager")]
        public Dictionary<string, object> BindRegionalManager([FromBody] PSMRequest bindRegionalManagerDropdown)
        {
            return objCorporateOnBoarding.BindRegionalManager(bindRegionalManagerDropdown);

        }


        [HttpPost]
        [Route("api/CorporateOnBoarding/SaveData")]
        public Dictionary<string, object> SaveData([FromBody] DataSaveRequest SaveRequest)
        {
            return objCorporateOnBoarding.SaveData(SaveRequest);

        }

        [HttpPost]
        [Route("api/CorporateOnBoarding/BindAllCorporateGrid")]
        public Dictionary<string, object> BindAllCorporateGrid([FromBody] PSMRequest Data)
        {
            return objCorporateOnBoarding.BindAllCorporateGrid(Data);

        }

    }
}

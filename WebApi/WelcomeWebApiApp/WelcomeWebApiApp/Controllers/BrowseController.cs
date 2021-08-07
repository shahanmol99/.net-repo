using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WelcomeWebApiApp.Controllers
{
    [RoutePrefix("api/v1/aurionpro")]
    public class BrowseController : ApiController
    {
        [Route("CompanyInformation")]
        public IHttpActionResult GetCompanyInfo()
        {
            Random random = new Random();
            int no = random.Next(1, 10);

            if (no > 5)
            {
                return Ok(new
                {
                    compnay = "AurionPro",
                    Loc = "Mumbai"
                });
            }
            return InternalServerError();
            //return BadRequest("No company found");
        }
    }
}
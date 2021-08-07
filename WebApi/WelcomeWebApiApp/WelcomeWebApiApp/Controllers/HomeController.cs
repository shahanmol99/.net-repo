using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WelcomeWebApiApp.Controllers
{
  //[RoutePrefix("api/v1/aurionpro")]
    public class HomeController : ApiController
    {
        //[Route("CompanyInformation")]
        //public IHttpActionResult GetCompanyInfo()
        //{
        //    Random random = new Random();
        //    int no = random.Next(1, 10);

        //    if(no>5)
        //    {
        //        return Ok(new
        //        {
        //            compnay = "AurionPro",
        //            Loc = "Mumbai"
        //        });
        //    }
            //return InternalServerError();
            //return BadRequest("No company found");
        //}
        public IHttpActionResult Get()
        {
            return Json("Get Called");
        }

        public IHttpActionResult Post()
        {
            return Json("Post Called");
        }

        public IHttpActionResult Put()
        {
            return Json("Put Called");
        }

        public IHttpActionResult Delete()
        {
            return Json("Delete Called");
        }
    }
}
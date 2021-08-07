using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ExhibitionLib.Service;
using ExhibitionLib.Model;
using System.Net;

namespace ExhibitionApi.Controllers
{
    [RoutePrefix("api/v1/organizer")]
    public class ExhibitionController : ApiController
    {
        ExhibitionService _service;

        public ExhibitionController()
        {
            _service = new ExhibitionService();
        }

        [Route("{organizerid}/exhibitions")]
        public IHttpActionResult Get(string organizerId)
        {
            var exhibitionList = _service.GetExhibitionsByOrganizerId(organizerId);
             if(exhibitionList==null)
            {
                return BadRequest(HttpStatusCode.NotFound + " No Data Found");
            }

            HttpStatusCode status = (HttpStatusCode)999;
            return Content(status, exhibitionList);
        }

        [Route("{organizerid}/exhibitions/{exhibitionId}")]
        public IHttpActionResult Get(string organizerid, string exhibitionId)
        {
            var exhibition = _service.GetExhibitionByExhibitionId(organizerid, exhibitionId);

            if (exhibition == null)
            {
                return BadRequest(HttpStatusCode.NotFound + " No Data Found");
            }

            return Ok(exhibition);
        }

    }
}
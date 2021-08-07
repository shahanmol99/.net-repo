using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using StudentLib.Model;
using StudentLib.Service;
using StudentWebApiApp.Models;

namespace StudentWebApiApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/v1/Students")]
    public class StudentController : ApiController
    {
        // GET: Student
        IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [Route("")]
        public IHttpActionResult Get()
        {
            return Json(_service.GetListOfStudents());
        }

        [Route("{id}")]
        public IHttpActionResult Get(string id)
        {
            return Json(_service.GetStudent(id));
        }

        [Route("")]
        public IHttpActionResult Post(Student student)
        {
            student.Id = Guid.NewGuid().ToString();
            
            _service.AddStudent(student);
            return Ok(student.Id);
        }

        [Route("{id}")]
        public IHttpActionResult Put(string id, Student stud)
        {
            var student = _service.GetStudent(id);
            if (student == null)
            {
                return BadRequest(HttpStatusCode.NotFound + " Employee with id = " + id + " Not Fouund");
            }

            _service.UpdateStudent(stud);
            return Ok("Student Updated Successfully");
        }

        [Route("{id}")]
        public IHttpActionResult Delete(string id)
        {
            var student = _service.GetStudent(id);
            if(student==null)
            {
                return BadRequest(HttpStatusCode.NotFound + " Employee with id = " + id + " Not Fouund");
            }

            _service.DeleteStudent(student);
            return Ok("Student Deleted Successfully " + id);
        }
    }
}
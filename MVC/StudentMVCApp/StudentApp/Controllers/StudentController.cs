using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentLib.Service;
using StudentLib.Model;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }
        

        [HttpGet]
        public ActionResult Display()
        {
            List<Student> students = _service.GetStudents();
            return View(students);
        }

        [HttpPost]
        public ActionResult Update(Student student)
        {
            return View(new UpdateStudentModel { ID = student.ID, Name = student.Name, RollNo = student.RollNo, Cgpa = student.CGPA});
        }
        
        [HttpPost]
        public ActionResult UpdateDetails(UpdateStudentModel vm)
        {
            string id = vm.ID;
            Student student = new Student { ID = vm.ID, Name = vm.Name, RollNo = vm.RollNo, CGPA = vm.Cgpa };
            _service.UpdateStudentDetails(student);
            return RedirectToAction("Display");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(new AddStudentModel());
        }

        [HttpPost]
        public ActionResult Add(AddStudentModel vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }

            Student student = new Student { RollNo = vm.RollNo, Name = vm.Name, CGPA = vm.Cgpa };
            _service.AddStudents(student);
            return RedirectToAction("Display");
        }
    }
}
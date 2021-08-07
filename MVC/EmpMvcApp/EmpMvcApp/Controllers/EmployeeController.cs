using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmpLib.Service;
using EmpLib.Model;
using EmpMvcApp.Models;

namespace EmpMvcApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            EmpAndDeptViewModel vm = new EmpAndDeptViewModel();
            vm.dept = _service.GetListOfDept();
            Session["dept"] = new SelectList(_service.GetListOfDept(), "DEPTNO", "DNAME");
            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(EmpAndDeptViewModel vm)
        {
            //int deptNo = Convert.ToInt32(Request.Form["Department"]);
            vm.dept = _service.GetListOfDept();
            vm.emps = _service.GetListOfEmployess(Convert.ToInt32(vm.deptNo));
            return View(vm);
        }
    }
}
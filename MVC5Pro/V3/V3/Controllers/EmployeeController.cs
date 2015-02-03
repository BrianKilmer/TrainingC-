using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using V3.Models;
using BusinessLayer;

namespace V3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details2(int id)
        {
            V3.Models.Employee employee = new V3.Models.Employee()
            {
                id = 1,
                NameFirst = "john",
                gender = "male",
                city = "san diego",
            };
            return View(employee);
        }
        //--------------------------------------------------------------------------
        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            //Employees = property set up in EmployeeContext
            V3.Models.Employee employee = employeeContext.Employees.Single(emp => emp.id == id);

            return View(employee);
        }
        //--------------------------------------------------------------------------
        public ActionResult Index(int id)
        {
            // establish connnection to db
            EmployeeContext employeeContext = new EmployeeContext();
            //List<Employee> employees = EmployeeContext.Employees.ToList();
            List<V3.Models.Employee> employees = employeeContext.Employees.Where(emp => emp.DepartmentID == id).ToList();
            return View(employees);
        }
        //--------------------------------------------------------------------------
        public ActionResult IndexBL()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            // store in a varible of type List Empoyee   from the business layer retreiving the busines property that gets a list of emplyees from a ado call and sproc
            List<BusinessLayer.Employee> employee = employeeBusinessLayer.Employees.ToList();

            return View(employee);
        }
        //--------------------------------------------------------------------------
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            
            BusinessLayer.Employee employee = new BusinessLayer.Employee();
            // bind the 'post' form data with the object
            // UpdateModel function inspects all the httpRequest inputs -
            // FormData, QueryString, cookies, server variables, and populates the employee object
            UpdateModel(employee);

            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                // method AddEmployee in employeeBusinessLayer
                employeeBusinessLayer.AddEmployee(employee);
                return RedirectToAction("IndexBL");
            }
            return View();
        }
    }
}
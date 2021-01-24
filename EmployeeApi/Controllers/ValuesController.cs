using EmployeeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace EmployeeApi.Controllers
{
    public class ValuesController : ApiController
    {
        public List<Employee> lst = new List<Employee>();

        // GET api/values
        public List<Employee> Get()
        {
            EmployeeDetails();
            return lst;
        }

        // GET api/values/5
        public Employee Get(string id)
        {
            EmployeeDetails();
            return lst.Where(x => x.EmpId == id).FirstOrDefault();
        }

        // POST api/values
        public HttpResponseMessage Post([FromBody] Employee value)
        {
            lst.Add(value);
            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // PUT api/values/5
        public IHttpActionResult Put(string id, [FromBody]Employee value)
        {
            EmployeeDetails();
            var emp = lst.FirstOrDefault(x => x.EmpId == id);
            emp.EmpId = value.EmpId;
            emp.EmpYears = value.EmpYears;
            emp.Name = value.Name;

            //lst.Remove(lst.Where(x => x.EmpId == id).First());
            //lst.Add(emp);
            return Ok();
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(string id)
        {
            lst.Remove(lst.Where(x => x.EmpId == id).First());
            return Ok();
        }

        public void EmployeeDetails()
        
        {
            if (lst.Count > 0) return;
            Employee emp = new Employee
            {
                EmpId = "1", EmpYears = "2", IsFullTime = true, Name = "Virat"
            };
            Employee emp2 = new Employee
            {
                EmpId = "2", EmpYears = "8", IsFullTime = true, Name = "Dhoni"
            };
             Employee emp3 = new Employee
            {
                EmpId = "3", EmpYears = "2", IsFullTime = true, Name = "Yuvaraj"
            };
             Employee emp4 = new Employee
            {
                EmpId = "4", EmpYears = "85", IsFullTime = true, Name = "Mohan"
            };
             Employee emp5 = new Employee
            {
                EmpId = "5", EmpYears = "76", IsFullTime = true, Name = "Gayle"
            };
            lst.Add(emp);
            lst.Add(emp2);
            lst.Add(emp3);
            lst.Add(emp4);
            lst.Add(emp5);
            return;
        }
    }
}

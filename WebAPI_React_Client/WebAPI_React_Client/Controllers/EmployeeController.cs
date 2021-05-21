using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPI_React_Client.Models;

namespace WebAPI_React_Client.Controllers
{
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
        public List<Employee> GetAll()
        {
            List <Employee> emplist = new List<Employee>
            {
                 new Employee{Id=101,name="Ashane",location="Galle",salary=120000},

                new Employee{Id=102,name="Jason",location="England",salary=230000},

                new Employee{Id=103,name="Shane",location="USA",salary=34000},

                new Employee{Id=104,name="Prasad",location="Colombo",salary=45000},

                new Employee{Id=105,name="Jay",location="Mumbai",salary=56000}
            };
            return emplist;
        }
    }
}

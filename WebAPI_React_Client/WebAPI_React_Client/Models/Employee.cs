using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_React_Client.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string location { get; set; }

        public int salary { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => $" ID: {ID}  |  {Title} {LastName} {FirstName}"; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DepartmentCode { get; set; }
    }
}

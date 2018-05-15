using SampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleAPI.DAL
{
    public class EmplyeeRepository
    {
        public List<Employee> GetEmployee()
        {
            EmployeeEntities entities = new EmployeeEntities();

            return entities.Employees.ToList();
        }
    }
}
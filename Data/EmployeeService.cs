using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class EmployeeService
    {
        public  List<Employee> GetEmployeeData()
        {
            List<Employee> listOfEmployee = new List<Employee>()
            {
                new Employee() {Id = 1, Score = 140, Title = "Group1"},
                new Employee() {Id = 2, Score = 120, Title = "Group2"},
                new Employee() {Id = 3, Score = 60, Title = "Group3"},
            };

            return listOfEmployee;
        }
    }
}
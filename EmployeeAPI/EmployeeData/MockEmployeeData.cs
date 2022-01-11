using EmployeeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeAPI.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Zolile Sigabi"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Aliziwe Mahono"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Naleli Kuena"
            },
            new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Simthembile Sigabi"
            }
        };

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            employees.Add(employee);
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = GetEmployee(employee.Id);

            existingEmployee.Name = employee.Name;

            return existingEmployee;
        }

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(x => x.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}

namespace EmployeeAPI.EmployeeData
{
    using EmployeeAPI.Model;
    using System;
    using System.Collections.Generic;

    public interface IEmployeeData
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee employee);

        Employee EditEmployee(Employee employee);
    }
}

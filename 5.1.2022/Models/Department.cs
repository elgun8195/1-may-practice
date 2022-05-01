using _5._1._2022.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1._2022.Models
{
    class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }

        Employee[] employees = new Employee[0];

        public Department(string name, int employeLimit)
        {
            Name = name;
            EmployeeLimit = employeLimit;
        }

        public void AddEmployee(Employee employee)
        {
            if (employees.Length <= EmployeeLimit)
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
            }
            else
            {
                throw new CapacityLimitException("Limit Asildi");

            }

        }

        public Employee this[int i]
        {
            get
            {
                if (i < employees.Length)
                {
                    return employees[i];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i < employees.Length)
                {
                    employees[i] = value;
                    return;
                }
                throw new IndexOutOfRangeException();
            }
        }
    }
}

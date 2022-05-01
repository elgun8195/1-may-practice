using _5._1._2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5._1._2022.Models
{
    class Employee : IPerson
    {
        private static int _id;
        private int _age;
        private double _salary;

        public int Id { get; }
        public string Name { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value <= 100)
                {
                     _age=value;
                }
            }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                {
                    _salary=value;
                }
            }
        }

        public Employee(int age, string name, double salary)
        {
            Id = ++_id;
            Name = name;
            Salary = salary;
            Age = age;
        }


        public string ShowInfo()
        {
            return $"{Id} - {Name} - {Age} - {Salary}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }
    }
}

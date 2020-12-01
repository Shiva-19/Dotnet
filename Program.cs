using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee o1 = new Employee("Amol", 123465, 10);
            Console.WriteLine("all accepted");

            Employee o2 = new Employee("Amol", 123465);
            Console.WriteLine("dept");

            Employee o3 = new Employee("Amol");
            Console.WriteLine("dept and Basics");

            Employee o4 = new Employee();
            Console.WriteLine("none");

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine("empno");
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);

            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
        }
    }

    class Employee
    {
        private string name;
        public string Name
        {
            set
            {
                if (value != null)
                    name = value;
                else
                    Console.WriteLine("Name should not be null");
            }
            get
            {
                return name;
            }
        }
        private static int Empnoc = 0;
        private int empno;
        public int EmpNo
        {
            set
            {

            }
            get
            {
                return empno;
            }
        }
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 10000 && value < 50000)
                    basic = value;
                else
                    Console.WriteLine("out of range");
            }
            get
            {
                return basic;
            }
        }
        private short deptno;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptno = value;
                else
                    Console.WriteLine("invalid");
            }
            get
            {
                return deptno;
            }
        }
        public decimal GetNetSalary()
        {
            decimal salary;
            salary = Basic + Basic * 10;
            return salary;
        }
        public Employee(string name = null, decimal basic = 0, short deptno = 0)
        {
            Empnoc++;
            empno = Empnoc;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptno;
        }


    }
}

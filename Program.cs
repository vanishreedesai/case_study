using System;
using System.IO;

namespace Practical
{
    public abstract class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public int Basic_Pay { get; set; }

        //Employee constructor
        public Employee(int eid, string ename, string addr, int pay)
        {
            EmpId = eid;
            EmpName = ename;
            Address = addr;
            Basic_Pay = pay;
        }

        //overriding tostring method
        public override string ToString()
        {
            return ("Employee ID is " + EmpId + " and Name is " + EmpName);
        }

        //abstract method for calculation of salary
        public abstract double calculate_salary();
    }

    //public class for technical employees 
    public class Technical_Employee : Employee
    {
        string[] technical_skills;

        public Technical_Employee(int eid, string ename, string addr, int pay, string[] skills) : base(eid, ename, addr, pay)
        {
            technical_skills = skills;
        } // constructor along with the skills each employee has 

        //overriding tostring method to display employee name and ID
        public override string ToString()
        {
            return this.EmpId + " " + this.EmpName;
        }

        //implementing function defined in abstract class to calculate salary of technical employees
        public override double calculate_salary()
        {
            double HRA;
            double salary;
            HRA = 0.12 * Basic_Pay;      //calculation of HRA
            salary = Basic_Pay + HRA;
            return salary;
        }
    }

    //class for staff
    public class Staff : Employee
    {
        string[] title;

        public Staff(int eid, string ename, string addr, int pay, string[] staff_title) : base(eid, ename, addr, pay)
        {
            title = staff_title;
        }//constructor along with the job title of staff

        //overriding tostring method to display name and ID of staff member
        public override string ToString()
        {
            return this.EmpId + " " + this.EmpName;
        }

        //implementing function defined in abstract class to calculate salary of staff members
        public override double calculate_salary()
        {
            double HRA;
            double salary;
            HRA = 0.18 * Basic_Pay;   //calculation of HRA
            salary = Basic_Pay + HRA;
            return salary;
        }
    }

    class UsingPeople
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Employee ID and Name of Technical Employee");
                Technical_Employee emp = new Technical_Employee(1, "Vani", "Bangalore", 2000, new string[] { "java", "python" });

                Console.WriteLine(emp.ToString());
                var sal = emp.calculate_salary();
                Console.WriteLine("The salary of Technical Employee is:{0}", sal);
                Console.ReadLine();

                Console.WriteLine("Employee ID and Name of staff :");
                Staff staf = new Staff(1, "Ganga", "Mysore", 20000, new string[] { "House Keeping", "Security" });
                Console.WriteLine(staf.ToString());
                sal = staf.calculate_salary();
                Console.WriteLine("The salary of staff is:{0}", sal);
                Console.ReadLine();

            }
            
            catch (Exception) //to handle any exception
            {
                Console.WriteLine("Try again later");
                Console.ReadLine();
            }
        }
    }
}

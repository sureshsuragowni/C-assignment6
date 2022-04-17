using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeedelagates
{ /*UniCast Delegate*/
    public delegate void EmployeeDelegate();
    public class UniCastDelegate
    {

        static void Main(string[] args)
        {
            Manager employee = new Manager();


            EmployeeDelegate employeeDelegate = new EmployeeDelegate(employee.Display);


            employeeDelegate.Invoke();


        }
    }
    public class Manager
    {
        private int empId;
        private string empName;
        private string companyName;
        private string designation;
        private string workLocation;



        public Manager()
        {
            Console.Write("Enter the Manager id : ");
            this.empId = (Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter the Manager name : ");
            this.empName = Console.ReadLine();

            Console.Write("Enter the Company Name : ");
            this.companyName = Console.ReadLine();

            Console.Write("Enter the Manager designation : ");
            this.designation = Console.ReadLine();

            Console.Write("Enter the Manager WorkLocation : ");
            this.workLocation = Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------------------------");

        }

        public void Display()
        {
            Console.WriteLine("Display the manager details.....");
            Console.WriteLine("Manager Id : {0}", empId);
            Console.WriteLine("Manager Name : {0}", empName);
            Console.WriteLine("Manager Company Name : {0}", companyName);

            Console.WriteLine("Manager Designation : {0}", designation);

            Console.WriteLine("Manager Work Location : {0}", workLocation);
        }



    }
}

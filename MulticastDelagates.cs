using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeedelegates
{ /*Multicaste Delegate*/
    public delegate void EmployeeDelegate();
    public class MultiCastDelegate
    {

        static void Main(string[] args)
        {
            Manager employee = new Manager();


            EmployeeDelegate employeeDelegate = new EmployeeDelegate(employee.Display);
            employeeDelegate += employee.MarketingExecutiveDisplay;


            employeeDelegate.Invoke();


        }
    }
    public class Manager
    {
        private int empId, meId;
        private string empName, meName;
        private string companyName, meCompanyName;
        private string designation, meDesignation;
        private string workLocation, meWorkLocation;



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

            Console.WriteLine("-------------------------------------------------------------------------");

            Console.Write("Enter the MarketingExecutive id : ");
            this.meId = (Convert.ToInt32(Console.ReadLine()));

            Console.Write("Enter the MarketingExecutive name : ");
            this.meName = Console.ReadLine();

            Console.Write("Enter the MarketingExecutive Company Name : ");
            this.meCompanyName = Console.ReadLine();

            Console.Write("Enter the MarketingExecutive designation : ");
            this.meDesignation = Console.ReadLine();

            Console.Write("Enter the MarketingExecutive WorkLocation : ");
            this.meWorkLocation = Console.ReadLine();

        }

        public void Display()
        {
            
            Console.WriteLine("Manager Id : {0}", empId);
            Console.WriteLine("Manager Name : {0}", empName);
            Console.WriteLine("Manager Company Name : {0}", companyName);

            Console.WriteLine("Manager Designation : {0}", designation);

            Console.WriteLine("Manager Work Location : {0}", workLocation);

            Console.WriteLine("--------------------------------------------------------------------");
        }

        public void MarketingExecutiveDisplay()
        {
            Console.WriteLine("MarketingExecutiveDetails:::::::::");
            Console.WriteLine("MarketingExecutive Employee Id : {0}", meId);
            Console.WriteLine("MarketingExecutive Employee Name : {0}", meName);
            Console.WriteLine("MarketingExecutive Employee Company Name : {0}", meCompanyName);

            Console.WriteLine("MarketingExecutive Employee Designation : {0}", meDesignation);

            Console.WriteLine("MarketingExecutive Employee Work Location : {0}", meWorkLocation);
        }


    }
}
using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment3
{
    class EmployeeDetails
    {
        public int id;
        public string qualification, name;
        
        public void Emp() {
            
        }

       public void display()
        {
            Console.WriteLine("EmployeeId:"+id);
            Console.WriteLine("EmployeeName:" + name);
            Console.WriteLine( "EmployeeQualification:"+qualification );
            if(qualification=="BE"|| qualification == "BCA"||qualification == "BSC")
                Console.WriteLine("Employee under IT department");
            else if (qualification == "BCom" || qualification == "MCom" || qualification == "CA")
                Console.WriteLine("Employee under Accounts department");
            Console.ReadKey();
        }
    }
}

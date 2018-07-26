using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

using System.Threading.Tasks;


namespace Assignment3
{
    class NullException : Exception{
        public NullException(string message) : base(message)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string directory = "C://Users//HP//Desktop//logs.txt";

             EmployeeDetails e = new EmployeeDetails();
            List<EmployeeDetails> emp = new List<EmployeeDetails>();
            while(true)
            {
                Console.WriteLine("1. Enter details \n 2.Stop");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter employee Id:");
                            e.id = int.Parse(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Enter employee Qualification:");
                                e.qualification = Console.ReadLine();
                                if (string.IsNullOrEmpty(e.qualification))
                                {
                                    throw new NullException("Please enter your qualification");
                                    
                                }
                                
                            }
                            catch (NullException empty)
                            {
                                Console.WriteLine("Exception occured");
                                Console.WriteLine(empty.Message);
                                //if (File.Exists(directory))
                                //{
                                try
                                {
                                    FileStream fs = new FileStream(directory, FileMode.Append);
                                    using (StreamWriter writer = new StreamWriter(fs))
                                    {
                                        writer.WriteLine(empty.Message);
                                    }
                                } catch(Exception ex)
                                {

                                }
                                    
                                //}
                            }
                            
                            Console.WriteLine("Enter employee Name:");
                            e.name = Console.ReadLine();
                            emp.Add(e);
                            e.display();
                            break;
                        }
                    case 2:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }  
            }
            
           
        }
    }

    
}

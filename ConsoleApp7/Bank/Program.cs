using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankOperations;
using DatabaseConnectivity;


namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DbConnectivity connect = new DbConnectivity();
                connect.connection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("1.Add Account\n2.View Account Details\n3.Withdrawl Amount\n4.Deposite Amount\nEnter the choice:");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:

                     BankOperation add = new BankOperation();
                          add.AddAcount();
                    break;
                case 2:

                    BankOperation details = new BankOperation();
                    details.AccountDetails();
                    break;
                case 3:

                    BankOperation withdraw = new BankOperation();
                    withdraw.Withdraw();
                    break;
                case 4:

                    BankOperation deposite = new BankOperation();
                    deposite.Deposite();
                    break;
                default:
                    Console.WriteLine("Wrong Choice:");
                    break;
            }
            
        }
    }
}

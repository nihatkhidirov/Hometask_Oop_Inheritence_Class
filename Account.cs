using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Oop_Class_Inheritance
{
    internal class Account
    {
        public void Login(string username, string password)
        {
            

            if (username=="Admin" && password== "AdminEA18yr@")
            {
                Console.WriteLine("Giris Ugurludur...");
                Console.WriteLine("Hesabiniza Daxil Oldunuz...");
                Console.WriteLine("..............................");


            }
            else
            {
                Console.WriteLine("Email Ve Ya Password Yanlis Daxil Edilmisdir! ");
                
            }
        }
    }
}

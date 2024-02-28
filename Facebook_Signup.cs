using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_Oop_Class_Inheritance
{
    internal class Facebook_Signup
    {
        public string name;
        public string surname;
        public string email;
        public string password;
        public DateTime birthdate;

        public void GetAllInfo(string name, string surname, string email, string password, DateTime birthdate)
        {
            Console.WriteLine("==============================");
            Console.WriteLine("============================================");
            Console.WriteLine("=======================================================================");
            Console.WriteLine("...........Istifadecinin Melumatlari.........");
            Console.WriteLine($" Ad: {name}\n Soyad: {surname}\n Email: {email}\n Password: {password}\n Dogum Tarixi: {birthdate}\n");
            //Console.WriteLine("=======================================================================");
            //Console.WriteLine("============================================");
            //Console.WriteLine("====================");


        }
    }
}

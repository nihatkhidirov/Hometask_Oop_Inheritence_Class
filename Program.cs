namespace Hometask_Oop_Class_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForMethods_Task1
            Account account = new Account();
            Console.WriteLine("Username-i daxil edin: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password-u daxil edin: ");
            string password = Console.ReadLine();
            account.Login(username, password);
            #endregion
            #region ForMethods_Task2
            Facebook_Signup register = new Facebook_Signup();
            register.name = "Nihat";
            register.surname = "Khidirov";
            register.email = "nihatmkh@code.edu.az";
            register.password = "123456789@";
            register.birthdate = new DateTime(2003, 11, 07);
            register.GetAllInfo(register.name,register.surname,register.email,register.password,register.birthdate); // menimsedib cagirmaq
            register.GetAllInfo("Samir", "Elekberov", "dasda", "adsad", new DateTime(2000,10,08)); //manual olaraq doldurma
            #endregion

        }
    }
}
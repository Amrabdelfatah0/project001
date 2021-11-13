using System;

namespace project001
{
    class Program
    {
        static void Main(string[] args)
        {//i dont understand this cod
            user User = new user();

            Console.WriteLine("first name");
            User.firstName = Console.ReadLine();

            Console.WriteLine("last name");
            User.lastname = Console.ReadLine();

            Console.WriteLine("username");
            User.username = Console.ReadLine();

            Console.WriteLine("password");
            User.password = Console.ReadLine();

            Console.WriteLine("confirm your password");
            User.confirmpassword = Console.ReadLine();
            if (User.password == User.confirmpassword)
            {
                Console.WriteLine("your birthday");
                User.birthDay = Convert.ToDateTime(Console.ReadLine());

                if (User.CalAge() > 18)
                {
                    Console.WriteLine(" your email");
                    User.email = Console.ReadLine();

                    Console.WriteLine("your month salary");
                    User.monthsalary = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("your mobile number");
                    User.mobaile = Console.ReadLine();
                    if (User.mobaile.Length == 14)
                    {
                        Console.WriteLine("write your nationalty");
                        User.nationalid = Console.ReadLine();

                        Console.WriteLine(User.FullName());
                        Console.WriteLine("your Age is : " + User.CalAge());
                        Console.WriteLine( "your yearly salary " + User.yearly_salary());
                    }
                    else
                    {
                        Console.WriteLine("inter your corect number");
                    }
                }
                else
                {
                    Console.WriteLine("inter your corect Age");
                }

               
            } 
            else
            {
                Console.WriteLine("chek your password");
            }





        }
    }
}


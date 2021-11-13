using System;

namespace project001
{
    public class user
    {
        public string firstName;
        public string lastname;
        public string username;
        public string password;
        public string confirmpassword;
        public DateTime birthDay;
        public string email;
        public int monthsalary;
        public string mobaile;
        public string nationalid;

        private string Name;
        public string FullName()
        {
           
            Name = $"User full name is: {firstName} {lastname}";
            
            return Name;
        }

        private DateTime today = DateTime.Now;
        private int Age;

        public int CalAge()
        {
            Age = today.Year - birthDay.Year;
            return Age;
        }

        private int yearly;
        public int yearly_salary()
        {
           int yearly = monthsalary*12;
            return yearly;
        }

    }


}

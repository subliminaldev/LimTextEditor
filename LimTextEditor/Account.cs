using System;
using System.IO;

namespace LimTextEditor
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string dateCreated;
        //add a List of file permissions.

        //For a new account created. Requires most recent date.
        public Account(string username, string password, string userType, string firstName, string lastName, string dateOfBirth)
        {
            this.Username = username;
            this.Password = password;
            this.UserType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            dateCreated = DateTime.UtcNow.Date.ToString("dd/MM/yy");

            AddAccountToDatabase("login.txt");
        }

        //Used for getting the data from the previously existing user file. Date created is should be the same as before.
        public Account(string username, string password, string userType, string firstName, string lastName, string dateOfBirth, string dateCreated)
        {
            this.Username = username;
            this.Password = password;
            this.UserType = userType;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.dateCreated = dateCreated;
        }

        public override string ToString()
        {
            string accountDetails = "";

            accountDetails += Username + ",";
            accountDetails += Password + ",";
            accountDetails += UserType + ",";
            accountDetails += firstName + ",";
            accountDetails += lastName + ",";
            accountDetails += dateOfBirth + ",";
            accountDetails += dateCreated;

            return accountDetails;
        }

        public void AddAccountToDatabase(string fileName)
        {
            //If the file exists, it will be replaced and written on with user data and their files that belong to them.
            File.AppendAllText(fileName, this.ToString() + "\r\n");
            //CHANGE THIS. WE NEED TO PUT LIST OF FILES INTO THE DATA STORAGE SOMEHOW.
            //File.AppendAllText(fileName, "\r\n" + "Text files they have edited?");
        }
    }
}

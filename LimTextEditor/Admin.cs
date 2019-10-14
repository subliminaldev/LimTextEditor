using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimTextEditor
{
    class Admin
    {
        public static List<Account> GetCurrentDatabase()
        {
            List<Account> accountsFromFile = new List<Account> { };

            try
            {
                //We get the list of accounts from the accounts list file.

                string[] accountListFileLines = File.ReadAllLines("login.txt");

                for (int accountLine = 0; accountLine < accountListFileLines.Length; accountLine++)
                {
                    //In case the accounts list has an empty space. Skips it.
                    if (accountListFileLines[0] == "")
                    {
                        continue;
                    }

                    //The first line of each account is the account details. Hence, we initialise our account objects from this data.
                    string[] accountDetails = File.ReadAllLines("login.txt")[accountLine].Split(',');

                    string userName = "";
                    string password = "";
                    string userType = "";
                    string firstName = "";
                    string lastName = "";
                    string dateOfBirth = "";
                    string dateCreated = "";

                    for (int innerLoop = 0; innerLoop < accountDetails.Length; innerLoop++)
                    {
                        switch (innerLoop)
                        {
                            case (0):
                                userName = accountDetails[innerLoop];
                                break;
                            case (1):
                                password = accountDetails[innerLoop];
                                break;
                            case (2):
                                userType = accountDetails[innerLoop];
                                break;
                            case (3):
                                firstName = accountDetails[innerLoop];
                                break;
                            case (4):
                                lastName = accountDetails[innerLoop];
                                break;
                            case (5):
                                dateOfBirth = accountDetails[innerLoop];
                                break;
                            case (6):
                                dateCreated = accountDetails[innerLoop];
                                break;
                        }
                    }
                    accountsFromFile.Add(new Account(userName, password, userType, firstName, lastName, dateOfBirth, dateCreated));
                }
            }

            catch (FileNotFoundException)
            {
                File.Create("login.txt");
                GetCurrentDatabase();
            }

            return accountsFromFile;
        }

        public static bool AccountExists(string username)
        {
            List<Account> accounts = GetCurrentDatabase();

            foreach(Account account in accounts)
            {
                if (account.Username == username)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

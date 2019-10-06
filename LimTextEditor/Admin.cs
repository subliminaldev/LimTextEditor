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
        private List<Account> accounts;

        public Admin()
        {
            accounts = InitialiseDatabase();
        }

        public List<Account> InitialiseDatabase()
        {

            List<Account> accountsFromFile = new List<Account> { };

            try
            {
                //We get the list of accounts from the accounts list file.

                string[] AccountListFileLines = File.ReadAllLines("login.txt");

                foreach (string account in AccountListFileLines)
                {
                    //In case the accounts list has an empty space. Skips it.
                    if (account == "")
                    {
                        continue;
                    }

                    //The first line of each account is the account details. Hence, we initialise our account objects from this data.
                    string[] accountDetails = File.ReadAllLines(account + ".txt")[0].Split(',');

                    int accountNumber = 0;
                    string userName = "";
                    string password = "";
                    int userType = -1;
                    string firstName = "";
                    string lastName = "";
                    string dateCreated = "";

                    for (int innerLoop = 0; innerLoop < accountDetails.Length; innerLoop++)
                    {
                        switch (innerLoop)
                        {
                            case (0):
                                accountNumber = Convert.ToInt32(accountDetails[innerLoop]);
                                break;
                            case (1):
                                userName = accountDetails[innerLoop];
                                break;
                            case (3):
                                password = accountDetails[innerLoop];
                                break;
                            case (4):
                                userType = Convert.ToInt32(accountDetails[innerLoop]);
                                break;
                            case (5):
                                firstName = accountDetails[innerLoop];
                                break;
                            case (6):
                                lastName = accountDetails[innerLoop];
                                break;
                            case (7):
                                dateCreated = accountDetails[innerLoop];
                                break;
                        }
                    }

                    //After we get the account details, we need their transactions, which are the rest of the lines from their file.
                    string[] transactionsString = File.ReadAllLines(account + ".txt");

                    /**
                    List<Transaction> transactions = new List<Transaction> { };

                    //The first line is for account details, so if there is more than one line, then it is a transaction.
                    if (transactionsString.Length > 1)
                    {
                        //Loop through each line, which is a transaction. Again we ignore the first line (it is account details).
                        for (int outerloop = 1; outerloop < transactionsString.Length; outerloop++)
                        {
                            double transactionAmount = Convert.ToDouble(transactionsString[outerloop]);
                            transactions.Add(new Transaction(transactionAmount));
                        }
                    }

                    //Creates a new file and adds it to the list of files for the banking system.
                    accountsFromFile.Add(new Account(accountNumber, userName, firstName, lastName, password, phone, email, transactions));
                    **/
                }
                    
            }
            catch (Exception)
            {
                //This will create a new one if one does not exist.
                //UpdateAccountListFile(accountsList + ".txt");
                Debug.WriteLine("Exception");
            }

            return accountsFromFile;

        }
    }
}

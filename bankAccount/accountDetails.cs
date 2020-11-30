using System;
using System.Collections.Generic;
using System.Text;


    public class accountDetails
    {
    public int AccountID;
    public string CustomerName;
    public int Balance;
    public string Transactions;

        public string accountDesription()
        {
            string description = string.Empty;
            if (AccountID != 0) description += AccountID + " ";
            if (CustomerName != null) description += CustomerName + " ";
            if (Balance != 0) description += Balance + ".kr ";
            if (Transactions != null) description += Transactions + " ";
            return description;
        }
    }

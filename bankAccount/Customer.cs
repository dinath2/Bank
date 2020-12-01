using System;
using System.Collections.Generic;
using System.Text;

    class Customer
    {
    /*Jobben til Customer er å kontrolere metoder relatert til kunder som å bytte navn, endre saldo og bytte bruker*/

        static string NameChange() {
        return "Skriv inn nytt navn: ";
        //change current CustomerName to whatever is entered on Console.ReadLine prompt
    }

        static string InternalBalanceChange() {
        return "Skriv inn ny saldo: ";
        //change current Balance to whatever is entered on Console.ReadLine prompt
        }
    }

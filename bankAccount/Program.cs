﻿using System;

namespace bankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En forenklet bank:

                Skal ha flere kunder, med hver sin konto.

                Hver konto skal ha:

                - Navn som kunden kan velge (console.ReadLine? Noen eksempler klare for unit tester)
                - Kontonummer for å finne kontoen.
                - Saldooversikt.
                - Siste transaksjoner.

                Banken skal kunne:

                - La deg logge inn som en kunde av gangen (grensesnitt).
                - Gi deg en oversikt over navn, saldo, transaksjoner og mulighet til å overføre hvis saldoen er innenfor.

                Fra jeg forstår bør det være en klasse for:

                - Program klasse som kjører alt.
                - Kontoinformasjon.
                - En klasse som har metodene vi trenger for å overføre penger.*/

            var testSubject = new accountDetails { AccountID = 1, CustomerName = "Test", Balance = 5 };

            var app = new bankingApp();
            var transaction = new Transaction();
            var customer = new Customer();

            Console.Write(app.WelcomeMessage);
            while (true) {
                Console.Write(app.CommandPrompt);
                var command = Console.ReadLine();
                var response = app.HandleCommands(command);
                Console.WriteLine(response);
            }

        }
    }
}

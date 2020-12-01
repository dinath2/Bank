using System;
using System.Collections.Generic;
using System.Text;

public class bankingApp {

    /* Jobben til bankingApp er å kontrolere hvilke kommandoer man kan skrive inn, og hvike metoder som man kan kjøre.
    */

    public List<accountDetails> Account;

    public string WelcomeMessage = "Hei! Dette er en bankkonto app test! \n";
    public string CommandPrompt = "Skriv inn kunde ID for oversikt over konto: ";
    public string GeneralOptionPrompt = 
        "Hva ønsker du å gjøre videre? \n" +
        "\t Bytte bruker (bytt) \n" +
        "\t Endre navn (endre) \n" +
        "\t Endre saldo (saldo) \n" +
        "\t Overføre (overføre) \n";
    
    public string HandleCommands(string command)
    {
        var toLowerCommand = command.ToLower();
        if (toLowerCommand == AccountID) { 
            accountDesription();
            return GeneralOptionPrompt;

            if (toLowerCommand == "bytt") {
            }
            if (toLowerCommand == "endre") NameChange();
            if (toLowerCommand == "saldo") InternalBalanceChange();
            if (toLowerCommand == "overføre") {
                Transfer();
            }
        }
        return "Ugyldig kommando";
    }
 }

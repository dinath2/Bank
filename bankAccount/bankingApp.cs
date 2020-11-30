using System;
using System.Collections.Generic;
using System.Text;

public class bankingApp {

    public string WelcomeMessage = "Hei! Dette er en bankkonto app test! \n";
    public string CommandPrompt = "Skriv inn kunde ID for oversikt over konto: ";
    public string GeneralOptionPrompt = 
        "Hva ønsker du å gjøre videre? \n" +
        "\t Bytte bruker (bytt) \n" +
        "\t Endre navn (endre) \n" +
        "\t Overføre (overføre) \n";
    
    public string HandleCommands (string command)
    {
        var toLowerCommand = command.ToLower();
        if (toLowerCommand == AccountID)
    }
 }

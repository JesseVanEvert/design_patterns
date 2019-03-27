    static void Main(string[] args)
    {
        PrintHeader("[CreditCard]");
        BetaalWijze ccBetaling = new CreditCardBetaling();
        ccBetaling.Uitvoeren();

        PrintHeader("[PayPal]");
        BetaalWijze ppBetaling = new PayPalBetaling();
        ppBetaling.Uitvoeren();

        PrintHeader("[PIN]");
        BetaalWijze pinBetaling = new PINBetaling();
        pinBetaling.Uitvoeren();

        Console.ReadKey();
    }

    static void PrintHeader(string header)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(header);
        Console.ResetColor();
    }
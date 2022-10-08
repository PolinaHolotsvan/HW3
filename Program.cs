using HW3;

DecimalConverter decConverter = new DecimalConverter();
decimal eurRate = decConverter.Convert("курс євро");
decimal usdRate = decConverter.Convert("курс долара");
decimal uah = decConverter.Convert("суму(гривнi)");
decimal usd = decConverter.Convert("суму(долари)");
decimal eur = decConverter.Convert("суму(євро)");
Converter converter = new Converter(eurRate, usdRate);
Console.WriteLine($"{uah} гривень це {converter.UAHToUSD(uah)} доларiв");
Console.WriteLine($"{uah} гривень це {converter.UAHToEUR(uah)} євро");
Console.WriteLine($"{usd} доларiв це {converter.USDToUAH(usd)} гривень");
Console.WriteLine($"{eur} євро це {converter.EURToUAH(eur)} гривень");
Console.ReadKey();
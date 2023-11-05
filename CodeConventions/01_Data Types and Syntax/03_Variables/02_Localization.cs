using System.Globalization; //CultureInfo

namespace section01_chap03_topic02;

internal class Subject : Topic
{
    public override string GetTitle()
    {
        return "03.02 Localization";
    }

    public override void Print()
    {
        CultureInfo globalization = CultureInfo.CurrentCulture;
        CultureInfo localization = CultureInfo.CurrentUICulture;

        WriteLine("The current globalization culture is {0}: {1}",
            globalization.Name, globalization.DisplayName);

        WriteLine("The current localization culture is {0}: {1}",
            localization.Name, localization.DisplayName);

        WriteLine();

        WriteLine("en-US: English (United States)");
        WriteLine("da-DK: Danish (Denmark)");
        WriteLine("fr-CA: French (Canada)");
        WriteLine("en-GB: English(United Kingdom)      ");
        WriteLine("es-ES: Spanish(Spain)               ");
        WriteLine("es-MX: Spanish(Mexico)              ");
        WriteLine("fr-FR: French(France)               ");
        WriteLine("fr-CA: French(Canada)               ");
        WriteLine("de-DE: German(Germany)              ");
        WriteLine("ja-JP: Japanese(Japan)              ");
        WriteLine("zh-CN: Chinese(Simplified, China)   ");
        WriteLine("zh-TW: Chinese(Traditional, Taiwan) ");
        WriteLine("ko-KR: Korean(South Korea)          ");
        WriteLine("pt-BR: Portuguese(Brazil)           ");
        WriteLine("pt-PT: Portuguese(Portugal)         ");
        WriteLine("ru-RU: Russian(Russia)              ");
        WriteLine("ar-SA: Arabic(Saudi Arabia)         ");
        WriteLine("hi-IN: Hindi(India)                 ");
        WriteLine("it-IT: Italian(Italy)               ");
        WriteLine("nl-NL: Dutch(Netherlands)           ");
        WriteLine("sv-SE: Swedish(Sweden)              ");
        WriteLine("no-NO: Norwegian(Norway)            ");

        WriteLine("Enter an ISO culture code: ");
        string? newCulture = ReadLine();

        if (!string.IsNullOrEmpty(newCulture))
        {
            CultureInfo ci = new(newCulture);

            //change the current cultures
            CultureInfo.CurrentCulture = ci;
            CultureInfo.CurrentUICulture = ci;
        }
        WriteLine();

        Write("What is your name? ");
        string? name = ReadLine();

        Write("What is your date of birth? ");
        string? dob = ReadLine();

        Write("What is your salary? ");
        string? salary = ReadLine();

        DateTime date = DateTime.Parse(dob);
        int minutes = (int)DateTime.Today.Subtract(date).TotalMinutes;
        decimal earns = decimal.Parse(salary);

        WriteLine($"{name} was born on a {date:dddd}");
        WriteLine($"is {minutes:N0} minutes old");
        WriteLine($"and earns {earns:C}");
    }
}

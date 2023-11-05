namespace section01_chap03_topic01;

internal class Subject : Topic
{
    public override string GetTitle()
    {
        return "03.01 Storing Texts";
    }

    public override void Print()
    {

        ShowLiteralAndVerbatimStrings();
        WriteLine();
        ShowInterpolatedStrings();
        WriteLine();
        ShowFormattedStringsTable();
        WriteLine();
        ShowDecimalToMoney();
        WriteLine();
        ShowTimerMilliSeconds();
        WriteLine();
        ShowBigListOfFormattedStrings();
    }

    private void ShowTimerMilliSeconds()
    {
        int milliseconds = 19536;
        double seconds = 18422.26;
        WriteLine($"{milliseconds:#,##0}ms elapsed");
        WriteLine($"{milliseconds:#,##}ms elapsed");
        WriteLine($"{milliseconds:#,##0.0}ms elapsed");
        WriteLine($"{milliseconds:###}ms elapsed");
        WriteLine($"{milliseconds:##,#}ms elapsed");

        WriteLine($"{seconds:#,##0}s elapsed");
        WriteLine($"{seconds:#,##0.0}s elapsed");
        WriteLine($"{seconds:###0.00}s elapsed");
        WriteLine($"{seconds:##,#}s elapsed");
    }

    private void ShowDecimalToMoney()
    {
        decimal price = 123.45m;

        //Use this to display decimals as money. This is not dependent on region:
        string decimalToMoney = $"The price is {price:$#,##0.00}"; 

        //This is an alternative, but it is dependent on region:
        string decimalToMoneyAlt = $"The price is {price:C}";

        WriteLine(decimalToMoney);
        WriteLine(decimalToMoneyAlt);
    }

    private void ShowFormattedStringsTable()
    {
        string carrotsText = "Carrots";
        int carrotsCount = 15339;

        string tomatoText = "Tomatoes";
        int tomatoCount = 252;

        string eggplantText = "Eggplants";
        int eggplantCount = 1660;

        WriteLine(
            format: "{0, -10} {1,6:N0}",
            arg0: "Item",
            arg1: "Count");

        WriteLine(
            format: "{0, -10} {1,6:N0}",
            arg0: carrotsText,
            arg1: carrotsCount);

        WriteLine("{0, -10} {1,6:N0}",
            tomatoText,
            tomatoCount);

        WriteLine($"{eggplantText,-10} {eggplantCount,6:N0}");
    }

    private static void ShowLiteralAndVerbatimStrings()
    {
        // Literal Strings vs Verbatim Strings
        string fullNameLiteral = "Pascal\tSiakam"; //Pascal  Siakam
        string fullNameVerbatim = @"Pascal\tSiakam"; //Pascal\tSiakam

        WriteLine($"fullNameLiteral = {fullNameLiteral}");
        WriteLine($"fullNameVerbatim = {fullNameVerbatim}");
    }

    private static void ShowInterpolatedStrings()
    {
        // Interpolated Strings
        int numberOfItems = 10;
        double pricePerItem = 3.24;

        //This is the standard:
        string interpolatedString = $"{numberOfItems} apples cost {numberOfItems * pricePerItem:C}";
        WriteLine(interpolatedString);

        //Alternative 1:
        string interpolatedStringAlt = String.Format("{0} apples cost {1:C}", numberOfItems, numberOfItems * pricePerItem);
        WriteLine(interpolatedStringAlt);
        WriteLine("{0} apples cost {1:C}", numberOfItems, numberOfItems * pricePerItem);

        //Alternative 2:
        Console.WriteLine(
            format: "{0} apples cost {1:C}",
            arg0: numberOfItems,
            arg1: numberOfItems * pricePerItem);

        //Avoid:
        string concatString = numberOfItems + " apples cost $" + numberOfItems * pricePerItem;
        WriteLine(concatString);
    }

    private void ShowBigListOfFormattedStrings()
    {
        decimal price = 1234.56m;
        // Formats a numeric value as currency.
        string formattedString3 = $"The price is {price:C}"; // The price is $1,234.56

        int number = 12345;
        // Formats an integer as a decimal.
        string formattedString4 = $"The number is {number:D}"; // The number is 12345

        double valueE = 1.23456789;
        // Formats a number in exponential notation.
        string formattedString5 = $"The value is {valueE:E}"; // The value is 1.234568E+00

        double valueF = 1234.5678;
        // Formats a floating-point number with fixed decimal places.
        string formattedString6 = $"The value is {valueF:F2}"; // The value is 1234.57

        double valueG = 1234.5678;
        // Automatically chooses the appropriate format (either fixed-point or exponential).
        string formattedString7 = $"The value is {valueG:G}"; // The value is 1234.5678

        int numberN = 1234567;
        // Formats a number with thousands separators.
        string formattedString8 = $"The number is {numberN:N}"; // The number is 1,234,567

        double percentage = 0.75;
        // Formats a number as a percentage.
        string formattedString9 = $"The percentage is {percentage:P}"; // The percentage is 75.00%

        int valueX = 255;
        // Formats an integer as a hexadecimal value.
        string formattedString10 = $"The hexadecimal value is {valueX:X}"; // The hexadecimal value is FF

        double value0 = 12.3456;
        // Formats a numeric value with two decimal places.
        string formattedString11 = $"The value is {value0:0.00}"; // The value is 12.35

        double valueSharp = 12.3456;
        // Formats a numeric value with up to two decimal places.
        string formattedString12 = $"The value is {valueSharp:#.##}"; // The value is 12.35

        DateTime date = DateTime.Now;
        // Formats a DateTime as year-month-day.
        string formattedString13 = $"The date is {date:yyyy-MM-dd}"; // The date is 2023-11-14

        DateTime dateDMY = DateTime.Now;
        // Formats a DateTime as day/month/year.
        string formattedString14 = $"The date is {dateDMY:dd/MM/yyyy}"; // The date is 14/11/2023

        DateTime time = DateTime.Now;
        // Formats a DateTime as hours:minutes AM/PM.
        string formattedString15 = $"The time is {time:hh:mm tt}"; // The time is 05:30 PM

        DateTime dateTime = DateTime.Now;
        // Formats a DateTime with full date and time.
        string formattedString16 = $"The date and time is {dateTime:yyyy/MM/dd HH:mm:ss}"; // The date and time is 2023/11/14 17:30:00

        // Escapes a character (in this case, the backslash).
        string formattedString17 = $"The path is C:\\Users\\John\\Documents"; // The path is C:\Users\John\Documents

        double percentage2 = 0.75;
        // Formats a numeric value as a percentage (e.g., 0.75 becomes 75%).
        string formattedString18 = $"The percentage is {percentage2:0%}"; // The percentage is 75%

        int numberComma = 1234567;
        // Formats a numeric value with comma as thousands separator.
        string formattedString19 = $"The number is {numberComma:#,0}"; // The number is 1,234,567

        double valueScientific = 123456789;
        // Formats a number in scientific notation.
        string formattedString20 = $"The value is {valueScientific:0.00E+00}"; // The value is 1.23E+08

        WriteLine(formattedString3);
        WriteLine(formattedString4);
        WriteLine(formattedString5);
        WriteLine(formattedString6);
        WriteLine(formattedString7);
        WriteLine(formattedString8);
        WriteLine(formattedString9);
        WriteLine(formattedString10);
        WriteLine(formattedString11);
        WriteLine(formattedString12);
        WriteLine(formattedString13);
        WriteLine(formattedString14);
        WriteLine(formattedString15);
        WriteLine(formattedString16);
        WriteLine(formattedString17);
        WriteLine(formattedString18);
        WriteLine(formattedString19);
        WriteLine(formattedString20);

    }
}

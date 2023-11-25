namespace section01_chap03_topic03;


internal class Subject : Topic
{
    public override string GetTitle()
    {
        return "03.03 Comparing Strings";
    }

    public override void Print()
    {
        //Comparing strings: used for determining the order
        //Equals: used to check if the strings are the same or not

        string root = @"C:\users";
        string root2 = @"C:\Users";

        bool result = root.Equals(root2, StringComparison.OrdinalIgnoreCase);
        bool areEqual = String.Equals(root, root2, StringComparison.OrdinalIgnoreCase);
        int comparison = String.Compare(root, root2, comparisonType: StringComparison.OrdinalIgnoreCase);

        Console.WriteLine($"Ordinal ignore case: <{root}> and <{root2}> are {(result ? "equal." : "not equal.")}");
        Console.WriteLine($"Ordinal static ignore case: <{root}> and <{root2}> are {(areEqual ? "equal." : "not equal.")}");
        if (comparison < 0)
            Console.WriteLine($"<{root}> is less than <{root2}>");
        else if (comparison > 0)
            Console.WriteLine($"<{root}> is greater than <{root2}>");
        else
            Console.WriteLine($"<{root}> and <{root2}> are equivalent in order");


        // about string == string and string != string

        if (root == root2)
        {
            Console.WriteLine("testing string == string");

            // go to definition of == and != to see the definition of operators == and != 
            // in the C# string class:
            /*
                public static bool operator ==(string? a, string? b) => string.Equals(a, b);
                public static bool operator !=(string? a, string? b) => !string.Equals(a, b);
            */

            // Therefore, they are the same. 

        }



    }
}

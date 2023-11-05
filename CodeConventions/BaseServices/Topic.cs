using static System.Console;

namespace BaseServices;

public abstract class Topic
{
    public abstract void Print();
    public abstract string GetTitle();
}

public class Utilities
{
    const int _dividerLength = 60;
    public static void WriteDivider(char v)
    {
        for (int a = 0; a < _dividerLength; a++)
        {
            Write(v);
        }
        WriteLine();
    }
    public static void ExecuteAll(List<Topic> topics)
    {
        foreach (var topic in topics)
        {
            WriteDivider('*');
            WriteLine(topic.GetTitle());
            WriteDivider('-');
            topic.Print();
            WriteLine();
        }
        WriteDivider('*');
    }
}
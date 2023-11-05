global using BaseServices;
global using static System.Console;
global using static BaseServices.Utilities;

namespace _01_Data_Types_and_Syntax;


internal class Program
{
    static void Main(string[] args)
    {
        WriteLine("Section 1: Data Types and Syntax");
        ExecuteAll(AssembleTopics());
    }


    private static List<Topic> AssembleTopics()
    {
        List<Topic> topics = new()
        {
            new section01_chap03_topic01.Subject(),
            new section01_chap03_topic02.Subject()
        };

        return topics;
    }
}
// this will allow simplifying calls to static members:
using static System.Console;
using static Countries.Canada;


namespace Countries
{
    public class Canada
    {
        public const int population = 1000000;
        public static void GetCapitalCityMessage()
        {
            WriteLine("Ottawa, Canada's capital city");
        }

    }
}




namespace _01_Data_Types_and_Syntax._02_Namespaces
{
    internal class _07_Importing_static_classes
    {
        void GetCountry()
        {
            //Instead of having to write this:
            System.Console.WriteLine("Ottawa, Canada's capital city");
            //It can now be simplified to this:
            WriteLine("Ottawa, Canada's capital city");


            //Same here:
            Countries.Canada.GetCapitalCityMessage();
            GetCapitalCityMessage();

            //Works with accessible fields too
            WriteLine(Countries.Canada.population);
            WriteLine(population);
        }
        
    }
}

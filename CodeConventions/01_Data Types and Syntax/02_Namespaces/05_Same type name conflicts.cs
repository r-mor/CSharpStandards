using Color;
using Fruit;

namespace _01_Data_Types_and_Syntax._02_Namespaces
{
    internal class _05_Same_type_name_conflicts
    {
        // ambigious reference error:
        // Orange whichOrangeIsThis = new Orange();

        // specify the namespace in this case:
        Color.Orange orangeColor = new();
    }
}

using Color;

//When locally importing a namespace, try to add in a comment which type is being used in code:
using System.Globalization; //CultureInfo

namespace localImport;

internal class _03_Locally_importing_a_namespace
{
    Orange orangeColor = new();
    CultureInfo ci = CultureInfo.InvariantCulture;
}

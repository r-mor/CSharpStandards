namespace UsingTheTypes;

internal class _04_Global_import_using_the_types
{
    static void CheckAccessToGlobalImport()
    {
        //Neptune type is available because the planet namespace is globally imported.
        Neptune neptune = new Neptune();
    }
}

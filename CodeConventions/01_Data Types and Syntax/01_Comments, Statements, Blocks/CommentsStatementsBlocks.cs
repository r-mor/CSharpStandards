namespace _01_Data_Types_and_Syntax.Comments__Statements__Blocks;

internal class CommentsStatementsBlocks
{
    void AboutStatements()
    {
        var subTotal = 100;
        var salesTax = 7.23;

        //totalPrice is the variable
        //subTotal + salesTax is the expression
        var totalPrice = subTotal + salesTax;
    }

    void AboutComments()
    {
        // single line comment

        /*
          
        multi line comment
        Everything here is commented out
        line
        line
          
         */

        //multi line comments can also be used in the middle of a statement:
        var helloMessage = "Hello there" /* + name */ + "!!!";

        //XML comments are used to aid the IDE in providing context on a function.

        // Type /// (triple forward slash) above a method declaration to auto
        // populate the XML comment.

        //In VS, hover over the method name (ThisHasAnXMLComment) below to
        //see the comment summary in intellisense.
        ThisHasAnXMLComment(1, "Hello", new DateTime());
    }

    /// <summary>
    /// Hello from the XML comment! 
    /// Intellisense will show this message.
    /// </summary>
    /// <param name="number">Give an explanation for this parameter</param>
    /// <param name="text">explanation 2</param>
    /// <param name="date">explanation 3</param>
    /// <returns>Provide an explanation for the return type</returns>
    string ThisHasAnXMLComment(int number, string text, DateTime date)
    {
        return "here are some sample text";
    }


}

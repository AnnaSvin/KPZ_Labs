using ClassLibraryOwnHTML;

internal class Program
{
    private static void Main(string[] args)
    {
        var header = new LightElementNode("h1", DisplayType.Block, ClosingType.WithClosingTag);
        var textNode = new LightTextNode("Original Title");
        header.AddChild(textNode);

        Console.WriteLine(header.OuterHTML);

        var addClassCommand = new AddCssClassCommand(header, "main-title");
        var changeTextCommand = new ChangeTextCommand(textNode, "Updated Title");
        var removeClassCommand = new RemoveCssClassCommand(header, "main-title");

        var invoker = new CommandInvoker();
        invoker.AddCommand(addClassCommand);
        addClassCommand.Execute();
        Console.WriteLine(header.OuterHTML);

        invoker.AddCommand(changeTextCommand);
        invoker.AddCommand(removeClassCommand);

        invoker.ExecuteAll();

        Console.WriteLine(header.OuterHTML);
    }
}
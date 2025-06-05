using ClassLibraryCompositePatternAndFlyweight;

internal class Program
{
    private static void Main(string[] args)
    {
        var div = new CustomDiv();
        div.CssClasses.Add("container");

        var header = new LightTextNode("Hello Lifecycle!");
        div.AddChild(header);

        div.RenderWithLifecycle();
        Console.WriteLine(div.OuterHTML);
    }
}
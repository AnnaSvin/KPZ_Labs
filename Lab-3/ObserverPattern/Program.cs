using ClassLibraryCompositePattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var div = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
        var span = new LightElementNode("span", DisplayType.Inline, ClosingType.WithClosingTag);
        var text = new LightTextNode("Hello, world!");

        span.AddChild(text);
        div.AddChild(span);

        var clickLogger = new ClickLogger();
        var mouseOverLogger = new MouseOverLogger();

        div.AddEventListener("click", clickLogger);
        span.AddEventListener("click", clickLogger);

        div.AddEventListener("mouseover", mouseOverLogger);
        span.AddEventListener("mouseover", mouseOverLogger);

        Console.WriteLine("Triggering events:");
        div.TriggerEvent("click");
        span.TriggerEvent("click");

        div.TriggerEvent("mouseover");
        span.TriggerEvent("mouseover");
    }
}
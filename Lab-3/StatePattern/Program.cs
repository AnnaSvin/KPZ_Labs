using ClassLibraryOwnHTML;

internal class Program
{
    private static void Main(string[] args)
    {
        var div = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
        div.CssClasses.Add("box");

        var p = new LightElementNode("p", DisplayType.Block, ClosingType.WithClosingTag);
        p.AddChild(new LightTextNode("This is a paragraph."));
        div.AddChild(p);

        Console.WriteLine("== NORMAL ==");
        div.SetRenderState(new NormalRenderState());
        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\n== MINIFIED ==");
        div.SetRenderState(new MinifiedRenderState());
        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\n== DEBUG ==");
        div.SetRenderState(new DebugRenderState());
        Console.WriteLine(div.OuterHTML);
    }
}
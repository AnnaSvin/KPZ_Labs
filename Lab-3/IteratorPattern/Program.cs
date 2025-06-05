internal class Program
{
    private static void Main(string[] args)
    {
        var div = new LightElementNode("div", DisplayType.Block, ClosingType.WithClosingTag);
        div.CssClasses.Add("container");

        var header = new LightElementNode("h1", DisplayType.Block, ClosingType.WithClosingTag);
        header.AddChild(new LightTextNode("Welcome to LightHTML!"));

        var ul = new LightElementNode("ul", DisplayType.Block, ClosingType.WithClosingTag);
        ul.CssClasses.Add("main-list");

        var li1 = new LightElementNode("li", DisplayType.Block, ClosingType.WithClosingTag);
        li1.AddChild(new LightTextNode("First item"));

        var li2 = new LightElementNode("li", DisplayType.Block, ClosingType.WithClosingTag);
        li2.AddChild(new LightTextNode("Second item"));

        ul.AddChild(li1);
        ul.AddChild(li2);

        div.AddChild(header);
        div.AddChild(ul);

        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\nDepth-First:");
        var depthIterator = div.CreateDepthFirstIterator();
        while (depthIterator.HasNext())
        {
            var node = depthIterator.Next();
            Console.WriteLine($"- {node.GetType().Name}: {node.InnerHTML}");
        }

        Console.WriteLine("\nBreadth-First:");
        var breadthIterator = div.CreateBreadthFirstIterator();
        while (breadthIterator.HasNext())
        {
            var node = breadthIterator.Next();
            Console.WriteLine($"- {node.GetType().Name}: {node.InnerHTML}");
        }
    }
}
using System;

class Program
{
    static void Main()
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
    }
}

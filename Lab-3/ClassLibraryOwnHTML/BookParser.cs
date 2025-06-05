public static class BookParser
{
    public static LightElementNode ParseText(string[] lines)
    {
        var root = LightElementFactory.GetElement("div");
        root.CssClasses.Add("book");

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];

            string tag = i == 0 ? "h1" :
                         line.StartsWith(" ") ? "blockquote" :
                         line.Length < 20 ? "h2" : "p";

            var element = LightElementFactory.GetElement(tag);
            element.AddChild(new LightTextNode(line.TrimEnd()));
            root.AddChild(element);
        }

        return root;
    }
}

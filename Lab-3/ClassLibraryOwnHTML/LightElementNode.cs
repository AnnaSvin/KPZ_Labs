using ClassLibraryOwnHTML;
using System;
using System.Collections.Generic;
using System.Text;

public class LightElementNode : LightNode
{
    public string TagName { get; set; }
    public DisplayType Display { get; set; }
    public ClosingType Closing { get; set; }
    public List<string> CssClasses { get; set; } = new();
    public List<LightNode> Children { get; set; } = new();
    public int IndentLevel { get; set; } = 0;

    public LightElementNode(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
    }

    public void AddChild(LightNode node)
    {
        Children.Add(node);
    }

    public int ChildCount => Children.Count;

    public override string InnerHTML
    {
        get
        {
            StringBuilder sb = new();
            foreach (var child in Children)
            {
                sb.Append(child.OuterHTML);
            }
            return sb.ToString();
        }
    }

    public override string OuterHTML
    {
        get
        {
            var sb = new StringBuilder();
            string indent = new string(' ', IndentLevel * 2);

            sb.Append($"{indent}<{TagName}");

            if (CssClasses.Count > 0)
            {
                sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");
            }

            sb.Append(">");

            bool hasNestedElements = Children.OfType<LightElementNode>().Any();

            if (hasNestedElements)
            {
                sb.AppendLine();

                foreach (var child in Children)
                {
                    if (child is LightElementNode elem)
                        elem.IndentLevel = this.IndentLevel + 1;

                    sb.AppendLine(child.OuterHTML);
                }

                sb.Append($"{indent}</{TagName}>");
            }
            else
            {
                foreach (var child in Children)
                {
                    sb.Append(child.OuterHTML);
                }

                sb.Append($"</{TagName}>");
            }

            return sb.ToString();
        }
    }

    public IIterator<LightNode> CreateDepthFirstIterator()
    {
        return new DepthFirstIterator(this);
    }

    public IIterator<LightNode> CreateBreadthFirstIterator()
    {
        return new BreadthFirstIterator(this);
    }
}

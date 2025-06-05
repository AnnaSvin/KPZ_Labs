public class LightTextNode : LightNode
{
    private string _text;

    public string Text
    {
        get => _text;
        set => _text = value;
    }

    public LightTextNode(string text)
    {
        _text = text;
    }

    public override string OuterHTML => _text;
    public override string InnerHTML => _text;
}

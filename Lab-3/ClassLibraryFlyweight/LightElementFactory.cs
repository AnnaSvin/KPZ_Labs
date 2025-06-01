public static class LightElementFactory
{
    private static Dictionary<string, LightElementNode> _elementCache = new();

    public static LightElementNode GetElement(string tag)
    {
        if (!_elementCache.ContainsKey(tag))
        {
            _elementCache[tag] = new LightElementNode(tag, DisplayType.Block, ClosingType.WithClosingTag);
        }

        // Створюємо копію з тими самими властивостями, але новими дітьми
        var prototype = _elementCache[tag];
        return new LightElementNode(prototype.TagName, prototype.Display, prototype.Closing);
    }

    public static int UniqueElementsCount => _elementCache.Count;
}

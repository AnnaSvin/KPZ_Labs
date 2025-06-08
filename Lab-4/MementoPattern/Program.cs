using ClassLibraryMementoPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var doc = new TextDocument();
        var editor = new TextEditor(doc);

        editor.Write("Hello");
        editor.Show();

        editor.Write(", world!");
        editor.Show();

        editor.Undo();
        editor.Show();

        editor.Undo();
        editor.Show();
    }
}
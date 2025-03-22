using ClassLibraryPrototypeVirus;

internal class Program
{
    private static void Main(string[] args)
    {
        var parentVirus = new Virus("Alpha", 2.5, 5, "Type A");
        var child1 = new ChildVirus("Beta", 1.0, 2, "Type B", "Mutation X");
        var child2 = new ChildVirus("Gamma", 1.2, 3, "Type B", "Mutation Y");

        var grandChild1 = new GrandChildVirus("Delta", 0.5, 1, "Type C", true);
        var grandChild2 = new GrandChildVirus("Epsilon", 0.7, 1, "Type C", false);

        child1.AddChild(grandChild1);
        child2.AddChild(grandChild2);

        parentVirus.AddChild(child1);
        parentVirus.AddChild(child2);

        Console.WriteLine("Original Virus Family:");
        parentVirus.DisplayInfo();

        Console.WriteLine("\nTesting cloning:");
        var clonedChild1 = (ChildVirus)child1.Clone();
        var clonedGrandChild1 = (GrandChildVirus)grandChild1.Clone();

        Console.WriteLine("\nCloned Child Virus:");
        clonedChild1.DisplayInfo();
        Console.WriteLine("\nCloned Grandchild Virus:");
        clonedGrandChild1.DisplayInfo();

        var clonedVirus = (Virus)parentVirus.Clone();
        Console.WriteLine("\nCloned Virus Family:");
        clonedVirus.DisplayInfo();
    }
}

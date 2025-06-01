class Program
{
    static void Main()
    {
        IRenderer vector = new VectorRenderer();
        IRenderer raster = new RasterRenderer();

        Shape circle = new Circle(vector);
        Shape square = new Square(raster);
        Shape triangle = new Triangle(vector);

        circle.Draw();     
        square.Draw();   
        triangle.Draw();   
    }
}

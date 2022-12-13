class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.Side = 10;
        square.GetArea();
        Console.WriteLine(square.GetArea());
        Console.ReadKey();
    }
}
interface IArea
{
    int GetArea();
}
class Rectangle : IArea
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}
class Square : IArea
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

//Порушено принцип Liskov Substitution Principle
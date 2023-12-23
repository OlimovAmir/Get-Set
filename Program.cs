
class Program
{
    static void Main(string[] args)
    {
        Get_Set.Point point = new Get_Set.Point();

        point.SetX(15);
        int valueX =  point.GetX();
        Console.WriteLine(valueX);

        point.Y = 25;
        int valueY = point.Y;
        Console.WriteLine(valueY);
    }
}
using static Circle;

namespace Homework12_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circ = new Circle();

            circleDelegate cirDel1 = new circleDelegate(circ.area);

            cirDel1 += circ.perimeter;

            cirDel1.Invoke(2.0);

            cirDel1.Invoke(3.5);

        }
    }
}

public class Circle {
    public delegate void circleDelegate(double radius);

    public void area(double radius) {
        Console.WriteLine("Circle area is: "+ Math.PI * radius * radius);
    }

    public void perimeter(double radius) {
        Console.WriteLine("Circle perimeter is: " + Math.PI * 2 * radius);
    }
}


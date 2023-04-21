
namespace OlGenBootcampTask
{
    public static class AreaCalculator
    {
        public static void CalculateArea(double width, double length, double height)
        {
            Console.WriteLine(width * length * height);
        }

        public static void CalculateArea(double width, double length) => CalculateArea(width, length, 1); 
    }
}

namespace Assignment3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Follow prompts to input X,Y coordinates to determine which quadrant your coordinate is in");
            Console.WriteLine("Input the value for X coordinate:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate:");
            y = Convert.ToInt32(Console.ReadLine());

            if(x > 0 && y > 0)
            {
                Console.WriteLine($"The point ({x},{y}) is in the 1st quadrant");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine($"The point ({x},{y}) is in the 2nd quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The point ({x},{y}) is in the 3rd quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The point ({x},{y}) is in the 4th quadrant");
            }
            else if (x == 0 || y == 0)
            {
                Console.WriteLine($"The point ({x},{y}) is on an axis and therefore doesn't fall in any quadrant");
            }
        }
    }
}

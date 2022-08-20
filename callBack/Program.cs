namespace CallBack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SquareClass.SquareCalculator(Completed);
        }
        public static void Completed(int valuesCalculated)
        {
            Console.WriteLine($"square of {valuesCalculated} calculated");
        }
    }
}
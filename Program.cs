namespace Ex4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variable for the chosen times table
            int number;

            // Ask the user which times table they want
            Console.WriteLine("Enter the times table you want");
            number = Convert.ToInt16(Console.ReadLine());

            // Display the chosen times table
            Console.WriteLine(number + " x 1 = " + (number * 1));
            Console.WriteLine(number + " x 2 = " + (number * 2));
            Console.WriteLine(number + " x 3 = " + (number * 3));
            Console.WriteLine(number + " x 4 = " + (number * 4));
            Console.WriteLine(number + " x 5 = " + (number * 5));
            Console.WriteLine(number + " x 6 = " + (number * 6));
            Console.WriteLine(number + " x 7 = " + (number * 7));
            Console.WriteLine(number + " x 8 = " + (number * 8));
            Console.WriteLine(number + " x 9 = " + (number * 9));
            Console.WriteLine(number + " x 10 = " + (number * 10));

            Console.ReadKey();
        }
    }
}

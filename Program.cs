using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Statistics application");

        int[] values = ReadValuesFromUser();

        Console.WriteLine("Numbers loaded: " + values.Length);
    }

    static int[] ReadValuesFromUser()
    {
        Console.WriteLine("Enter integers separated by spaces:");

        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be empty. Default values will be used.");
            return new int[] { 4, 8, 15, 16, 23, 42 };
        }

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] values = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            bool success = int.TryParse(parts[i], out values[i]);

            if (!success)
            {
                Console.WriteLine("Invalid value detected. Default values will be used.");
                return new int[] { 4, 8, 15, 16, 23, 42 };
            }
        }

        return values;
    }
}
using System;

public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        ValidateInput(values);

        int sum = 0;

        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }

        return (double)sum / values.Length;
    }

    public static void ValidateInput(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }
    }
}
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

    public static int CalculateMax(int[] values)
    {
        ValidateInput(values);

        int max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }

        return max;
    }

    public static int CalculateMin(int[] values)
    {
        ValidateInput(values);

        int min = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
        }

        return min;
    }

    public static void ValidateInput(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }
    }
}
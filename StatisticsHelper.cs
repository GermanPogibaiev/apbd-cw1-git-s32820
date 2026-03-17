using System;

public static class StatisticsHelper
{
    public static void ValidateInput(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty.");
        }
    }
}
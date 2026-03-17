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
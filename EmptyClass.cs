namespace Proj1;

public class EmptyClass
{
    double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0) return 0;

        double sum = 0;
        foreach (var n in values)
        {
            sum += n;
        }
        return sum / values.Length;
    }

    int CalculateMax(int[] values)
    {
        return 0;
    }

    int CalculateAll(int number)
    {
        return 0;
    }
}
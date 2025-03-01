namespace MultiThreadedCounting;

public static class NumberGeneration
{
    public static int[] GenerateIntegerArray(int lowerBound, int upperBound, int count, out long expectedValue)
    {
        var random = new Random();
        expectedValue = 0;
        var allValues = new int[count];
        for (int i = 0; i < count; i++)
        {
            var number = random.Next(lowerBound, upperBound);
            allValues[i]= number;
            expectedValue += number;
        }

        return allValues;
    }
}
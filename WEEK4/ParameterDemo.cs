namespace WEEK4;

public class ParameterDemo
{
    // Increases the number by 10 using ref
    public void Increase(ref int number)
    {
        number += 10;
    }

    // Assigns full name using out
    public void GetFullName(out string fullname)
    {
        fullname = "Roshan Khadka";
    }

    // Returns sum of all numbers using params
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
            sum += n;
        return sum;
    }
    
}

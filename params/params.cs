class program
{
    static void Main()
    {
        int sum1 = SumParameters(1);
        int sum2 = SumParameters(1,2);
        int sum3 = SumParameters(1,2,3);
        int sum4 = SumParameters(4,6,8,2);

        Console.WriteLine(sum1);
        Console.WriteLine(sum2);
        Console.WriteLine(sum3);
        Console.WriteLine(sum4);

    }
    static int SumParameters(params int[] values)
    {
        //toplama işlemi
        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }
        return sum;
    }
}
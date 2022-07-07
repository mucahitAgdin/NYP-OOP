class program
{
    static void Main(string[] args)
    {
        bool b;
        int max = Max(9,2,out b);
        Console.WriteLine(b);
    }
    static int Max(int x, int y, out bool b)
    {
        if (x > y)
            b = true;
        else
            b = false;
        return Math.Max(x, y);
    }
}
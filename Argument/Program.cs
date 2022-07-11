class program
{
    static void Main(string[] CmdArgs)
    {
        Console.WriteLine("Total Arguments: {0}", CmdArgs.Length);

        Console.Write("Arguments: ");

        foreach (var arg in CmdArgs)
            Console.Write(arg + ", ");
    }
}
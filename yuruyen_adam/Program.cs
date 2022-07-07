using System;

class Cursor
{
    protected static int orign_row;
    protected static int orign_col;
    protected static void WriteAt(string s, int x, int y)
    {
        try
        {
            Console.SetCursorPosition(orign_col + x, orign_row + y);
            Console.Write(s);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Clear();
            Console.WriteLine(e.Message);
        }

    }
    public static void Main()
    {
        Console.Clear();
        //TODO: Cursor: İmlecin görünür olup olmadığını belirten bir değer alır veya ayarlar.
        orign_row = Console.CursorTop;
        orign_col = Console.CursorLeft;

        //left
        WriteAt("+", 0, 0);
        WriteAt("|", 0, 1);
        WriteAt("|", 0, 2);
        WriteAt("|", 0, 3);
        WriteAt("|", 0, 4);
        WriteAt("|", 0, 5);
        WriteAt("+", 0, 6);

        //bottom
        WriteAt("+", 1, 8);
        WriteAt("-", 2, 8);
        WriteAt("-", 3, 8);
        WriteAt("-", 4, 8);
        WriteAt("-", 5, 8);
        WriteAt("-", 6, 8);
        WriteAt("-", 7, 8);
        WriteAt("-", 8, 8);
        WriteAt("+", 9, 8);

        //right
        WriteAt("|", 16, 8);
        WriteAt("|", 16, 7);
        WriteAt("|", 16, 6);
        WriteAt("|", 16, 5);
        WriteAt("|", 16, 4);
        WriteAt("|", 16, 3);
        WriteAt("|", 16, 2);
        WriteAt("|", 16, 1);
        WriteAt("+", 16, 0);

        //top

        WriteAt("-", 7, 2);
        WriteAt("-", 6, 2);
        WriteAt("-", 5, 2);
        WriteAt("-", 4, 2);
        WriteAt("-", 3, 2);
        WriteAt("-", 2, 2);
        WriteAt("-", 1, 2);
        WriteAt(" ", 0, 2);
        Console.WriteLine();
    }
}

//oh boy here we go:
class Program
{
    static void Main()
    {
        do
        {
            var i1 = GetAscii();
            var i2 = GetAscii();
            
            if (ValidateCharacters(i1, i2))
            {
                Output(i1, i2);
            }
            else
            {
                Console.WriteLine("Error! You should only write between A to Z or a to z.");
            }
            
        } while (CheckContinue());
    }
    
    private static bool ValidateCharacters(int i1, int i2)
    {
        return (i1 is > 64 and < 91 && i2 is > 64 and < 91) || (i1 is > 96 and < 123 && i2 is > 96 and < 123);
    }

    static void Output(int i1, int i2)
    {
        if (i1 == i2)
        {
            PrintHighlightMessage(false);
            Console.WriteLine((char)i1);
            PrintHighlightMessage(false);
        }
        else
        {
            PrintHighlightMessage();
            PrintLetters(i1, i2);
            PrintHighlightMessage();
        }
    }

    private static void PrintLetters(int i1, int i2)
    {
        if (i2 > i1)
        {
            for (; i2 >= i1; i1++)
            {
                Console.WriteLine(Convert.ToChar(i1));
            }
        }
        else if (i2 < i1)
        {
            for (; i1 >= i2; i1--)
            {
                Console.WriteLine(Convert.ToChar(i1));
            }
        }
    }

    static int GetAscii()
    {
        Console.Write("Please enter a letter:\t");
        var x = Console.Read();
        Console.ReadLine();
        Console.WriteLine();
        return x;
    }

    static void PrintHighlightMessage(bool plural=true)
    {
        if (plural)
            Console.WriteLine("*********Letters***********");
        else
            Console.WriteLine("*********Letter***********");
    }

    static bool CheckContinue()
    {
        Console.WriteLine("Do you wish to try again? (y , n):\t");
        var selection = (char) Console.Read();
        Console.ReadLine();
        return selection is 'y' or 'Y';
    }
}
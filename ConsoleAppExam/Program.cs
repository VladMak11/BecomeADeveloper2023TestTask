
using System;
using System.Text;

class Program
{
    static char FindFirstUniqueCharacter(string text)
    {
        var findChar = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word[0])
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());
        var firstUniqueChar = findChar.FirstOrDefault(pair => pair.Value == 1).Key;

        return firstUniqueChar;
    }
    static void Main(string[] args)
    {
        //First text.
        string exampleText1 = "The Tao gave birth to machine language.  Machine language gave birth\r\nto the assembler.\r\nThe assembler gave birth to the compiler.  Now there are ten thousand\r\nlanguages.\r\nEach language has its purpose, however humble.  Each language\r\nexpresses the Yin and Yang of software.  Each language has its place within\r\nthe Tao.\r\nBut do not program in COBOL if you can avoid it.\r\n        -- Geoffrey James, \"The Tao of Programming\"";
        Console.WriteLine(exampleText1);
        Console.WriteLine($"\nFind First Unique Character - {FindFirstUniqueCharacter(exampleText1)}\n");

        //Second text.
        string exampleText2 = "C makes it easy for you to shoot yourself in the foot. C++ makes that harder, but when you do, it blows away your whole leg. (с) Bjarne Stroustrup";
        Console.WriteLine(exampleText2);
        Console.WriteLine($"\nFind First Unique Character - {FindFirstUniqueCharacter(exampleText2)}\n");

        Console.ReadLine();
    }
}
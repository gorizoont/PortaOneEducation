namespace TestTask;
internal class Program
{
    static string SearchWord(string[] str)
    {
        string liters = "";

        foreach (string word in str)
        {
            foreach (char c in word)
            {
                if (word.IndexOf(c) == word.LastIndexOf(c))
                {
                    liters += c;
                    break;
                }
            }
        }
        return liters;
    }

    static char SearchChar(string strword)
    {
        foreach (char symb in strword)
        {
            if (strword.IndexOf(symb) == strword.LastIndexOf(symb))
            {
                return symb;
            }
        }
        return ' ';
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Your text: ");

        string? enterstring = Console.ReadLine();
        string[] words = enterstring.Split(new char[] { ' ', '.', ',', '-', '"', '\n', '\r', '\"' }, StringSplitOptions.RemoveEmptyEntries);

        var result = SearchChar(SearchWord(words));

        if (result != ' ')
            Console.WriteLine("Your result: {0}", result);
        else
            Console.WriteLine("You enter empty string or no unique characters!");

        Console.WriteLine("Press any key to close the console app...");
        Console.ReadKey();
    }
}


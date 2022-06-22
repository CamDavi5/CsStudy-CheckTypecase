static int SameCase(char a, char b)
{
    if (Char.IsUpper(a) && Char.IsUpper(b))
    {
        Console.WriteLine("The two chars are the same typecase!");
        return 1;
    }
    else if (Char.IsLower(a) && Char.IsLower(b))
    {
        Console.WriteLine("The two chars are the same typecase!");
        return 1;
    }
    else if (Char.IsLetter(a) == false || Char.IsLetter(b) == false)
    {
        Console.WriteLine("One of the inputs was not a proper letter!");
        return -1;
    }
    Console.WriteLine("The two chars are NOT the same typecase!");
    return 0;
}

Console.WriteLine("Type in two chars to check their typecase!");
Console.WriteLine("Char 1: ");
string first = Console.ReadLine();
Console.WriteLine("Char 2: ");
string second = Console.ReadLine();
char a = char.Parse(first);
char b = char.Parse(second);

SameCase(a, b);
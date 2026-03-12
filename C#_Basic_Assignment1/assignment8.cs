class Check
{
    static void Main(string[] args)
    {
        string text;

        Console.Write("Enter a string: ");
        text = Console.ReadLine();

        CharacterCheck obj = new CharacterCheck();
        obj.CheckThirdCharacter(text);

        Console.ReadLine();
    }
}
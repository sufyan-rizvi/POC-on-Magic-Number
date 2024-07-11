static void MagicNumber()
{
    const int minPasswordLength = 7; // Magic numbers are numbers that are in the code without any meaning.
                                     // Thats why we need to name the these number so that they have meaning.
    string password;

    Console.WriteLine("Enter you password: ");
    password = Console.ReadLine();

    if (password.Length > minPasswordLength)
    {
        Console.WriteLine("Password accepted!");

    }
    else
    {
        Console.WriteLine("Re-type Password");
        MagicNumber();
    }

}
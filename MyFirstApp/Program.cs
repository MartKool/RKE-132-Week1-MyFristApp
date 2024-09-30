// See https://aka.ms/new-console-template for more information

// rakendus küsib kasutajalt sisestada nimi
// rakendus tervitab nime pidi


Console.WriteLine("Enter your name");
// sõne-string
string userName;

userName = Console.ReadLine();
Console.WriteLine("Hello"+", "+userName+"!");

// string interpolation
Console.WriteLine($"Hello {userName}!");
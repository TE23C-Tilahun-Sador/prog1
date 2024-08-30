string name;

string age;

string country;

short

Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.Black;
Console.Clear();

Console.WriteLine("Skriv in ditt namn: ");
name = Console.ReadLine();

Console.WriteLine("Hur gammal är du?: ");
age = Console.ReadLine(); 

Console.WriteLine("Vilket land du ifrån: ");
country = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Yellow;
// Console.WriteLine("Hello " + name + "!");
Console.WriteLine($"Hello {name} från {country}! Du är {age} år gammal.");
                  
Console.ReadLine();



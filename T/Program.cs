// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string name = Console.ReadLine();

// Console.WriteLine(name);

// SayHello();

string a = AskYesNo("Are you stupid?");

if (a == "y")
{
  Console.WriteLine("GOOD");
}

Console.ReadLine();

static void SayHello()
{
  Console.WriteLine("HELLO");
}

static string AskYesNo(string questionText)
{
  Console.WriteLine(questionText);
  Console.WriteLine("[y/n]");

  string answer = Console.ReadLine().ToLower();

  return answer;
}
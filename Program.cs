ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green };
int currentColor = 0;

Console.WriteLine("Press 'W' to change color or 'Z' to exit");

char k;
do{
  k = Console.ReadKey.KeyChar;

  if(char.ToLower(k) == 'w')
  {
    currentColor = (currentColor + 1) % colors.Length;
    Console.BackgroundColor = colors[currentColor];
    Console.Clear;
  }
} while(char.ToLower(k) != 'z');

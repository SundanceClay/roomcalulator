// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a length of the classroom:");
decimal length = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter width of the classroom:");
decimal width = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Area = {length * width} ");
Console.WriteLine($"Perimeter = {length * 2 + width * 2} ");

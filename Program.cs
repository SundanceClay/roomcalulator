// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a length of the room:");
decimal length = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter width of the room:");
decimal width = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Enter height of the room:");
decimal height = Convert.ToDecimal(Console.ReadLine());
decimal area = length * width;
decimal volume = length * width * height;
Console.WriteLine($"Area = {area} ");
Console.WriteLine($"Perimeter = {length * 2 + width * 2} ");
Console.WriteLine($"Volume = {volume} ");
if (area <= 250) Console.WriteLine("Small Room");
else if (area > 250 && area < 650) Console.WriteLine("Medium Room");
else Console.WriteLine("Large Room");
Console.WriteLine($"Surface Area = { length * width * 2 + length * height * 2 + width * height * 2 }");
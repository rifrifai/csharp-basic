// See https://aka.ms/new-console-template for more information

/* Here's below is all type examples */

// var namedData = (Name: "Morning observation", Temp: 17, Wind: 14);
// var person = (FirstName: "", LastName: "");
// var order = (Product: "guitar picks", style: "triangle", quantity: 400, unitPrice: 0.50m);

// var pt = (X: 1, Y: 2);
// var slope = (double)pt.Y / (double)pt.X;
// Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.");
// pt.X += 5;
// Console.WriteLine($"The point is now {pt}.");

/* Here's below is all int examples */

int x = 2100000000;
int y = 2100000000;
// long z = checked(x + y);
long z = (long)x + (long)y;
Console.WriteLine($"The sum of {x} and {y} is {z}");

// long a = long.MaxValue;
// long b = long.MinValue;
// Console.WriteLine($"The range of LONG is {b} to {a}");

// decimal c = 1.0M;
// decimal d = 3.0M;
// Console.WriteLine(c / d);
// double a = 1.0;
// double b = 3.0;
// Console.WriteLine(a / b);

// decimal min = decimal.MinValue;
// decimal max = decimal.MaxValue;
// Console.WriteLine($"The range of DECIMAL is {min} to {max}");

// double max = double.MaxValue;
// double min = double.MinValue;
// Console.WriteLine($"The range of DOUBLE is {min} to {max}");

// double a = 5;
// double b = 4;
// double c = 2;
// double d = (a + b) / c;
// Console.WriteLine(d);

// int max = int.MaxValue;
// int min = int.MinValue;
// int what = max + 3;
// Console.WriteLine($"The range of INTEGERS is {min} to {max}");
// Console.WriteLine($"An example of overflow: {what}");

// int a = 7;
// int b = 4;
// int c = 3;
// int d = (a + b) / c;
// int e = (a + b) % c;
// Console.WriteLine($"quotient: {d}");
// Console.WriteLine($"remainder: {e}");

// int a = 5;
// int b = 4;
// int c = 2;
// int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// Console.WriteLine(d);

// int a = 15;
// int b = 10;
// int c = 5;
// Console.WriteLine((a + b) * c);

/* Here's below is all string examples */

// string songLyric = "You say goodbye, and I say Hello!";
// Console.WriteLine(songLyric.Contains("goodbye"));
// Console.WriteLine(songLyric.Contains("world"));
// Console.WriteLine(songLyric.StartsWith("You"));
// Console.WriteLine(songLyric.EndsWith("Hello!"));

// string sayHello = "Hello World!";
// Console.WriteLine(sayHello.Replace("Hello", "Hi"));

// string greeting = "    Halo Dunia!    ";
// Console.WriteLine(greeting.TrimEnd());

// string ahmad = "Ahmad Trisna";
// string rifai = "Rifai Abdurrohman";
// Console.WriteLine($"Hello {ahmad} and {rifai}");
// Console.WriteLine($"{ahmad} has {ahmad.Length} letters and {rifai} has {rifai.Length} letters");

// Console.WriteLine("Hello, World!");
// Console.ReadKey();
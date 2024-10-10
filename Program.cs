// Console.WriteLine("#1");
// string red = Console.ReadLine();
// Console.WriteLine("#2");
// string y





// Console.BackgroundColor = ConsoleColor.Red;
// Console.WriteLine($"#1 {red}");
// Console.ResetColor();x 
// int a = int.MaxValue;
// int x = byte.MaxValue;

// Console.WriteLine(a);
// Console.WriteLine(x);
// int absvalue=Math.Abs(-1);
// Console.WriteLine(absvalue);
// int value=Math.Min(10,5);
// Console.WriteLine(value);
// int value2=Math.Max(10,5);
// Console.WriteLine(value2);
// int health = 500;
// health = Math.Clamp(health,0 ,500);
// Console.WriteLine(health);

// using System.Security.Cryptography.X509Certificates;

// int x = 5;
// int y = -6;
var Input1 = 0;
var Input2 = 0;
Console.WriteLine("First number: ");
Input1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second Number");
Input2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Operator(+ , - , * , /) :");
var Operator = Console.ReadLine();

if (Operator == "+") {
    Console.WriteLine(Input1 + Input2);
} else if (Operator == "*") {
    Console.WriteLine(Input1 * Input2);
} else if (Operator == "-") {
    Console.WriteLine(Input1 - Input2);
} else if (Operator == "/") {
    Console.WriteLine(Input1 / Input2);
} else {
    Console.WriteLine("Error");
}




 
 
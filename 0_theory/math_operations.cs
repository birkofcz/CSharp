/* string firstName = "Bob";
int widgetSold = 7;
Console.WriteLine(firstName + " sold " + (widgetSold + 7) + " widgets."); */

/* int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}"); */

// $ syntax
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//operation sequence:
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

var value = 3;

Console.WriteLine("Third: " + (value++)); //prints 3 but is 4 after this line
Console.WriteLine("Third: " + (++value)); //prints 5 as it increment first then reads the value

//trasfer the value to celsius
decimal fahrenheit = 94;
decimal celsius  = (fahrenheit - 32) * (5.0m/9.0m);
Console.Write($"The temperature is {celsius} Celsius.");
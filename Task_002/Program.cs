Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Это число больше => {number1}");
}
else Console.WriteLine($"Это число больше => {number2}");

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine("Число 1 является квадратом числа 2");
}
else{
    Console.WriteLine("Число 1 не является квадратом числа 2");
}

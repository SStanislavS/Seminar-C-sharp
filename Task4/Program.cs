Console.WriteLine("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n = a;
a = -a;
while (a <= n)
{
    Console.WriteLine(a);
    a++;
}

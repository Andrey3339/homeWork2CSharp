Console.Clear();
Console.WriteLine("Введите последовательность натуральных чисел через Enter, в конце должен быть 0:  ");
int a = Convert.ToInt32(Console.ReadLine());
int max = 0;
int premax = 0;
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    max = a;
    premax = b;
}
else if (a <= b)
{
    max = b;
    premax = a;
}
while (a != 0)
{
    a = Convert.ToInt32(Console.ReadLine());
    if (a > max & a > premax)
    {
        premax = max;
        max = a;
    }
    if (a > max & a < premax)    
    {
        max = a;
    }
}
Console.WriteLine("Предмаксимальное число введенной последовательности равно:  " + premax);
Console.WriteLine("Максимальное число равно:  " + max);
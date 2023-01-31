Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int key = 0; 
int value;
for (int i = 1000000000; i >= 1; i = i / 10)
{
    value = a / i;
    if (value >=100 & value < 1000)
        {
            Console.Write($"Третья цифра этого числа равна: {value % 10}");
            key = 1;
        }
}
if (key == 0)
    Console.WriteLine("У введеного числа нет третьей цифры - оно меньше 100");
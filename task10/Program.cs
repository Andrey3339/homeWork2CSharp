Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int n1 = a / 100; 
int n2 = a - (n1 * 100); 
int n3 = n2 / 10;
Console.Write($"Вторая цифра этого числа равна: {n3}");

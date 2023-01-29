Console.Clear();
Console.Write("Введите цифру от 1 до 7:   ");
int a = int.Parse(Console.ReadLine()!);
if (a >= 1 & a <= 7)
    {
        if(a == 6 || a == 7)
            Console.WriteLine("Выходной!!!");
        else
            Console.WriteLine("Работаем, не отвлекаемся!");
    }
else
    Console.WriteLine("Вы ввели что то не то...");
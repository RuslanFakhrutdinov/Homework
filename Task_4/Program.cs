// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if(a == b && b == c)
{
    Console.WriteLine("Все эти числа равны");
}
else
{
    if(a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    if(max < c)
    {
        max = c;
    }
    Console.WriteLine($"Максимальное из этих чисел число {max}");
}
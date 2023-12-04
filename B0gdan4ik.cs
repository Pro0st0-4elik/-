Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

while(x <= y)
{
    Console.WriteLine(x);
    x++;
}
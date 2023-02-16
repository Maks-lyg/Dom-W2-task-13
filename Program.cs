Console.Clear();
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int num = 0;
if (x > 100)
{
    num = (x - (x / 100 * 100)) % 10;
    Console.WriteLine($"Третье число = {num}");
}
else
Console.WriteLine("Третьей цифры нет");
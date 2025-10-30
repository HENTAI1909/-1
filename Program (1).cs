try
{
    Console.Write("Введите A: ");
    int A = int.Parse(Console.ReadLine());
    Console.Write("Введите B: ");
    int B = int.Parse(Console.ReadLine());
    int count = 0;
    Console.WriteLine("Числа между A и B в порядке убывания:");
        for (int i = B - 1; i > A; i--)
    {
        Console.WriteLine(i);
        count++;
    }
    Console.WriteLine($"Количество чисел: {count}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
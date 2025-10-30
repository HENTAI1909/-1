//laba 1 (стр 44-49)
try
{
    for (int i = 2; i <= 100; i ++)
        if (i%2==0 && i%5==0)
        Console.WriteLine(i);   
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
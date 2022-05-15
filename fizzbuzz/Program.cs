int num = 1;
for (; num <=100; num++)
{
    if (num % 3==0 && num % 5==0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (num % 3==0)
    {
        Console.WriteLine("fizz");
    }
    else if (num % 5==0)
    {
        Console.WriteLine("buzz");
    }
    else
    {
        Console.WriteLine(num);
    }
}

string strNumbers = "123";
int numbers;
int number;

if (!int.TryParse(strNumbers, out numbers))
{
    return;
}

while (numbers > 0)
{
    if (numbers < 10)
    {
        Console.WriteLine(1);
        return;
    }

    number = numbers % 10;

    Console.WriteLine(number);

    numbers /= 10;
}
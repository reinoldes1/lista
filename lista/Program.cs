var numbers = Enumerable.Range(1, 100).ToList();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine(numbers[i]);
    }
}
Console.WriteLine("End of for");

foreach (int number in numbers)
{
    if (number % 2 == 0)
    { 
        Console.WriteLine(number); 
    }
}
Console.WriteLine("End of foreach");

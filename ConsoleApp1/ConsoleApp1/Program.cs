Console.WriteLine("category:");
string Category = Console.ReadLine();

Console.WriteLine("Hours:");
int Hours=int.Parse(Console.ReadLine());

double TotalPrice = 0;
double Amount = 0;
double Percent;

if (Category.ToLower() == "bus")
{
    Amount = 6;
    Percent = 1.215;
}else if(Category.ToLower() == "taxi")
{
    Amount = 5;
    Percent = 1.2;
}
else if (Category.ToLower() == "truck")
{
    Amount = 6.5;
    Percent = 1.25;
}
else
{
    Console.WriteLine("Category is not valid");
    return;
}

if (Hours == 1)
{
    TotalPrice += Amount;
}
else
{
    TotalPrice += Amount;
    TotalPrice += (Hours-1)* (Amount * Percent);
}

for (int i = 0; i < Hours; i++)
{
    if (i == 0)
    {
        TotalPrice += Amount;
    }
    else
    {
        TotalPrice += Amount * Percent;
    }
}
Console.WriteLine($"TotalPrice : {TotalPrice}");


static void ShowFibonacciSeriesNumber(int level)
{   
    int firstNumber = 0;
    int secondNumber = 1;
    Console.Write(firstNumber + " , " + secondNumber+ " , ");
    int sum;
    for (int i = 2; i < level; i++)
    {
        sum = firstNumber   + secondNumber;
        firstNumber = secondNumber;
        secondNumber = sum; 
        Console.Write(secondNumber + " ");
    }
}


static bool IsAbundant(int number)
{
    int sum=0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0) sum += i;
    }
    if (sum > number)
    {
        return true; 
    }
    return false;
}








//Testing

ShowFibonacciSeriesNumber(10);

int number=56;
bool status=IsAbundantNumber(number);
Console.WriteLine("Abundant ="+ status);


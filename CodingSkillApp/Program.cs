

static void ShowFibonacciSeriesNumber(int level)
{
    int firstNumber = 0;
    int secondNumber = 1;
    Console.Write(firstNumber + " , " + secondNumber + " , ");
    int sum;
    for (int i = 2; i < level; i++)
    {
        sum = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = sum;
        Console.Write(secondNumber + " ");
    }
}


static bool IsAbundant(int number)
{
    int sum = 0;
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


// program to replace all 0's with 1 in a given integer  : 

static string GetRelacedInterger(string number)
{
    string reqlacedNumber = "";
    //use the logic to replace all 0's with 1 in a given integer
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] == '0')
            reqlacedNumber += '1';
        else
            reqlacedNumber += number[i];
    }
    return reqlacedNumber;
}

//Check Whether Or Not the Number is an Automorphic Number 
// Automorphic number-  if its square ends in the same digits as the number itself.
static bool IsAutomorphicNumber(int number)
{

    int y = number * number;
    if (y % 10 == number % 10)
    {
        return true;
    }
    else
        return false;
}

//Check Whether Or Not the Number is an Perfect Number 
static bool IsPerfectNumber(int number)
{
    int sum = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sum += i;
        }
    }

    if (sum == number)
    {
        return true;
    }
    else
        return false;

}

//check whether or not the number is perfect square.
static bool isPerfectSquare(int number)
{
    if (number >= 0)
    {

        int squareRoot = (int)Math.Sqrt(number);
        Console.WriteLine(squareRoot);
        return (squareRoot * squareRoot) == number;
    }
    return false;
}





//Testing

ShowFibonacciSeriesNumber(10);

int number = 56;
bool status = IsAbundant(number);
Console.WriteLine("Abundant =" + status);

string numberToBeReplace = "540203";
string replacedNumber = GetRelacedInterger(numberToBeReplace);
Console.WriteLine(replacedNumber);

int automorphicNumber = 5;
bool statusOfAutomorphicNumber = IsAutomorphicNumber(automorphicNumber);
Console.WriteLine(statusOfAutomorphicNumber);

int perfectNumber = 5;
bool statusOfPerfectNumber = IsPerfectNumber(perfectNumber);
Console.WriteLine(statusOfPerfectNumber);

int perfectSquare = 5;
bool statusOfPerfectSquare = isPerfectSquare(perfectSquare);
Console.WriteLine(statusOfPerfectSquare);

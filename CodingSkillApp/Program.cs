

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


//find the sum of N natural numbers
static void SumOfNaturalNumebers(int number){
int sum =0;

 for(int i=1;i<=number;i++) {
        sum+=i;

 }
 Console.WriteLine(sum);
}



// Find the Sum of Numbers in a Given Range
static void SumOfNumbersGivenRange(int number1,int number2){
int sum=0;

for(int i=number1;i<=number2;i++){
       sum+=i;
}
Console.WriteLine(sum);
}



static void FindGretestNumber(int n,int b){
if(n==b){
       Console.WriteLine("Both are Equal numbers");
}

else if(n>b){
       Console.WriteLine(n + " is greter than " + b);
}

else{

Console.WriteLine(b + " is greter than " + n);
}
}



  static void DecimalToOctal(int num){
    int octal =0;
    int rem ,i=1;

    while(num!=0){

        rem=num%8;
        num=num/8;
        octal += rem * i;
        i=i*10;
    }
    Console.WriteLine(octal);
  }


  //Check if a Number is Positive or Negative 
static void CheckNumberPositiveOrNegative(int number){
if (number < 0)
{
    System.Console.WriteLine("The given number is negative");
}
else if (number > 0)
{
    System.Console.WriteLine("The number is positive");
}
else
{
    System.Console.WriteLine("The number is zero");
}
}

//Check if a Number is even or odd.
static void CheckNumberEvenOrOdd(int number)
{
    if (number % 2 == 0)
    {
        System.Console.WriteLine("The given number is even");
    }
    else
    {
        System.Console.WriteLine("The given number is odd");
    }
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



SumOfNaturalNumebers(3);
SumOfNumbersGivenRange(4,6);
FindGretestNumber(4,6);
DecimalToOctal(25);
CheckNumberPositiveOrNegative(-2);
CheckNumberEvenOrOdd(13);


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

static string RelaceData(string data, char from, char to)
{
    string replacedData = "";
    //use the logic to replace  character
     for (int i = 0; i < data.Length; i++)
    {
        if (data[i] == from)
            replacedData += to;
        else
            replacedData += data[i];
    }
    return replacedData;
}

//Check Whether Or Not the Number is an Automorphic Number 
// Automorphic number-  if its square ends in the same digits as the number itself.
static bool IsAutomorphicNumber(int number)
{
    int squareNumber= number * number;
    if (squareNumber % 10 == number % 10)
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


static bool IsGreater(int number1,int number2){
    bool status=false;
    if(number1>number2){
    status=true;
    }
    return status;
}

static int DecimalToOctal(int decimalNumber){
    int octal =0;
    int reminder ,digit=1;
    while(decimalNumber!=0){

        reminder=decimalNumber%8;
        decimalNumber=decimalNumber/8;
        octal += reminder * digit;
        digit=digit*10;
    }
    return octal;
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

static void AreaOfCircle(float radius){

     float areaOfCircle=3.14f * radius * radius;
     Console.WriteLine(areaOfCircle);
  }




//Testing

ShowFibonacciSeriesNumber(10);

int number = 56;
bool status = IsAbundant(number);
Console.WriteLine("Abundant =" + status);


// sum of digits in a number
static int GetSum(int number){
int num=1234;
int sum =0;

    while(num!=0){
        sum += num % 10;
        num = num/10;            
    }
    return sum;   
}

 static int ConvertToOctal(long number)
    {
        int i = 0;
        int dec = 0;
        int baseValue = 8;

        // Converting octal to decimal
        while (number != 0)
         {
            int digit = (int)(number % 10);
            dec += digit * (int)Math.Pow(baseValue, i);

            number /= 10;
            i++;
        }
        return dec;
    }

 static int ConvertToDecimal(long num)
    {
        int i = 0, decimalNumber = 0;

        // Converting binary to decimal
        while (num != 0)
        {
            int digit = (int)(num % 10);
            decimalNumber += digit * (int)Math.Pow(2, i);

            num /= 10;
            i++;
        }

        return decimalNumber;
    }

//find the reverse of a number
static int GetReverseNumber(int number){
int num=1234;
int reverse =0;
int rem;

    while(num!=0){
        rem= num % 10;
        reverse=reverse*10+rem;
        num/=10;            
    }
    return reverse;   
}

//Highest Common Factor(HCF)
static int GetHighestCommonFactor(){
int num1 = 12;
int num2 = 36;
int HCF = 1;

    for(int i=1; i<=num1 && i<=num2; i++ ){
        if(num1%i==0 && num2%i==0){
            HCF=i;
        }
    }
    return HCF;
}

// Calculate the number of digits in an integer

static int GetSumOfDigits(){
int num =1234;
int digit =0;
    while(num>0){
        digit++;
        num=num/10;
    }
    return digit;
}


// string numberToBeReplace = "540203";
// string replacedNumber = GetRelacedInterger(numberToBeReplace);
// Console.WriteLine(replacedNumber);

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
//FindGretestNumber(4,6);
DecimalToOctal(25);
CheckNumberPositiveOrNegative(-2);
CheckNumberEvenOrOdd(13);



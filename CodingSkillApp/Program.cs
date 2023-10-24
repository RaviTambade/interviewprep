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
//Sum of factors should be the same number

static bool IsPerfectNumber(int number)
{
    bool status=false;
    int sumOfFactors = 0;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sumOfFactors += i;
        }
    }
    if (sumOfFactors == number)
    {
       status=true;;
    }
    return status;
}

//check whether or not the number is perfect square.
static bool IsPerfectSquare(int number)
{
    bool status=false;
    if (number >= 0)
    {
        int squareRoot = (int)Math.Sqrt(number);
        int square=squareRoot * squareRoot;
        if(square == number)
        status=true;
    }
    return status;
}


//find the sum of natural numbers till number

static int SumOfNaturalNumbersTillNumber(int number){
    int sum =0;
    for(int i=1;i<=number;i++) {
            sum+=i;
    }
    return sum;
}


// Find the Sum of Numbers in a Given Range
static int  SumOfNumbersGivenRange(int number1,int number2){
    int sum=0;
    for(int i=number1;i<=number2;i++){
        sum+=i;
    }
    return sum;
}


static bool IsGreater(int number1,int number2){
    bool status=false;
    if(number1>number2){
    status=true;
    }
    return status;
}

static int ConvertDecimalToOctal(int decimalNumber){
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

static int ConvertOctalToDecimal(long number)
{
    int i = 0;
    int decimalNumber= 0;
    int baseValue = 8;

    while (number != 0)
    {
        int digit = (int)(number % 10);
        int octalPowerValue=(int)Math.Pow(baseValue, i);
        decimalNumber=decimalNumber+ digit * octalPowerValue;
        number=number/ 10; //(number/=10)
        i++;
    }
    return decimalNumber;
}

 static int ConvertBinaryToDecimal(long number)
{
    int i = 0;
    int decimalNumber = 0;
    while (number != 0)
    {
        int digit = (int)(number % 10);
        decimalNumber += digit * (int)Math.Pow(2, i);
        number /= 10;
        i++;
    }
    return decimalNumber;
}



//Check if a Number is Positive or Negative 
static bool IsNegative(int number){
    bool status=false;
    if(number < 0)
    status=true;
    return status;
}

// sum of digits in a number
static int GetSumOfDigit(int number){
int num=1234;
int sum =0;

    while(num!=0){
        sum += num % 10;
        num = num/10;            
    }
    return sum;   
}

 
//find the reverse of a number
static int GetReverseNumber(int number){
    int reverse =0;
    int reminder;
    while(number!=0){
        reminder= number % 10;
        reverse=reverse*10+reminder;
        number/=10;            
    }
    return reverse;   
}

//Highest Common Factor(HCF)
static int GetHighestCommonFactor(int number1, int number2){
    int hcf;
    for(int i=1; i<=number1 && i<=number2; i++ ){
        int reminder1=number1%i;
        int reminder2=number2%i;
        if(reminder1==0 && reminder2==0){
            hcf=i;
        }
    }
    return hcf;
}

// Calculate the number of digits in an integer

static int GetCountOfDigits(int number){
int digit=0;
   while(number>0){
    digit++;
    number=number/10;
}
    return digit;
}




//Testing

ShowFibonacciSeriesNumber(10);

int number = 56;
bool status = IsAbundant(number);
Console.WriteLine("Abundant =" + status);


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
// CheckNumberPositiveOrNegative(-2);
// CheckNumberEvenOrOdd(13);



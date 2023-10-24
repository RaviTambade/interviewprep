

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

//testing getsum function
int sumofnumber = GetSum(1234);
Console.WriteLine("sum of number:"+sumofnumber);

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

//testing getreversenumber function
int reverseNumber = GetSum(1234);
Console.WriteLine("reverse number:"+reverseNumber);

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

// testing GetHighestCommonFactor
int highestCommonFactor=GetHighestCommonFactor();
Console.WriteLine("HCF is:"+highestCommonFactor);

// quadrants in which a given coordinates lies
static void quadrant()
{
int x = 1;
int y = 2;

Console.WriteLine("Insert the value for variable X and Y : " +x +" ," +y);

if(x>0 && y>0)
   Console.WriteLine("point: " + x +"," +y+" lies in the first quadrant");

else if(x<0 && y>0)
   Console.WriteLine("point: " + x +"," +y+" lies in the second quadrant");

else if(x<0 && y<0)
   Console.WriteLine("point: " + x +"," +y+" lies in the third quadrant");
   
else if(x>0 && y<0)
   Console.WriteLine("point: " + x +"," +y+" lies in the forth quadrant");
  
else if(x==0 && y==0)
   Console.WriteLine("point: " + x +"," +y+" lies in origin");

else if(x!=0 && y==0)
   Console.WriteLine("point: " + x +"," +y+" lies in x-axis");

else if(x==0 && y!=0)
   Console.WriteLine("point: " + x +"," +y+" lies in y-axis");
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
int sumofdigit = GetSumOfDigits();
Console.WriteLine("size of integer is:"+sumofdigit);


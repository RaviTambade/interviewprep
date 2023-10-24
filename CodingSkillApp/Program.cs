﻿

using System.Reflection.Emit;

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

static bool prime_or_not(int a) {
  int i;
  bool is_prime = true;
  if (a == 0 || a == 1) {
    is_prime = false;
  }
  for(i = 2; i <= a/2; ++i) {
    if(a % i == 0) {
      is_prime = false;
      break;
    }
  }
  return is_prime;
}


static  int convert_HexaToDeci(string num)
{
    int len = num.Length;
    int dec = 0, index = 0,i;
    
    for(i = len - 1; i >= 0; i--)
    {
        // Here we check if current array char is between (0-9)
        if (num[i] >= '0' && num[i] <= '9') 
        {
            // whenever current num[i] is in range '0' - '9' 
            // ascii int value can be fetched 
            // by subtracting 48 (Refer Ascii table) as ASCII val 0 : 48 
            int digit = Convert.ToInt32(num[i]) - 48; 
            dec += Convert.ToInt32(digit * Math.Pow(16, index)); 
            index++; 
        } 

        // Here we check if current array char is between (A-F) 
        else if (num[i] >= 'A' && num[i] <= 'F') 
        { 
            // whenever current num[i] is in range 'A' - 'F' 
            // ascii int value can be fetched 
            // by subtracting 55 (Refer Ascii table) as 
            // ASCII val A : 65 and A must result 10 as value 
            int digit = Convert.ToInt32(num[i]) - 55; 
            dec += Convert.ToInt32(digit * Math.Pow(16, index)); 
            index++; 
        } 
    } 
    return dec; 
} 

static void findRootsOfQudraticEquestion(int a, int b, int c)
{
    if (a == 0) {
        Console.WriteLine("Invalid");
        return;
         } 
         int d = b * b - 4 * a * c; 
         double sqrt_val = Math. Sqrt(Math.Abs(d));
          if (d > 0) {
        Console.WriteLine("Roots are real and different \n");
         Console.WriteLine((double)(-b + sqrt_val) / (2 * a));
          Console.WriteLine((double)(-b - sqrt_val) / (2 * a));
    }
    else if (d == 0) {
       Console.WriteLine("Roots are real and same \n");
        Console.WriteLine((double)b / (2 * a));
    }
    else // d < 0
    {
        Console.WriteLine( "Roots are complex \n");
        Console.WriteLine((double)b / (2 * a) );
        Console.WriteLine(" + i" );
        Console.WriteLine( sqrt_val); 
        Console.WriteLine((double)b / (2 * a) );
        Console.WriteLine(" - i"); 
        Console.WriteLine( sqrt_val);
    }
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

 static int ConvertOctalToDecimal(long number)
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

 static void ConvertBinaryToDecimal(int binaryNumber){
int n=0;
int decimalNumber=0;
while(binaryNumber > 0){
    int temp= binaryNumber %10;
    decimalNumber +=(int) (temp*Math.Pow(2,n));
    binaryNumber= binaryNumber / 10;
    n++;
}
System.Console.WriteLine(decimalNumber);
}

static void ConvertDecimalToBinary(int decimalNumber){
string binaryNumber = "";
while (decimalNumber > 0)
{
    int remainder = decimalNumber % 2;
    binaryNumber = remainder + binaryNumber;
    decimalNumber = decimalNumber / 2;
}
Console.WriteLine(binaryNumber);
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

static int GetCountOfDigits(int number){
int digit=0;
   while(number>0){
    digit++;
    number=number/10;
}
    return digit;
}

//prime number with recursion    

bool isPrime(int number, int i = 2)
{
    // Base conditions
    if (number <= 2) return (number == 2) ? true : false; if (number % i == 0) return false; if (i * i > number)
       return true;

    return isPrime(number, i + 1);           //function calls itselfs
}







static void CheckHarshadNumber(int number)
{
    string numberString=number.ToString();
    int[] digits=numberString.Select(a=>int.Parse(a.ToString())).ToArray();
    int digitSum=digits.Sum();
     if (number % digitSum == 0)
    {
        System.Console.WriteLine("Harshad Number");
    }
    else
    {
        System.Console.WriteLine("Not a Harshad Number");
    }
}

// remove duplicate element from array
    static int[] RemoveDuplicates(int[] array)
    {
        HashSet<int> uniqueSet = new HashSet<int>();
        List<int> uniqueList = new List<int>();

        foreach (int item in array)
        {
            if (uniqueSet.Add(item)) // If the item is added to the HashSet, it's unique.
            {
                uniqueList.Add(item); // Add the unique item to the list.
            }
        }

        return uniqueList.ToArray();
    }

//last non-zero digit in factorial
static int factorial(int n){
    if(n<=1)
    return 1;
    return n*factorial(n-1);
}
int n =4;
int fact = factorial(n);
while(fact%10==0){
   fact/=10;
}

// Smallest Element of the array using Recursion 
static int SmallestNumber(int number,int[] arr){
if(number==1)
return arr[0];
return Math.Min(arr[number-1], SmallestNumber(number-1, arr));
}
int[] arr={10,2,3,4,5,9};
int number = arr.Length;
Console.WriteLine("Smallest Element is: "+ SmallestNumber(number, arr));



//Toggle each character in a String e.g VedANt=>vEDanT
 static string ToggleStringCase(string input)
    {
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLower(characters[i]))
            {
                characters[i] = char.ToUpper(characters[i]);
            }
            else if (char.IsUpper(characters[i]))
            {
                characters[i] = char.ToLower(characters[i]);
            }
        }

        return new string(characters);
    }




//Count possible decoding of a given digit sequence 
static void Decode(int number){
    //number=121
    int i=0;
    int count =1;
    while(number>9){
        i=number%100;
        if(i<=26){
            count++;
        }
        number=number/10;
    }
    System.Console.WriteLine(count);
}


static void SortArray(int [] arr){
   int temp=0;
   for(int i=0;i<arr.Length;i++){
    for (int j=i+1;j<arr.Length;j++){
        if(arr[i] > arr[j]){
            temp =arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
        }
    }  
   }
   for(int i=0;i<arr.Length;i++){
    System.Console.WriteLine(arr[i]+ "");
   }  
Array.Sort(arr);
for(int i=0;i<arr.Length;i++){
    System.Console.WriteLine(arr[i]);
}
}

int[] myArray = { 60, 50, 30, 40 };



//Finding Maximum scalar product of two vectors in an array
static void FindMaximumProduct(){
int [] arr1=new int[] {11,16,13,12};
int [] arr2=new int[] {12,11,10,15};
Array.Sort(arr1);
Array.Sort(arr2);
int product=0;
for(int i=0;i<arr1.Length;i++){
    product += arr1[i]*arr2[i];
}
Console.WriteLine(product);
}

    
//ShowFibonacciSeriesNumber(10);

// int number = 56;
// bool status = IsAbundant(number);
// Console.WriteLine("Abundant =" + status);


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

int number = 3;
    if (isPrime(number))
       Console.WriteLine("Prime Number");
    else{       
        Console.WriteLine("not prime numer");
    }


ConvertBinaryToDecimal(1010);
CheckHarshadNumber(42);
Decode(121);
SortArray(myArray);
FindMaximumProduct();

//Testing Prime OR Not

int a, i;
  bool flag = false;
  Console.WriteLine("Enter a positive  integer: ");
  a = Convert.ToInt32(Console.ReadLine());
  for(i = 2; i <= a/2; ++i) {
    if (prime_or_not(i)) {
      if (prime_or_not(a - i)) {
        Console.WriteLine(a + " = " + i + " + " + Convert.ToInt32(a-i));
        flag = true;
      }
    }
  }
  if (!flag)
     Console.WriteLine( a +" can't be expressed as sum of two prime numbers.");

     //equilibrium index of array

    public static int equilibriumPoint(long arr[], int n) {
        long totalSum = 0;
        long leftSum = 0;

        for (int i = 0; i < n; i++) {
            totalSum += arr[i];
        }

        for (int i = 0; i < n; i++) {
            totalSum -= arr[i];

            if (leftSum == totalSum) {
                return i + 1; // Equilibrium point found at index i
            }

            leftSum += arr[i];
        }

        return -1; // No equilibrium point found
    }
    
    //string palidrome
    
	
	bool isPal(string str){
	int front =0;
 	int end=str.Length-1;
	while(front<end){
	 if(str[front]!=str[end])
	return false;
	front++;
	end--;
    }
    return true;
    }
   

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


// Title :Abundant number
//Coder :Akash Ajab


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

//Topic : Can a number be expressed as a sum of two prime numbers(For this program need follwing fn)
//Coder : Shubhangi
static bool prime_or_not(int a)
{
    int i;
    bool is_prime = true;
    if (a == 0 || a == 1)
    {
        is_prime = false;
    }
    for (i = 2; i <= a / 2; ++i)
    {
        if (a % i == 0)
        {
            is_prime = false;
            break;
        }
    }
    return is_prime;
}

//Topic:  Hexadecimal to Decimal conversion
//Coder : Shubhangi
static int convert_HexaToDeci(string num)
{
    int len = num.Length;
    int dec = 0, index = 0, i;

    for (i = len - 1; i >= 0; i--)
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

//Coder : Shubhangi
//ax²+bx+c=0
static void findRootsOfQudraticEquestion(int a, int b, int c)
{
    if (a == 0)
    {
        Console.WriteLine("Invalid");
        return;
    }
    int d = b * b - 4 * a * c;
    double sqrt_val = Math.Sqrt(Math.Abs(d));
    if (d > 0)
    {
        Console.WriteLine("Roots are real and different \n");
        Console.WriteLine((double)(-b + sqrt_val) / (2 * a));
        Console.WriteLine((double)(-b - sqrt_val) / (2 * a));
    }
    else if (d == 0)
    {
        Console.WriteLine("Roots are real and same \n");
        Console.WriteLine((double)b / (2 * a));
    }
    else // d < 0
    {
        Console.WriteLine("Roots are complex \n");
        Console.WriteLine((double)b / (2 * a));
        Console.WriteLine(" + i");
        Console.WriteLine(sqrt_val);
        Console.WriteLine((double)b / (2 * a));
        Console.WriteLine(" - i");
        Console.WriteLine(sqrt_val);
    }
}

//Topic : Find all the N bit binary numbers having more than or equal 1’s than 0’s
//Coder : Shubhangi


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
//title:Check Whether Or Not the Number is an Automorphic Number
//coder:Vedant Yadav 
// Automorphic number-  if its square ends in the same digits as the number itself.
static bool IsAutomorphicNumber(int number)
{
    int squareNumber = number * number;
    if (squareNumber % 10 == number % 10)
    {
        return true;
    }
    else
        return false;
}

//Title: Check Whether Or Not the Number is an Perfect Number 
//Coder: Vedant Yadav
//Sum of factors should be the same number
static bool IsPerfectNumber(int number)
{
    bool status = false;
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
        status = true; ;
    }
    return status;
}

//Title: check whether or not the number is perfect square.
//Coder: Vedant Yadav
static bool IsPerfectSquare(int number)
{
    bool status = false;
    if (number >= 0)
    {
        int squareRoot = (int)Math.Sqrt(number);
        int square = squareRoot * squareRoot;
        if (square == number)
            status = true;
    }
    return status;
}


//Title :find the sum of natural numbers till number
// Coder:Akash Ajab
static int SumOfNaturalNumbersTillNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}


//Title : Find the Sum of Numbers in a Given Range
//Coder : Akash Ajab
static int SumOfNumbersGivenRange(int number1, int number2)
{
    int sum = 0;
    for (int i = number1; i <= number2; i++)
    {
        sum += i;
    }
    return sum;
}


//Title :Greatest of two numbers
//Coder :Akash Ajab
static bool IsGreater(int number1, int number2)
{
    bool status = false;
    if (number1 > number2)
    {
        status = true;
    }
    return status;
}

//Title :Decimal to Octal Conversion
//Coder : Akash Ajab
static int ConvertDecimalToOctal(int decimalNumber)
{
    int octal = 0;
    int reminder, digit = 1;
    while (decimalNumber != 0)
    {
        reminder = decimalNumber % 8;
        decimalNumber = decimalNumber / 8;
        octal += reminder * digit;
        digit = digit * 10;
    }
    return octal;
}

//
static int ConvertOctalToDecimal(long number)
{
    int i = 0;
    int decimalNumber = 0;
    int baseValue = 8;

    while (number != 0)
    {
        int digit = (int)(number % 10);
        int octalPowerValue = (int)Math.Pow(baseValue, i);
        decimalNumber = decimalNumber + digit * octalPowerValue;
        number = number / 10; //(number/=10)
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
static bool IsNegative(int number)
{
    bool status = false;
    if (number < 0)
        status = true;
    return status;
}








// Title:sum of digits in a number
//Coader:Pragati
static int GetSumOfDigit(int number)
{
    int num = 1234;
    int sum = 0;

    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

//  static int ConvertOctalToDecimal(long number)
//     {
//         int i = 0;
//         int dec = 0;
//         int baseValue = 8;

//         // Converting octal to decimal
//         while (number != 0)
//          {
//             int digit = (int)(number % 10);
//             dec += digit * (int)Math.Pow(baseValue, i);

//             number /= 10;
//             i++;
//         }
//         return dec;
//     }

//  static void ConvertBinaryToDecimal(int binaryNumber){
// int n=0;
// int decimalNumber=0;
// while(binaryNumber > 0){
//     int temp= binaryNumber %10;
//     decimalNumber +=(int) (temp*Math.Pow(2,n));
//     binaryNumber= binaryNumber / 10;
//     n++;
// }
// System.Console.WriteLine(decimalNumber);
// }

static void ConvertDecimalToBinary(int decimalNumber)
{
    string binaryNumber = "";
    while (decimalNumber > 0)
    {
        int remainder = decimalNumber % 2;
        binaryNumber = remainder + binaryNumber;
        decimalNumber = decimalNumber / 2;
    }
    Console.WriteLine(binaryNumber);
}


//Title:find the reverse of a number
//Coader:Pragati
static int GetReverseNumber(int number)
{
    int reverse = 0;
    int reminder;
    while (number != 0)
    {
        reminder = number % 10;
        reverse = reverse * 10 + reminder;
        number /= 10;
    }
    return reverse;
}

//Title:Highest Common Factor(HCF)
//Coader:Pragati
static int GetHighestCommonFactor(int number1, int number2)
{
    int hcf = 1;
    for (int i = 1; i <= number1 && i <= number2; i++)
    {
        if (number1 % i == 0 && number2 % i == 0)
        {
            hcf = i;
        }
    }
    return hcf;
}

// Calculate the number of digits in an integer
//Coader:Pragati
static int GetCountOfDigits(int number)
{
    int digit = 0;
    while (number > 0)
    {
        digit++;
        number = number / 10;
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


//Title:Check the given number is harshad or not eg.42 is harshad numbers because 4 + 2=6 and 42 is divide by 6 . 
//Coder:Abhay Navale

//Topic : Sort first half in ascending order and second half in descending
//Coder : Shubhangi
void ascDecFunc(int[] a, int n)
{
   int temp;
   for(int i=0;i < n-1;i++)
   {
     for(int j = 0;j < n/2; j++) 
     {
            if(a[j]>a[j+1])
           {
             temp=a[j];
             a[j]=a[j+1];
             a[j+1]=temp;
           }
      }
   }
}


static void CheckHarshadNumber(int number)
{
    string numberString = number.ToString();
    int[] digits = numberString.Select(a => int.Parse(a.ToString())).ToArray();
    int digitSum = digits.Sum();
    if (number % digitSum == 0)
    {
        System.Console.WriteLine("Harshad Number");
    }
    else
    {
        System.Console.WriteLine("Not a Harshad Number");
    }
}

//Title: remove duplicate element from array,
//Coder: Vedant Yadav
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
//Title:last non-zero digit in factorial
//Coader:Pragati
static int factorial(int n)
{
    if (n <= 1)
        return 1;
    return n * factorial(n - 1);
}

int n = 4;
int fact = factorial(n);
while (fact % 10 == 0)
{
    fact /= 10;
}

// Title:Smallest Element of the array using Recursion
//Coader:Pragati
static int SmallestNumber(int number, int[] arr)
{
    if (number == 1)
        return arr[0];
    return Math.Min(arr[number - 1], SmallestNumber(number - 1, arr));
}

int[] arr = { 10, 2, 3, 4, 5, 9 };
int number = arr.Length;
Console.WriteLine("Smallest Element is: " + SmallestNumber(number, arr));



//Title: Toggle each character in a String e.g VedANt=>vEDanT
//Coder: Vedant Yadav
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


//Title:Count possible decoding of a given digit sequence  eg:121 so (1,2,1),(12,1),(1,21)  
//Coder:Abhay Navale
static void Decode(int number)
{
    //number=121
    int i = 0;
    int count = 1;
    while (number > 9)
    {
        i = number % 100;
        if (i <= 26)
        {
            count++;
        }
        number = number / 10;
    }
    System.Console.WriteLine(count);
}

//Title:Sort the elements of an array 
//Coder:Abhay Navale
static void SortArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i] + "");
    }
    // Array.Sort(arr);
    // for(int i=0;i<arr.Length;i++){
    //     System.Console.WriteLine(arr[i]);
    // }
}


//Title:Finding Maximum scalar product of two vectors in an array
//Coder:Abhay Navale
static void FindMaximumProduct()
{
    int[] arr1 = new int[] { 11, 16, 13, 12 };
    int[] arr2 = new int[] { 12, 11, 10, 15 };
    Array.Sort(arr1);
    Array.Sort(arr2);
    int product = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        product += arr1[i] * arr2[i];
    }
    Console.WriteLine(product);
}




// public static int equilibriumPoint(long arr[], int n) {
//     long totalSum = 0;
//     long leftSum = 0;

//     for (int i = 0; i < n; i++) {
//         totalSum += arr[i];
//     }

//     for (int i = 0; i < n; i++) {
//         totalSum -= arr[i];
//         if (leftSum == totalSum) {
//             return i + 1; // Equilibrium point found at index i
//         }
//         leftSum += arr[i];
//     }

//     return -1; // No equilibrium point found
// }

//string palidrome


bool isPal(string str)
{
    int front = 0;
    int end = str.Length - 1;
    while (front < end)
    {
        if (str[front] != str[end])
            return false;
        front++;
        end--;
    }
    return true;
}

//Title:Calculates the power
//Coder:Abhay Navale

// static int Power(int base, int power)
// {
//     int result = 1;
//     while (power > 0)
//     {
//         result = result * base;
// static int Power(int base,int power){
//     int result=1;
//     while(power > 0){
//         result=result*base;

//         power--;
//     }
//     return result;
// }

//Title:Check if two strings match where one string contains wildcard characters 
//Coder:Abhay Navale
// static bool IsStringMatching(string inputString, string stringWithWildCards)
// {
//     string regexPattern = Regex.Escape(stringWithWildCards).Replace("//*", ".*");
//     return Regex.IsMatch(inputString, stringWithWildCards);
// }

//Title: Reverse an Array
//Coder: Vedant Yadav
static int[] ReverseArray(int[] array)
{
    int length = array.Length;
    int[] reversedArray = new int[length];

    for (int i = length - 1, j = 0; i >= 0; i--, j++)
    {
        reversedArray[j] = array[i];
    }

    return reversedArray;
}
//Title: calculate length of the string using recursion
//Coder: Vedant Yadav   
static int CalculateLengthOfString(string input)
{
    Console.WriteLine(input);
    // if we reach at the end of the string
    if (input.Equals(""))
        return 0;
    else
        return CalculateLengthOfString(input.Substring(1)) + 1;
}

//Title : Check Two Strings are Anagram or Not
//Coder : Vedant Yadav
//An anagram of a word is a different words that uses the same letters, just in a different order. e.g vedaNt - nTveda
static bool IsAnagram(string input1, string input2)
{
    string result1 = new string(input1.Where(c => !char.IsWhiteSpace(c)).ToArray());
    string result2 = new string(input2.Where(c => !char.IsWhiteSpace(c)).ToArray());
    bool status = true;

    if (result1.Length != result2.Length)
    {
        status = false;
    }
    else
    {
        char[] charectersInResult1 = result1.ToLower().ToCharArray();
        char[] charectersInResult2 = result2.ToLower().ToCharArray();
        Array.Sort(charectersInResult1);
        Array.Sort(charectersInResult2);
        if (charectersInResult1.SequenceEqual(charectersInResult2))
        {
            status = true;
        }
    }

    return status;
}

//Title:-Left Rotation of element of array
//coder:-Rohit Mangale
static int[] LeftRotate(int[] arr)
{
    int[] rotated = new int[arr.Length];
    int elementToRotate = arr[0];
    for (int i = 0; i < (arr.Length - 1); i++)
    {
        arr[i] = arr[i + 1];
        rotated.Append(arr[i]);
    }
    arr[(arr.Length - 1)] = elementToRotate;
    rotated.Append(arr[arr.Length - 1]);
    return rotated;
}

//Title:-Right Rotation of element of array
//coder:-Rohit Mangale
static int[] RigthRotate(int[] arr)
{
    int[] rotated = new int[arr.Length];
    int x = arr[(arr.Length - 1)];
    for (int i = (arr.Length - 1); i > 0; i--)
    {
        arr[i] = arr[i - 1];
        rotated.Append(arr[i]);
    }

    arr[0] = x;
    rotated.Append(arr[0]);
    return rotated;

}



//ShowFibonacciSeriesNumber(10);

// int number = 56;
// bool status = IsAbundant(number);
// Console.WriteLine("Abundant =" + status);


// string numberToBeReplace = "540203";
// string replacedNumber = GetRelacedInterger(numberToBeReplace);
// Console.WriteLine(replacedNumber);

// int automorphicNumber = 5;
// bool statusOfAutomorphicNumber = IsAutomorphicNumber(automorphicNumber);
// Console.WriteLine(statusOfAutomorphicNumber);


 
 //Title:Given an integer N the task is to print the F(N)th term
 //Coder :Akash Ajab
 
 static int term(int calculated,int current , int num){
    int i=0;
    int result =0;

// int perfectNumber = 5;
// bool statusOfPerfectNumber = IsPerfectNumber(perfectNumber);
// Console.WriteLine(statusOfPerfectNumber);

    while(current!=num+1){
        int cur =1;
      for(i=calculated;i<calculated+current;i++)
      cur *= i; 
      calculated=i;
      result += cur;
      current++;  
      
    }
    return result;

}



//Title :Recursively Remove all Adjacent Duplicate Characters
//coder : Akash Ajab
static string RemoveAdjacentDuplicates(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length == 1)
        {
            return input;
        }

        char[] result = new char[input.Length];
        int resultIndex = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1 && input[i] == input[i + 1])
            {
                // Skip adjacent duplicates.
                while (i < input.Length - 1 && input[i] == input[i + 1])
                {
                    i++;
                }
            }
            else
            {
                result[resultIndex++] = input[i];
            }
            ;
        }
       string newString = new string(result, 0, resultIndex);

        // Recursively remove adjacent duplicates until no more can be found.
        if (newString.Length < input.Length)
        {
            return RemoveAdjacentDuplicates(newString);
        }

        return newString;
    }


  //Title :program to find the frequency of elements in an array
  //Coder :Akash Ajab.
    static void FindFrequencyOfElement(){

        int[] arr= {10,20,30,10,20,30,40,10};

        Dictionary<int,int> frequency = new Dictionary<int, int>();

        foreach(int element in arr){
            if(frequency.ContainsKey(element)){
                frequency[element]++;
            }

            else{

                frequency[element]=1;
            }

            
        }

        foreach(var kvp in frequency){
                Console.WriteLine($"Element{kvp.Key} appears {kvp.Value}");
            }

    }



    //Title :program to count numbers of even and odd elements in an array
    //Coder :Akash Ajab
    static void FindCountOfNumberInArray(){

        int[] arr= {10,10,11,23,15,45,12,13,15};
        int odd_count=0;
        int even_count=0;
        for(int i=0; i<arr.Length;i++){

            if(arr[i]%2==0){
                even_count++;
            }
            else{
                odd_count++;
            }
        }
        Console.WriteLine( $"Even number count{even_count} and odd number count{odd_count}");
    }

   
   FindCountOfNumberInArray();
   FindFrequencyOfElement();
        // string input = "abbaca";
        // string result = RemoveAdjacentDuplicates(input);
        // Console.WriteLine("Original string: " + input);
        // Console.WriteLine("String with adjacent duplicates removed: " + result);

// int perfectNumber = 5;
// bool statusOfPerfectNumber = IsPerfectNumber(perfectNumber);
// Console.WriteLine(statusOfPerfectNumber);

// // int perfectSquare = 5;
// // bool statusOfPerfectSquare = isPerfectSquare(perfectSquare);
// // Console.WriteLine(statusOfPerfectSquare);



// SumOfNaturalNumebers(3);
SumOfNumbersGivenRange(4, 6);
//FindGretestNumber(4,6);
// DecimalToOctal(25);
// CheckNumberPositiveOrNegative(-2);
// CheckNumberEvenOrOdd(13);

// // int number = 3;
// //     if (isPrime(number))
// //        Console.WriteLine("Prime Number");
// //     else{       
// //         Console.WriteLine("not prime numer");
// //     }


//  ConvertBinaryToDecimal(1010);
//   CheckHarshadNumber(42);
// Decode(121);
// SortArray(myArray);
// FindMaximumProduct();

 //Testing Prime OR Not

// int a, i;
//   bool flag = false;
//   Console.WriteLine("Enter a positive  integer: ");
//   a = Convert.ToInt32(Console.ReadLine());
//   for(i = 2; i <= a/2; ++i) {
//     if (prime_or_not(i)) {
//       if (prime_or_not(a - i)) {
//         Console.WriteLine(a + " = " + i + " + " + Convert.ToInt32(a-i));
//         flag = true;
//       }
//     }
//   }
//   if (!flag)
//      Console.WriteLine( a +" can't be expressed as sum of two prime numbers.");

     //equilibrium index of array




int num = 3;

Console.WriteLine("F(3) "+term(1, 1, num));


ConvertBinaryToDecimal(1010);
CheckHarshadNumber(42);
Decode(121);
int[] myArray = { 60, 50, 30, 40 };
SortArray(myArray);
FindMaximumProduct();
// int base=5;
// int power = 3;
// int result = Power(base, power);
// System.Console.WriteLine(result);

// Testing to check whether a number can be expressed as a sum of two prime numbers

int a, i;
bool flag = false;
Console.WriteLine("Enter a positive  integer: ");
a = Convert.ToInt32(Console.ReadLine());
for (i = 2; i <= a / 2; ++i)
{
    if (prime_or_not(i))
    {
        if (prime_or_not(a - i))
        {
            Console.WriteLine(a + " = " + i + " + " + Convert.ToInt32(a - i));
            flag = true;
        }
    }
}
if (!flag)
    Console.WriteLine(a + " can't be expressed as sum of two prime numbers.");

//equilibrium index of array


// string inputString = "HelloWorld";
// string stringWithWildCards = "Hello*World";
// bool isMatch = IsStringMatching(inputString, stringWithWildCards);
// if (isMatch)
// {
//     Console.WriteLine("The strings match.");
// }
// else
// {
//     Console.WriteLine("The strings do not match.");
// }



//Find Smallest Element in an Array
static int SmallestNumberInArray()
{
    int[] numbers = { 34, 4, 89, 90, 56 };
    int n = numbers.Length;
    int mini = int.MaxValue;

    for (int i = 0; i < n; i++)
    {
        if (numbers[i] < mini)
            mini = numbers[i];
    }
    return mini;
}
//topic:print the string in reverse order
//coder:omkar sudrik
//  public static string StrRev(string str)
//         {
//             string str, str1 = ""; 
//             int i,l;
// 			 l = str.Length-1;
//             for (i=l;i>=0;i--)
//             {
//              str1 = str1 + str[i];
//                 }

//            	return str1;

//         }
//topic:remove all character in string except alphabet
//coder:omkar sudrik
 static string RemoveSpecialCharacter(string s)
         {
        string ans = "";
        foreach(char ch in s)
        {
            if (Char.IsLetter(ch))
                ans += ch;
        }
        return ans;
    }
//topic:remove space from string
//coder:omkar sudrik
static string RemoveWhiteSpace(string source)
{
    return source.Trim();
}
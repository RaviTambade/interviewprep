
using System.Collections;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

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
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n / 2; j++)
        {
            if (a[j] > a[j + 1])
            {
                temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
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
//Title:Calculate Sum of the numbers in array
//Coder:Shubham Teli

static int CalculateSum()
{
    int[] arr = { 10, 10, 20, 30, 60 };
    int length = arr.Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = sum + arr[i];
    }
    Console.WriteLine(sum);
    return sum;
}

//Remove Duplicates In Array using HashSet 
//Coder:Shubham Teli.

static int RemoveDuplicatesInArray(int[] arr)
{
    HashSet<int> uniqueSet = new HashSet<int>();
    List<int> uniqueList = new List<int>();

    foreach (int num in arr)
    {
        if (uniqueSet.Add(num))
        {
            uniqueList.Add(num);
        }
    }
    uniqueList.CopyTo(arr);
    foreach (int i in uniqueList)
    {
        Console.WriteLine(i + "\n");
    }
    Console.WriteLine("\n");

    Console.WriteLine(uniqueList.Count);

    return uniqueList.Count;
}

// Testing
//int[] arr = { 10, 50, 30, 10, 2, 50, 30, 10 };

RemoveDuplicatesInArray(arr);



//Print length of string whithout using .length Function.
//Coder:Shubham Teli.


//Initializing variable
string str;
int length = 0;

// Accepting input
Console.WriteLine("Enter a string:");
str = Console.ReadLine();

// Manually counting the length without using Length property
foreach (var ch in str)
{
    Console.WriteLine(ch + " ");
    length++; // Counting the length

}
Console.WriteLine("\nLength of input string: " + length);


//Title:Calculate LCM of the given two Numbers
//Coder:Shubham Teli

static int LCMUsingRecursion(int n1, int n2)
{
    return FindLCM(n1, n2, 1);
}


static int FindLCM(int n1, int n2, int lowestLCM)
{
    if (lowestLCM % n1 == 0 && lowestLCM % n2 == 0)
    {
        return lowestLCM;
    }
    else
    {
        return FindLCM(n1, n2, lowestLCM + 1);
    }
}

// Testing 

//   Console.Write("Enter the first number: ");
//     int n1 = int.Parse(Console.ReadLine());

//     Console.Write("Enter the second number: ");
//     int n2 = int.Parse(Console.ReadLine());

//     int result = LCM(n1, n2);

//     Console.WriteLine($"LCM of {n1} and {n2} is {result}");


//Title: Check if the current element is a duplicate in array
//Coder:Shubham Teli

static int RemoveDuplicatesNumber(){

    
    int[] arr = { 10, 20, 20, 30, 40, 40, 40, 50, 50,20,10 };
        int length = arr.Length;
    {
        if (length == 0 || length == 1)
            return length;

        int j = 0;
        for (int i = 0; i < length; i++)
        {
            bool isDuplicate = false;

            // Check if the current element is a duplicate of any previous element
            for (int k = 0; k < i; k++)
            {
                if (arr[i] == arr[k])
                {
                    isDuplicate = true;
                    break;
                }
            }

            // If it's not a duplicate, add it to the array
            if (!isDuplicate)
            {
                arr[j++] = arr[i];
Console.Write(arr[i]+ " ");

            }
        }
//  Console.WriteLine(j);
        return j;
    }
}


//Title:Calculate Equal no of the given Array
//Coder:Shubham Teli

static int EqualNumbers()

    {
        int[] a = { 50, 49, 100 };
        int length = a.Length;
        for (int i = 0; i < length; i++)
        {
            // Divide number by 2
            while (a[i] % 2 == 0)
                a[i] /= 2;

            // Divide number by 3
            while (a[i] % 3 == 0)
                a[i] /= 3;

            if (a[i] != a[0])
            {
                return 0;
            }
        }

        return 1;
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



// 	bool isPal(string str){
//         int front =0;
//         int end=str.Length-1;
//         while(front<end){
//             if(str[front]!=str[end])
//         }

// bool isPal(string str){
//     int front =0;
//     int end=str.Length-1;
//     while(front<end){
//         if(str[front]!=str[end])

//     }

//     return -1; // No equilibrium point found
// }

//string palidrome


// bool isPal(string str)
// {
//     int front = 0;
//     int end = str.Length - 1;
//     while (front < end)
//     {
//         if (str[front] != str[end])
//             return false;
//         front++;
//         end--;
//     }
//     return true;
// }

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

// Title:Check if two strings match where one string contains wildcard characters 
// Coder:Abhay Navale
// static bool IsStringMatching(string inputString, string stringWithWildCards)
// {
//     string regexPattern = Regex.Escape(stringWithWildCards).Replace("//*", ".*");
//     return Regex.IsMatch(inputString, stringWithWildCards);
// }

// static int Power(int base, int power)
// {
//     int result = 1;
//     while (power > 0)
//     {
//         result = result * base;
//         power--;
//     }
//     return result;
// }



// static int Power(int base, int power)
//     int result = 1;
//     while (power > 0)
//     {
//         result = result * base;
//         power--;
//     }
//     return result;
// }

// static int Power(int base, int power)
//     int result = 1;
//     while (power > 0)
//     {
//         result = result * base;
//         power--;
//     }
//     return result;
// }


//Title:Check if two strings match where one string contains wildcard characters 
//Coder:Abhay Navale
static bool IsStringMatching(string inputString, string stringWithWildCards)
{
    string regexPattern = Regex.Escape(stringWithWildCards).Replace("//*", ".*");
    return Regex.IsMatch(inputString, stringWithWildCards);
}

//Title: Reverse an Array
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


    //Title:-Removing vowels from line
    //coder:-Rohit Mangale
    static string RemoveVowels(string line)
    {
        var letters = new HashSet<char>(line);
        string modifiedString = "";
        letters.ExceptWith("AaEeIiOoUu");
        modifiedString = new string(letters.ToArray());
        return modifiedString;

    }

    arr[0] = x;
    rotated.Append(arr[0]);
    return rotated;

}
//Title:-Shorting of Array
//coder:-Rohit Mangale
static int[] ShortArray(int[] arr)
{

    // Sort array in ASC order
    Console.WriteLine();
    Console.WriteLine("Sorted array in ASC order");
    Array.Sort(arr);
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    Console.WriteLine("Sorted array in DESC order");
    // Sort Array in DESC order
    Array.Reverse(arr);
    foreach (int i in arr)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    return arr;
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

static int term(int calculated, int current, int num)
{
    int i = 0;
    int result = 0;

    // int perfectNumber = 5;
    // bool statusOfPerfectNumber = IsPerfectNumber(perfectNumber);
    // Console.WriteLine(statusOfPerfectNumber);

    while (current != num + 1)
    {
        int cur = 1;
        for (i = calculated; i < calculated + current; i++)
            cur *= i;
        calculated = i;
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


//Title :program to count numbers of even and odd elements in an array
//Coder :Akash Ajab
static void FindCountOfNumberInArray()
{

    int[] arr = { 10, 10, 11, 23, 15, 45, 12, 13, 15 };
    int odd_count = 0;
    int even_count = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] % 2 == 0)
        {
            even_count++;
        }
        else
        {
            odd_count++;
        }
    }
    Console.WriteLine($"Even number count{even_count} and odd number count{odd_count}");
}


//Title:Finding Circular rotation of an array by K positions 
//Coder :Akash Ajab
void GetCircularArr(int[] myarray, int d, int n)
{
    for (int i = 0; i < d; i++)
    {
        int temp = myarray[0];
        Console.WriteLine(temp);
        for (int j = 0; j < n - 1; j++)
        {
            myarray[j] = myarray[j + 1];
            Console.WriteLine(myarray[j]);
        }
        myarray[n - 1] = temp;
        Console.WriteLine(temp);

        // Print the array in curly brace format
        Console.Write("{ ");
        for (int k = 0; k < myarray.Length; k++)
        {
            Console.Write(myarray[k]);
            if (k < myarray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(" }");
    }
}



int[] myarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

GetCircularArr(myarray, 2, myarray.Length);


FindCountOfNumberInArray();
//FindFrequencyOfElement();
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

Console.WriteLine("F(3) " + term(1, 1, num));


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

//Title:find longest palindrome number in array
//coader:pragati
static int FindLongestPalindrome()
{
    int IsPalindrome(int number)
    {
        int reverse = 0;
        int temp = number; // Store the original number for comparison
        while (number > 0)
        {
            int remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number = number / 10;
        }
        return temp == reverse ? 1 : 0;
    }
    int[] numbers = { 124, 374, 989, 1221 };
    int n = numbers.Length;
    int maxPalindrome = -1;
    for (int i = 0; i < n; i++)
    {
        if (IsPalindrome(numbers[i]) == 1 && numbers[i] > maxPalindrome)
        {
            maxPalindrome = numbers[i];
        }
    }
    if (maxPalindrome == -1)
    {
        Console.WriteLine("No palindromic numbers found.");
    }
    else
    {
        Console.WriteLine("The longest palindromic number is: " + maxPalindrome);
    }
    return maxPalindrome;
}

//check whether Character is a vowel or consonant
//coader:pragati 
static bool IsLowerCase(char c)
{
    return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
}

static bool IsUpperCase(char c)
{
    return (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
}

char c = 'p';
if (IsLowerCase(c) || IsUpperCase(c))
{
    Console.WriteLine(c + " is a vowel");
}
else if (!char.IsLetter(c))
{
    Console.WriteLine("Non alphabate");
}

else
{
    Console.WriteLine(c + " is a consonent");
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
    foreach (char ch in s)
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

// Title:Count the sum of numbers in a string
//coader=pragati
static int FindSumOfDigitsInString(string strings){
  int sum =0;
 foreach(char ch in strings){
  if(char.IsDigit(ch)){
    sum+= ch-'0';
  }
 }
 return sum;
}
string strings="2dg5ds46";

//Title:Find if there is any subarray with sum equal to 0
//coader=pragati
static bool findSum(int[] numbers){
 int flag=0;
 int sum=0;
 for(int i=0; i<numbers.Length; i++){
  for(int j=i ;j<numbers.Length; j++ ){
    sum+=numbers[j];
    if(sum==0){
      flag=1;
      break;
    }
    else{
      flag=0;
      break;
    }
  }
 }
  if(flag==1){
    return true;
  }
  return false;
 }

int[] numbers ={0,0,9,8,7};


bool status = findSum(numbers);
Console.WriteLine(status);
 



//topic:Number is Palindrom or not
//coder:Rushikesh Chikane.
static void Palindrom()
{
    int num = 12021, reverse = 0, rem, temp;
    temp = num;
    while (temp != 0)
    {
        rem = temp % 10;
        reverse = reverse * 10 + rem;
        temp /= 10;
    };
    // palindrome if num and reverse are equal
    if (num == reverse)
        Console.WriteLine(num + " is Palindrome");
    else
        Console.WriteLine(num + " is not Palindrome");
}
//Palindrom();

//topic: Armstrong Number
//coder: Rushikesh Chikane.

static void Armstrongnum()
{
    Console.WriteLine("Enter Number :");
    int num = int.Parse(Console.ReadLine()); 
    int len;
    // function to get order(length)
    len = Order(num);
    // check if Armstrong
    if (Armstrong(num, len))
        Console.WriteLine(num + " is armstrong");
    else
        Console.WriteLine(num + " is not an armstrong");

    static int Order(int num)
    {
        int len = 0;
        while (num != 0)
        {
            len++;
            num = num / 10;
        }
        return len;
    }

    static bool Armstrong(int num, int len)
    {
        int sum = 0, temp, digit;
        temp = num;

        // loop to extract digit, find power & add to sum
        while (temp != 0)
        {
            // extract digit
            digit = temp % 10;
            // add power to sum
            sum = sum + (int)Math.Pow(digit, len);
            temp /= 10;
        };

        return num == sum;
    }

}
//Armstrongnum();



static void Armstrong()
{
    int num = 153;
    int rem;
    int cube;
    int result = 0;
    int temp = num;

    while (num != 0)
    {
        rem = num % 10;
        cube = rem * rem * rem;
        result = result + cube;
        num = num / 10;
    }
    num = temp;

    if (num == result)
        Console.WriteLine(num + " is armstrong");
    else
        Console.WriteLine(num + " is not an armstrong");
}
//Armstrong();



//topic: Armstrong Number between tow intervals(in given range)
//coder: Rushikesh Chikane.


static int GetOrder(int num)
{
    int len = 0;
    while (num != 0)
    {
        len++;
        num = num / 10;
    }
    return len;
}
static void Armstrongs()
{

    Console.WriteLine("Enter lower and upper ranges : ");
    int low = int.Parse(Console.ReadLine());
    int high = int.Parse(Console.ReadLine());

    Console.WriteLine("Armstrong numbers between " + low + " and " + high + " are : ");

    // loop for finding and printing all armstrong numbers between given range
    for (int num = low; num <= high; num++)
    {
        int sum = 0, temp, digit, len;

        len = GetOrder(num);
        temp = num;
        // loop to extract digit, find ordered power of digits & add to sum
        while (temp != 0)
        {
            // extract digit
            digit = temp % 10;
            // add power to sum
            sum = sum + (int)Math.Pow(digit, len);
            temp /= 10;
        };

        if (sum == num)
            Console.Write(num + " ");
    }
}
//armstrongs();

//topic: LCM (Lowest Common Factorial)
//coder: Rushikesh Chikane.

static void LCM()
{
    int num1 = 36, num2 = 60, lcm = 0;
    // finding the larger number here
    int max = (num1 > num2) ? num1 : num2;

    // LCM will atleast be >= max(num1, num2)
    // Largest possibility of LCM will be num1*num2
    for (int i = max; i <= num1 * num2; i++)
    {
        if (i % num1 == 0 && i % num2 == 0)
        {
            lcm = i;
            break;
        }
    }
    Console.WriteLine("\n" + "The LCM: " + lcm);
}
// LCM();


//topic: Permutations in which n people can occupy r seats in a classroom
//coder: Rushikesh Chikane.

static void PermatutationPeopleOccupySeats()
{
    int n, r, per, fact1, fact2;
    Console.WriteLine("Enter the Value of n: ");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the Value of r: ");
    r = int.Parse(Console.ReadLine());
    fact1 = 1;
    for (int i = n; i > 1; i = i - 1)
    {
        fact1 = fact1 * i;  //calculating factorial (n!)
    }
    int number;
    number = n - r;
    fact2 = 1;
    for (int i = number; i > 1; i = i - 1)
    {
        fact2 = fact2 * i;  //calculating factorial ((n-r)!)
    }
    per = fact1 / fact2;  //calculating  nPr
    Console.WriteLine(per + " ways");
}
//PermatutationPeopleOccupySeats();


//topic: Program to convert Digits/Numbers to Words
//coder: Rushikesh Chikane.

static void ConvertToWwords(char[] num)
{
    int len = num.Length;
    // Base cases
    if (len == 0)
    {
        Console.WriteLine("empty string");
        return;
    }
    if (len > 4)
    {
        Console.WriteLine(
            "Length more than 4 is not supported");
        return;
    }
    string[] SingleDigits = new string[] {
            "zero", "one", "two",   "three", "four",
            "five", "six", "seven", "eight", "nine"
        };

    string[] TwoDigits = new string[] {
            "",          "ten",      "eleven",  "twelve",
            "thirteen",  "fourteen", "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen"
        };

    string[] TensMultiple = new string[] {
            "",      "",      "twenty",  "thirty", "forty",
            "fifty", "sixty", "seventy", "eighty", "ninety"
        };

    string[] TensPower = new string[] { "hundred", "thousand" };

    Console.Write(new string(num) + ": ");
    if (len == 1)
    {
        Console.WriteLine(SingleDigits[num[0] - '0']);
        return;
    }
    int x = 0;
    while (x < num.Length)
    {
        if (len >= 3)
        {
            if (num[x] - '0' != 0)
            {
                Console.Write(SingleDigits[num[x] - '0'] + " ");
                Console.Write(TensPower[len - 3] + " ");

            }
            --len;
        }
        else
        {
            if (num[x] - '0' == 1)
            {
                int sum
                    = num[x] - '0' + num[x + 1] - '0';
                Console.WriteLine(TwoDigits[sum]);
                return;
            }
            else if (num[x] - '0' == 2
                     && num[x + 1] - '0' == 0)
            {
                Console.WriteLine("twenty");
                return;
            }
            else
            {
                int i = (num[x] - '0');
                if (i > 0)
                    Console.Write(TensMultiple[i] + " ");
                else
                    Console.WriteLine("");
                ++x;
                if (num[x] - '0' != 0)
                    Console.Write(SingleDigits[num[x] - '0']);
            }
        }
        ++x;
    }
}
// Driver Code
//convert_to_words("1121".ToCharArray());

//topic: Reversing a Number using Recursion
//coder: Rushikesh Chikane.

static void Reverse(int num)
{
    // base condition to end recursive calls
    if (num < 10)
    {
        Console.WriteLine(num);
        return;
    }
    else
    {
        // print the unit digit of the given number
        Console.Write(num % 10);
        // calling function for remaining number other than unit digit
        Reverse(num / 10);
    }
}

// driver code
static void ReverseNum(int num)
{
    // number to be reversed
    Console.WriteLine("Enter Number for Revrsing :");
    num = int.Parse(Console.ReadLine());

    Console.Write("Reversed Number: ");
    // calling recursive function to print the number in reversed form
    Reverse(num);
}
//ReverseNum(num);  



//topic: Find the Nth row in Pascal’s Triangle
//coder: Rushikesh Chikane.

static List<int> GetRow(int rowIndex)
{
    List<int> currow = new List<int>();

    currow.Add(1);

    if (rowIndex == 0)
    {
        return currow;
    }

    List<int> prev = GetRow(rowIndex - 1);

    for (int i = 1; i < prev.Count; i++)
    {
        int curr = prev[i - 1] + prev[i];
        currow.Add(curr);
    }
    currow.Add(1);

    return currow;
}

static void PascalsTriangle(int n)
{
    Console.WriteLine("Enter a Number For Pascals Triangle:");
    n = int.Parse(Console.ReadLine());

    List<int> arr = GetRow(n);

    for (int i = 0; i < arr.Count; i++)
    {
        if (i == arr.Count - 1)
            Console.Write(arr[i]);
        else
            Console.Write(arr[i] + ", ");
    }
}
//PascalsTriangle(n);

//topic: Program to find Largest and Smallest Element in an Array
//coder: Rushikesh Chikane.

static void FindingSamllAndLagerstNumberFromArray(int[] arry)
{

    int n = arry.Length;

    int smallest = int.MaxValue;
    int largest = int.MinValue;

    for (int i = 0; i < n; i++)
    {
        if (smallest > arry[i])
            smallest = arry[i];
        if (largest < arry[i])
            largest = arry[i];
    }

    Console.WriteLine("Smallest Number: " + smallest);
    Console.WriteLine("Largest Number: " + largest);
}

int[] arry = { 10, 67, 89, 78, 34, 2, 95 };
//FindingSamllAndLagerstNumberFromArray(arry);  


//topic: Program to find Distinct Element In Array
//coder: Rushikesh Chikane.

static void DistinctElementFromArray(int[] array)
{

    int n = array.Length;

    int[] visited = new int[n];
    int count_dis = 0;

    for (int i = 0; i < n; i++)
    {
        if (visited[i] != 1)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (array[i] == array[j])
                {
                    visited[j] = 1;
                }
            }
            count_dis++;
        }
    }
    Console.WriteLine(count_dis);
}

int[] array = { 10, 30, 10, 20, 40, 20, 50, 10 };
//DistinctElementFromArray(array);


//topic: program to find Arrays are disjoint or not
//coder: Rushikesh Chikane.


static bool Disjoint(int[] arr1, int[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = 0; j < arr2.Length; j++)
        {
            if (arr1[i] == arr2[j])
            {
                return false;
            }
        }
    }
    return true;
}
static void DisjointOrNot(int[] arr1, int[] arr2)
{
    if (Disjoint(arr1, arr2))
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}
int[] arr1 = { 10, 51, 3, 43, 6 };
int[] arr2 = { 80, 71, 29, 3 };
//DisjointOrNot(arr1,arr2);


//topic: program to check a character is an alphabet or not
//coder: Rushikesh Chikane.

static void AlphabeOrNot()
{
    char ch;
    ch = 'a';

    //condition for checking characters
    if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
        Console.WriteLine("The inserted character " + ch + " is an Alphabet");
    else
        Console.WriteLine("The inserted character " + ch + " is not an Alphabet");
}
//AlphabeOrNot();


//quadrants in which a given coordinate lies

static void FindQuadrants(int x,int y){
if(x>0 && y>0){
   Console.WriteLine("point: " + x +"," +y+" lies in the first quadrant");
}
else if(x<0 && y>0){
   Console.WriteLine("point: " + x +"," +y+" lies in the second quadrant");
}
else if(x<0 && y<0){
   Console.WriteLine("point: " + x +"," +y+" lies in the third quadrant");
}
else if(x>0 && y<0){
   Console.WriteLine("point: " + x +"," +y+" lies in the forth quadrant");
}
else if(x==0 && y==0){
   Console.WriteLine("point: " + x +"," +y+" lies in origin");
}
else if(x!=0 && y==0){
   Console.WriteLine("point: " + x +"," +y+" lies in x-axis");
}
else if(x==0 && y!=0){
   Console.WriteLine("point: " + x +"," +y+" lies in y-axis");
}
}
//FindQuadrants(1,-2);

//find maximum product subarray in a given array

int[] numberArray = { 10, -20, -30, 0, 70, -80, -20 };
    int p= numberArray.Length;
    int result = numberArray[0];
    
    for (int k = 0; k < n; k++)
    {
        int mul = numberArray[k];
        // traversing in current subarray
        for (int j = k + 1; j < n; j++) { // updating result every time // to keep an eye over the // maximum product 
                if(mul>result)
                result = mul;
            mul *= numberArray[j];
        }
        if(mul>result)
            result = mul;
    }
    Console.WriteLine(result);


//topic: Find Repeating element of an array
// Given an array, print all element whose frequency is not equal to one.
//coder:Sahil Mankar
void FindRepetedElementsInArray()
{
    
    int[] arr = new int[] { 10, 30, 30, 20, 10, 20, 50, 10 };
    Dictionary<int, int> dict = new Dictionary<int, int>();

    foreach (var element in arr)
    {
        if (dict.ContainsKey(element))
        {
            dict[element]++;
        }
        else
        {
            dict[element] = 1;
        }
    }
    Console.WriteLine($"Repeted elemnts in array are");

    foreach (var element in dict)
    {
        if (element.Value > 1)
        {
            Console.Write($" {element.Key} ,");
        }
    }
}

//array is a subset of another array
/*
 Example
arr1 = {1,2,3,4,5}  , arr2 = {3,4,5}
arr2 is a subset of arr1 (As, arr1 contains all the elements of arr2)
arr3 = {1,2,3,4,5}   arr4 = {1,2,9}
arr4 is not a subset of arr3 (As, arr3 do not contains all the elements of arr4).
 */
//coder:Sahil Mankar


void ArrayIsSubSetArray()
{
    int[] arr1 = { 11, 10, 13, 21, 30, 70 };
    int[] arr2 = { 11, 30, 70, 10, 12 };

    for (int i = 0; i < arr2.Length; i++)
    { // i itrets over arr2
        int j;
        for (j = 0; j < arr1.Length; j++)
        { // j itrets over arr1
            if (arr2[i] == arr1[j])
                break;
        }

        if (j == arr1.Length) // this condition hit when any element is not present in arr1
        {
            Console.WriteLine("arr2[] is not subset of arr1[] ");
            return;
        }
    }
    Console.WriteLine("arr2[] is  subset of arr1[] ");
}

//ASCII Value of character
//coder:Sahil Mankar

void ASCIIValueOfCharacter()
{
    char c = 'a';
    int ASCIIValue = c;
    Console.WriteLine($"ASCII Value of Character {c} is {ASCIIValue}");
}

// Factorial of a Number
//coder:Sahil Mankar

void GetFactorial()
{
    int fact = 1;
    int n = 5;
    if (n < 0)
    {
        Console.WriteLine("Factorial for Negative Number dosent Exist");
    }
    for (int i = 2; i <= n; i++)
    {
        fact = fact * i;
    }
    Console.WriteLine($"Factorial of {n} is {fact}");
}

// topic : frequency of character in string
//coder:Sahil Mankar


void FrequencyOfCharacterInString()
{
    string str = "sahil";
    Dictionary<char, int> dict = new Dictionary<char, int>();

    foreach (char ch in str)
    {
        if (dict.ContainsKey(ch))
        {
            dict[ch]++;
        }
        else
        {
            dict[ch] = 1;
        }
    }
    Console.WriteLine($"Characters  in string with Coressponding frequencies are");

    foreach (var ch in dict)
    {
        Console.WriteLine($" {ch.Key} = {ch.Value}");
    }
}

// GCD(Greatest Common Divisor) or HCF(Highest Common Factor) of two numbers
//is the number which is the largest common factor of both numbers.
//It is also referred as Greatest Common Factor(GCF),
//Greatest Common Measure(GCM), Highest Common Divisor(HCD).

//coder:sahil mankar

void GetGCDByLoop()
{
    int num1 = 36;
    int num2 = 60;
    int gcd = 0;

    for (int i = 1; i <= num1 && i <= num2; i++)
    {
        Console.WriteLine("count" + i);
        if (num1 % i == 0 && num2 % i == 0)
            gcd = i;
    }

    Console.WriteLine("The GCD is: " + gcd);
}

void GetGCDByRepetedSubstraction()
{
    int num1 = 36,
        num2 = 60,
        hcf;

    while (num1 != num2)
    {
        if (num1 > num2)
            num1 -= num2;
        else
            num2 -= num1;
    }

    Console.WriteLine("The HCF: " + num1);
}


//program to find the number of days in a given month of a given year
//coder:sahil mankar

void GetNumberOfMonths(){
      int month=2, year = 2012;
        switch (month) {
            // Cases for 31 Days
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
           Console.WriteLine("Number of days is 31");
            break;
  
            // Cases for 30 Days
            case 4:
            case 6:
            case 9:
            case 11:
           Console.WriteLine("Number of days is 30");
            break;
  
            // Case for 28/29 Days
            case 2:
                if((year%400==0) || ((year%100!=0)&&(year%4==0)))
                   Console.WriteLine("Number of days is 29");
                else
                Console.WriteLine("Number of days is 28");
            break;
  
            default:
           Console.WriteLine("Invalid Month.");
            break;
        }
}


//find the second smallest element in an array
//coder:sahil mankar

void FindSecondSmallestElementInArray(){
int[] numbers = { 5, 8, 2, 10, 3, 1, 9, 4, 7, 6 };

int smallest = int.MaxValue;
int secondSmallest = int.MaxValue;

foreach (int num in numbers)
{
    if (num < smallest)
    {
        secondSmallest = smallest;
        smallest = num;
    }
    
    else if (num < secondSmallest && num != smallest)
    {
        secondSmallest = num;
    }
}

if (secondSmallest == int.MaxValue)
{
    Console.WriteLine("There is no second smallest element.");
}
else
{
    Console.WriteLine("The second smallest element is: " + secondSmallest);
}
}

// Maximum number of handshakes
// The given program will find the maximum number of handshakes in a room.
//Suppose there are N persons in a room. We have to find the maximum number of Handshakes
// possible. Given the fact that any two persons shake hand only once.
//coder:sahil mankar

void GenrateHandShakes()
{
    int num = 3;

    int total = num * (num - 1) / 2; // Combination nC2 n!/(n-2)!2!

    Console.WriteLine("For " + num + " people there will be " + total + " handshakes");
}

// Find common elements in three Sorted Arrays
//coder:sahil mankar

void FindCommonElementInThreeArray()
{
    int[] arr1 = { 1, 5, 10, 20, 40, 80 };
    int[] arr2 = { 6, 7, 20, 80, 100 };
    int[] arr3 = { 3, 4, 15, 20, 30, 70, 80, 120 };

    int i = 0,
        j = 0,
        k = 0;
    Console.WriteLine("Common element in array");
    while (i < arr1.Length && j < arr2.Length && k < arr3.Length)
    {
        if (arr1[i] == arr2[j] && arr2[j] == arr3[k])
        {
            Console.WriteLine(arr1[i]+",");
            i++;
            j++;
            k++;
        }
        else if (arr1[i] < arr2[j])
        {
            i++;
        }
        else if (arr2[j] < arr3[k])
        {
            j++;
        }
        else
        {
            k++;
        }
    }
}

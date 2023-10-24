

using System.Reflection.Emit;

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








//Testing

//ShowFibonacciSeriesNumber(10);

//int number=56;
//bool status=IsAbundantNumber(number);
//Console.WriteLine("Abundant ="+ status);

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
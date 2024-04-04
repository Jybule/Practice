using System;

public class Program
{
    public static void Main()
    {
        // Примеры использования функций
        int sumResult = SumOfTwoNumbers(10, 20);
        Console.WriteLine(sumResult); // Вывод: 30

        double areaResult = AreaOfCircle(5);
        Console.WriteLine(areaResult); // Пример радиуса 5. Вывод: 78.53975

        int length = StringLength("Hello");
        Console.WriteLine(length); // Вывод: 5

        int[] numbers = { 10, 20, 30, 40, 50 };
        int maxValue = FindMaxValue(numbers);
        Console.WriteLine(maxValue); // Вывод: 50

        long factorialResult = Factorial(5);
        Console.WriteLine(factorialResult); // Вывод: 120

        bool isPalindrome = IsPalindrome("madam");
        Console.WriteLine(isPalindrome); // Вывод: True

        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 6 };
        int[] combinedArray = CombineArrays(arr1, arr2);
        foreach (int num in combinedArray)
        {
            Console.Write(num + " "); // Вывод: 1 2 3 4 5 6
        }

        bool isPrime = IsPrime(7);
        Console.WriteLine(isPrime); // Вывод: True

        string reversedString = ReverseString("hello");
        Console.WriteLine(reversedString); // Вывод: olleh

        int[][] twoDArray = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
        int sum = SumOfElementsIn2DArray(twoDArray);
        Console.WriteLine(sum); // Вывод: 10
    }

    public static int SumOfTwoNumbers(int a, int b)
    {
        return a + b;
    }

    public static double AreaOfCircle(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static int StringLength(string input)
    {
        return input.Length;
    }

    public static int FindMaxValue(int[] array)
    {
        return array.Max();
    }

    public static long Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }

    public static bool IsPalindrome(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        return input == reversedString;
    }

    public static int[] CombineArrays(int[] arr1, int[] arr2)
    {
        return arr1.Concat(arr2).ToArray();
    }

    public static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static int SumOfElementsIn2DArray(int[][] array)
    {
        int sum = 0;
        foreach (int[] row in array)
        {
            foreach (int num in row)
            {
                sum += num;
            }
        }
        return sum;
    }
}
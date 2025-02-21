using System;
using System.ComponentModel;
/*
class Calculator
{
    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static int Divide(int a, int b) => b != 0 ? a / b : 0;

    static void Run()
    {
        Console.WriteLine("Input + , - , * , / or x to exit");
        string op = Console.ReadLine();

        if (op == "x") return;

        Console.WriteLine("input numbers");

        int a = Convert.ToInt32(Console.ReadLine());

        int b = Convert.ToInt32(Console.ReadLine());

        int result = op switch
        {
            "+" => Add(a, b),
            "-" => Subtract(a, b),
            "*" => Multiply(a, b),
            "/" => Divide(a, b),
            _=> 0
        };

        Console.WriteLine("Result: " + result);
        Run();
    }

    static void Main()
    {
        Run();
    }
}

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swapping: a = {a}, b = {b}");
        
        Swap(ref a, ref b);

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}

class Program
{
    static void FindMax(ref int max, params int[] numbers)
    {
        if (numbers.Length == 0)
        {
            Console.WriteLine("There is no arguments");
            return;
        }

        max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
        }
    }

    static void Main()
    {
        int max = 0;
        int[] x = new int[3];
        Console.WriteLine("Input numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        FindMax(ref max, a , b , c);
        Console.WriteLine($"Max: {max}");
    }
}

class Program
{
    static void ConvertTemperature(double celsius, out double fahrenheit, out double kelvin)
    {
        fahrenheit = (celsius * 9 / 5) + 32; 
        kelvin = celsius + 273.15;          
    }

    static void Main()
    {
        Console.WriteLine($"Input celsius");
        
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit, kelvin;
        ConvertTemperature(celsius, out fahrenheit, out kelvin);

        Console.WriteLine($"Celsius: {celsius}");
        Console.WriteLine($"Fahrenheit: {fahrenheit}");
        Console.WriteLine($"Kelvin : {kelvin}");
    }
}

class CircleCalculations
{
    
    static void CalculateCircle(double radius, ref double area, out double perimeter)
    {
        area = Math.PI * radius * radius; 
        perimeter = 2 * Math.PI * radius;
    }

    static void Main()
    {
        Console.Write("Enter the radius");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = 0;
        double perimeter;

        
        CalculateCircle(radius, ref area, out perimeter);

        Console.WriteLine($"The area : {area}");
        Console.WriteLine($"The perimeter : {perimeter}");
    }
}

class Program
{
    static void Sum(ref int s ,params int[] numbers){
        foreach(int i in numbers){
            s += i;
        }
    }
    static void Main(){
        int s = 0;
        Console.WriteLine("Input numbers");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Sum(ref s , a , b , c);
        Console.WriteLine(s);
    }
}

class QuadraticEquationSolver
{
    static void SolveQuadratic(double a, double b, double c, ref double x1, out double x2)
    {
        double discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
        {
            x1 = 0;
            x2 = 0;
          Console.WriteLine("Error : discriminant can't be below 0");
        }
        else
        {
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            x1 = (-b + sqrtDiscriminant) / (2 * a);
            x2 = (-b - sqrtDiscriminant) / (2 * a);
        }
    }

    static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double x1 = 0;
        double x2;

        SolveQuadratic(a, b, c, ref x1, out x2);
        
        Console.WriteLine($"The roots: x1 = {x1} and x2 = {x2}");
    }
}

class Program
{
    static int fib(int n){
        if (n <= 1){
            return n;
        }
        return fib(n-1) + fib(n-2);
    }
    static void Main(){
        int n = Convert.ToInt32(Console.ReadLine());
        int res = fib(n);
        Console.WriteLine($"number of fibonacci: {res}");
    }
}

class TimeConverter
{  
    static void ConvertSeconds(int totalSeconds, ref int hours, out int minutes, out int seconds)
    {
        hours = totalSeconds / 3600;             
        int remaining = totalSeconds % 3600;
        minutes = remaining / 60;         
        seconds = remaining % 60;         
    }

    static void Main()
    {
        Console.Write("Enter seconds: ");
        int totalSeconds = Convert.ToInt32(Console.ReadLine());

        int hours = 0;
        int minutes; 
        int seconds;

        ConvertSeconds(totalSeconds, ref hours, out minutes, out seconds);

        Console.WriteLine($"Results: {hours} hours, {minutes} minutes, {seconds} seconds");
    }
}
*/
class LongestWordFinder
{
    static string FindLongestWord(params string[] words)
    {
        string longest = "";
        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }
        return longest;
    }

    static void Main()
    {
        Console.Write("Enter words separated by spaces: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        string longestWord = FindLongestWord(words);

        Console.WriteLine($"Longest: {longestWord}");
    }
}
    


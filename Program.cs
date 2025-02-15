using System;
using System.Security.Cryptography;
/* class Program{
    static void Main()
   {
       int n = Convert.ToInt32(Console.ReadLine());
       int first = 0 , second = 1;
       int next = 0;
       for (int i = 1 ; i < n ; i++){
           next = first + second;
           first = second;
           second = next;
       }
       Console.WriteLine(second);
   }
}

class Program{
   static void Main(){
       int reverse = 0;
       int n = Convert.ToInt32(Console.ReadLine());
       while (n > 0){
           int digit = n % 10;
           reverse = reverse * 10 + digit;
           n /= 10;
       }
       Console.WriteLine(reverse);
   }
}

class Program {
   static void Main(){
       int s = 0;
       int n = Convert.ToInt32(Console.ReadLine());
       while (n > 0 ){
           s += n % 10;
           n /= 10;
       }
       Console.WriteLine(s);
   }
}

class Program {
   static void Main(){
       int n = Convert.ToInt32(Console.ReadLine());
       for (int i = 1 ; i <= 10 ; i++){
           int product = n * i;
           Console.WriteLine(product);
       }
   }
}

class Program {
   static void Main(){
       bool x = true;
       int n = Convert.ToInt32(Console.ReadLine());
       for (int i = 2 ; i * i <= n ; i++){
           if (n % i == 0){
               x = false;
               break;
           }
       }
       Console.WriteLine(x);
   }
}

class Program {
   static void Main(){
       int count = 0;
       int number = Convert.ToInt32(Console.ReadLine());
       while (number != 1){
           if (number % 2 == 0){
               number /= 2;
               count++;
           }
           else {
               number = 3 * number + 1;
               count++;
           }
       }
       Console.WriteLine(count);
   }
}

class Program{
   static void Main(){
       int n = 5;
       for (int i = 1 ; i <= n ; i++){
           for (int j = 1 ; j <= i ; j++){
                   Console.Write(i);
           }
           Console.WriteLine();
       }
   }
}

class Program {
    static void Main(){
        string input = Console.ReadLine();
        string longest = "";
        string current = "";

        foreach(char ch in input){
            
            if (ch != ' '){
                current += ch;
            }
            else {
                if (current.Length > longest.Length){
                    longest = current;
                }
                current = "";
            }
            if (current.Length > longest.Length){
                longest = current;
            }
        }
        Console.WriteLine(longest);
    }
}
*/
class Program {
    static void Main(){
        int PasswordLength = 8;
        char[] password = new char[PasswordLength];
        
        Random random = new Random();
        string upper = "ABCDEFGHIJKLMNOPQRSTUVWQYZ";
        string lower = "abcdefghijklmnopqrstuvwqyz";
        string digits = "123456789";
        string symbols = "!@#$%^&*()";
        string all = upper + lower + digits + symbols;
        
        password[0] = upper[random.Next(upper.Length)];
        password[1] = lower[random.Next(lower.Length)];
        password[2] = digits[random.Next(digits.Length)];
        password[3] = symbols[random.Next(symbols.Length)];

        for (int i = 4 ; i < PasswordLength ; i++){
            password[i] = all[random.Next(all.Length)];
        }
        string res = new string(password);
        Console.WriteLine(res);
    }
}
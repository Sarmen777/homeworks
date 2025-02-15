using System;
class Program{
    static void Main(){
         char[,] map =
        {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
        };

        Random random = new Random();
        map [random.Next(map.GetLength(0) - 1), random.Next(map.GetLength(1) - 1) ] = 'X';
        int userX = 5, userY = 5;
        while (map[userX, userY] != 'X'){
            for (int i = 0; i < map.GetLength(0); i ++){
                for (int j = 0; j < map.GetLength(1); j++){
                    Console.Write(map[i,j]);
                }
                System.Console.WriteLine();
            }
            Console.SetCursorPosition(userY, userX);
            Console.Write("P");
            ConsoleKeyInfo key = Console.ReadKey(); 
            switch(key.Key){
                 case ConsoleKey.UpArrow:
                    if (map[userX - 1, userY] != '#'){
                        userX --;
                    }
                    break;
                    case ConsoleKey.DownArrow:
                    if (map[userX + 1, userY] != '#'){
                        userX ++;
                    }
                    break;
                    case ConsoleKey.LeftArrow:
                    if (map[userX, userY - 1] != '#'){
                        userY --;
                        
                    }
                    break;
                    case ConsoleKey.RightArrow:
                    if (map[userX ,userY + 1] != '#'){
                        userY ++;
                        
                    }
                    break;
                    
            }
             Console.Clear();

        }
    }
}
class Program 
{
    static void Main(){
        char[] password = new char[8];
        string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lower = "abcdefghijklmnopqrstuwxyz";
        string digits = "1234567890";
        string symbols = "!@#$%^&*()<>:";
        string all = upper + lower + digits + symbols;
        char x = '\0';
        Random random = new Random();
        while(true){
            Console.WriteLine("If you want password input a , otherwise x");
            x = Convert.ToChar(Console.ReadLine());
        switch(x){
            case 'a':
        password[0] = upper[random.Next(upper.Length)];
        password[1] = lower[random.Next(lower.Length)];
        password[2] = digits[random.Next(digits.Length)];
        password[3] = symbols[random.Next(symbols.Length)];

        for (int i = 4 ; i < 8 ; i++){
            password[i] = all[random.Next(all.Length)];
        }
        for (int i = 0 ; i < 4 ; i++){
            char tmp = password[i];
            password[i] = password[8-i-1];
            password[8-i-1] = tmp;
        }
        string res = new string(password);
        Console.WriteLine(res);
        break;
            case 'x':
            return;
    }
        }
    }
        }

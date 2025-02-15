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
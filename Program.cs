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
using System;
using System.Collections;

class Contact
{
    public string Name;
    public string PhoneNumber; 
    public string Email;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Number: {PhoneNumber}");
        Console.WriteLine($"Email: {Email}");
    }
     static bool CompareStrings(string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
                return false;
        }
        return true;
    }
       static void Main()
    {
        Contact[] contacts = new Contact[3];

        for (int i = 0; i < contacts.Length; i++)
        {
            contacts[i] = new Contact();

            contacts[i].Name = Console.ReadLine();
            contacts[i].PhoneNumber = Console.ReadLine();
            contacts[i].Email = Console.ReadLine();

        }

        Console.Write("input name to search ");
        string searchName = Console.ReadLine();
        bool x = false;

        for (int i = 0 ; i < 3 ; i++)
        {       
            if (CompareStrings(searchName , contacts[i].Name)){            
                contacts[i].DisplayInfo();
                x = true;
                break;
            }
        }

        if (!x)
        {
            Console.WriteLine("there is no name like that");
        }
    }
}

class Student
{
    public string Name;
    public int Age;
    public int Grade;

    public void DisplayDetails(){
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Grade : {Grade}");
    }
   static void Main(){
        Student[] students = new Student[5];
        for (int i = 0 ; i < 5 ; i++){
            students[i] = new Student();

            students[i].Name = Console.ReadLine();
            students[i].Age = Convert.ToInt32(Console.ReadLine());
            students[i].Grade = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0 ; i < 5 ; i++){
            students[i].DisplayDetails();
        }
   } 
}

class BankAccount
{
   public string AccountNumber;
   public string HolderName;
   public int Balance;

     public BankAccount(string accountNumber, string holderName, int initialBalance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = initialBalance;
    }
   public void Deposit(int Amount){
        Balance += Amount;
        Console.WriteLine($"Your balance :{Balance}");
   }
   public void Withdraw(int Amount){
        if (Balance - Amount < 0){
            Console.WriteLine("You can't do this");
        }
        else {
            Balance -= Amount;
            Console.WriteLine($"Your balance :{Balance}");
        }
   }
   static void Main(){
         string accountNumber = Console.ReadLine();
        string holderName = Console.ReadLine();
        int initialBalance = Convert.ToInt32(Console.ReadLine());

        BankAccount account = new BankAccount(accountNumber , holderName , initialBalance);

         while (true)
        {
           Console.WriteLine("input 1 for dep , 2 for withdraw , 3 to exit");
            string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("input deposit");
                        int depositAmount = Convert.ToInt32(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;

                    case "2":
                        Console.WriteLine("input withdraw");
                        int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;

                    case "3":
                        return;

                    
                }
            }
   }

}

public class Book
     {
         private string Title;
         private string Author;
         private bool IsAvailable;

         public Book(string title, string author, bool Available)
         {
             Title = title;
             Author = author;
             IsAvailable = Available;
         }

         public bool BorrowBook(string title)
         {
             if (Title.ToLower() == title.ToLower() && IsAvailable != false)
             {
                 IsAvailable = false;
                 Console.WriteLine("you have borrowed the book");
                 return true;
             }

             Console.WriteLine("This book isn`t available!!!");
                 return false;
         }

         public void ReturnBook(string title)
         {
             IsAvailable = true;
             Console.WriteLine("You have returned the book)");
             return;
         }
         public void DisplayBooks(){
                Console.WriteLine($"Title: {Title} \n Author: {Author} \n Is Available : {IsAvailable}");
         }
        
     }

     public class Program
     {
         static void Main()
         {
             Book[] books = new Book[3]
             {
                 new Book("To Kill a Mockingbird" , "Harper Lee" , true),
                 new Book("Brave New World", "Aldous Huxley",  true),
                 new Book("A Million Mutinies Now", "V.S. Naipaul", true),
             };
                 while (true)
        {             
            Console.WriteLine ("To borrow: 1 , To return: 2 , To exit: 3");
            string input = Console.ReadLine();
            switch(input){
                case "1":
                Console.WriteLine("input the number of book");
                int index = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the title of book");
                string temp = Console.ReadLine();
                books[index-1].BorrowBook(temp);
                break;

                case "2":
                Console.WriteLine("input the number of book");
                int index1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input the title of book");
                string temp1 = Console.ReadLine();
                books[index1-1].ReturnBook(temp1);
                break;
                case "3":
                return;
                
            }
         }
         }
     }

class Product
{
    public string Name;
    public int Price;
    public int Quantity;

    public int TotalPrice()
    {
        return Price * Quantity;
    }
}

class Program
{
    static void Main()
    {
        int totalCost = 0;
        int productCount = 0;
         Product[] products = new Product[]
        {
            new Product { Name = "Product 1", Price = 100, Quantity = 0 },
            new Product { Name = "Product 2", Price = 200, Quantity = 0 },
            new Product { Name = "Product 3", Price = 50, Quantity = 0 },
        };
      
        while (true)
        {
            Console.WriteLine("To choose product 1 - 1 , for 2 - 2 , for 3 - 3 , and to exit - 4 ");
            
            int productIndex = Convert.ToInt32(Console.ReadLine());
            if (productIndex == 4) break;
            Console.Write("input quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            switch (productIndex)
            {
                case 1:
                    products[productIndex-1].Quantity = quantity;
                    totalCost += products[productIndex-1].TotalPrice();
                     productCount += quantity;
                    break;
                case 2:
                    products[productIndex-1].Quantity = quantity;
                    totalCost += products[productIndex-1].TotalPrice();
                     productCount += quantity;
                    break;
                case 3:
                    products[productIndex-1].Quantity = quantity;
                    totalCost += products[productIndex-1].TotalPrice();
                     productCount += quantity;
                    break;
            
            }
        }

        if (productCount > 5)
        {
            totalCost = totalCost * (9/10);
            Console.WriteLine("Sale 10%!");
        }

        Console.WriteLine($"Total cost: {totalCost}");
    }
}

    public class Employee
    {
        public string Name;
        public string Position;
        public int SalaryPerHour;
        public int HoursWorked;

        public Employee(string name , string position , int salary , int hours)
        {
            Name = name;
            Position  = position;
            SalaryPerHour = salary;
            HoursWorked = hours;
        }
        public int CalculateSalary(){
            if (HoursWorked > 40)
            {
                int ExtraHours = HoursWorked - 40;
                int ExtraSalary = SalaryPerHour + SalaryPerHour / 2;
                return (SalaryPerHour * 40) + (ExtraHours * ExtraSalary);
            }
            return SalaryPerHour * HoursWorked;
        }
    }
    class Program
    {
        static void Main(){

        Employee employee1 = new Employee("Sarmen Baghmanyan", "Manager", 300, 45);
        Employee employee2 = new Employee("Petros Petrosyan", "Developer", 500, 38);
        Employee employee3 = new Employee("Poghos Poghosyan", "Designer", 350, 42);
        
          Console.WriteLine($"Salary of {employee1.Name} : {employee1.CalculateSalary()}");
        Console.WriteLine($"Salary of {employee2.Name} : {employee2.CalculateSalary()}");
        Console.WriteLine($"Salary of {employee3.Name} : {employee3.CalculateSalary()}");
    }
    
    }
    
    public class MovieTicket
    {
        public string MovieName;
        public int SeatNumber;
        public bool IsBooked;

        public MovieTicket(string movieName, int seatNumber)
        {
        MovieName = movieName;
        SeatNumber = seatNumber;
        IsBooked = false;
        }
        public void BookTicket(){
            if (!IsBooked){
                Console.WriteLine($"Seat {SeatNumber} booked");
                IsBooked = true;
            }
            else
            {
                Console.WriteLine($"Seat {SeatNumber} is already booked");
            }
        }
    }
    class Program
    {
        static void Main(){
        string movie = "Interstellar";
        MovieTicket[] tickets = new MovieTicket[5];
        
        for (int i = 0 ; i < tickets.Length ; i++){
            tickets[i] = new MovieTicket(movie , i + 1);
        }
        while(true)
        {
            Console.WriteLine($"Available seats\n");
            foreach (var ticket in tickets){
                if (!ticket.IsBooked){
                    Console.WriteLine($"Seat : {ticket.SeatNumber}");
                }
            }
            Console.WriteLine("Choose seat that is available or input 0 to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0) return;
            switch(choice){
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    tickets[choice - 1].BookTicket();
                    break;
            }
        
        }

        }
    }
    
   public class Student
    {
        public string Name;
        public int Age;
        public int Grade;

        public Student (string name , int age , int grade){
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
    public class Teacher
    {
        public string Name;
        public string Subject;
        public int YearsOfExperience;

        public Teacher(string name, string subject, int yearsOfExperience)
        {
        Name = name;
        Subject = subject;
        YearsOfExperience = yearsOfExperience;
        }
    }
    public class School
    {
        public Student[] Students;
        public Teacher[] Teachers;
        public School (Student[] students , Teacher[] teachers)
        {
            Students = students;
            Teachers = teachers;
        }
        public void TopStudents(){
            int maxGrade = 0;
            foreach(var i in Students){
                if (i.Grade > maxGrade){
                    maxGrade = i.Grade;
                }
            }
            foreach(var i in Students){
                if (i.Grade == maxGrade){
                    Console.WriteLine($"{i.Name} : {i.Grade}");
                }
            }
        }
        public void NewTeachers(){
            foreach(var i in Teachers){
                if (i.YearsOfExperience < 2){
                    Console.WriteLine($"{i.Name} : {i.Subject}");
                }
            }
        }
    }
    class Program {
        static void Main(){
        Student[] students = {
            new Student ("Sarmen", 19, 97),
            new Student ("Gor", 20, 98),
            new Student ("Tigran", 21, 99)
        };
        Teacher[] teachers = {
            
            new Teacher("Mr. Poghosyan", "Math", 5),
            new Teacher("Mr. Baghmanyan", "Science", 1),
            new Teacher("Mr. Badalyan", "History", 0)
        };
        School school = new School (students , teachers);

        school.TopStudents();
        school.NewTeachers();
    
        }
    }
    
    class Car
    {
        public string Model;
        public int Year;
        public bool IsRented;
        
        public Car(string model , int year){
            Model = model;
            Year = year;
            IsRented = false;
        }
        public void RentCar(){
            if (!IsRented){
                Console.WriteLine("You have rented car for 1 day");
                IsRented = true;
            }
            else {
                Console.WriteLine("The car is already rented");
            }
        }
        public void ReturnCar(){
            if (IsRented){
                Console.WriteLine("You have returned the car");
                IsRented = false;
            }
            else {
                Console.WriteLine("the car is already returned");
            }
        }
    }    
    class Program
    {
        static void Main()
        {
        Car[] cars = {
            new Car("Audi" , 2011),
            new Car("Niva" , 2017),
            new Car("Mercedes" , 2022),
        };
        while (true){
            Console.WriteLine("Input 0 for rent or 1 for return");
            string a = Console.ReadLine();
            if (a == "0"){
            Console.WriteLine("Input the Car you want to rent or 0 to exit");
            string x = Console.ReadLine();
            if (x == "0") return;
            switch(x){
                case "Audi":
                cars[0].RentCar();
                break;
                case "Niva":
                cars[1].RentCar();
                break;
                case "Mercedes":
                cars[2].RentCar();
                break;
            }
            }
            else if (a == "1"){
                Console.WriteLine("input the car you want to return or 0 to exit");
                string x = Console.ReadLine();
                if (x == "0") return;
                  switch(x){
                case "Audi":
                cars[0].ReturnCar();
                break;
                case "Niva":
                cars[1].ReturnCar();
                break;
                case "Mercedes":
                cars[2].ReturnCar();
                break;
            }
        }
        }
        }
    }
 
    


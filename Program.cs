using System;

/*
class Program
{
  private class Student
    {
        private string name;
       private int studentId;
       private int gradeLevel;
        public Student (string name , int studentId , int gradeLevel ){
            this.name = name;
            this.studentId = studentId;
            this.gradeLevel = gradeLevel;
        }
        public void ShowStudentInfo(){
            Console.WriteLine ($"Student : {name} - {studentId} and grade : {gradeLevel}");
        }
        
    }
    static void Main(){
        Student student1 = new Student("Sarmen", 101, 10);
        Student student2 = new Student("Gor", 102, 11);
        Student student3 = new Student("Gagik", 103, 9);
     
        student1.ShowStudentInfo();
        student2.ShowStudentInfo();
        student3.ShowStudentInfo();
    }
}

class Program
{
    private class FlightTicket
    {
        private string passengerName;
        private string flightNumber;
        private string seatNumber;
        public FlightTicket(string passengerName, string flightNumber, string seatNumber)
        {
            this.passengerName = passengerName;
            this.flightNumber = flightNumber;
            this.seatNumber = seatNumber;
        }
        public void ShowTicketInfo()
        {
            Console.WriteLine($"Passenger: {passengerName}, Flight: {flightNumber}, Seat: {seatNumber}");
        }
    }

    static void Main()
    {
        
        FlightTicket ticket1 = new FlightTicket("Sarmen", "SU123", "12A");
        FlightTicket ticket2 = new FlightTicket("Gor", "AF456", "8C");
        FlightTicket ticket3 = new FlightTicket("Stepan", "LH789", "5B");

        
        ticket1.ShowTicketInfo();
        ticket2.ShowTicketInfo();
        ticket3.ShowTicketInfo();
    }
}
class Program
{
    private class FileDownload
    {
        public FileDownload(){
            Console.WriteLine("Download started");
        }
        ~FileDownload()
        {
            Console.WriteLine("Download Completed");
        }
    }
    static void StartDownload(){
        FileDownload file = new FileDownload();
    }
    static void Main(){
        StartDownload();

        Console.WriteLine("Program ended");
    }
}

class Program
{
    private class WeatherReport
    {
        public float temperature;
        public int humidity;
        public string weatherCondition;
        public WeatherReport(float temperature, int humidity, string weatherCondition)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.weatherCondition = weatherCondition;
        }

        public void ShowReport()
        {
            Console.WriteLine($"Temperature: {temperature}°C, Humidity: {humidity}%, Condition: {weatherCondition}");
        }
    }

    static void Main()
    {
        WeatherReport[] reports = new WeatherReport[]
        {
            new WeatherReport(22.5f, 65, "Hot"),
            new WeatherReport(18.0f, 80, "Cold"),
            new WeatherReport(30.0f, 50, "Hot"),
            new WeatherReport(10.0f, 90, "Rain")
        };
        foreach(var i in reports){
            i.ShowReport();
        }
    }
}

class Program
{
    private class Smartwatch
    {
        private string ownerName;
        private uint stepCount;

        public Smartwatch(string ownerName)
        {
            this.ownerName = ownerName;
            stepCount = 0;
        }
        public void AddSteps(uint steps){
            stepCount += steps;
        }
        public void ShowSteps(){
            Console.WriteLine($"User : {ownerName} have {stepCount} steps");
        }
    }
    static void Main(){
        Smartwatch x = new Smartwatch("Sarmen");

        x.AddSteps(15000);

        x.ShowSteps();
    }
}

class Program
{
    private class Movie
    {
        private int _rating;

        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _rating = value;
                }
                else
                {
                    Console.WriteLine("Raiting must be from 1 to 5");
                }
            }
        }
        public void ShowRating()
        {
            Console.WriteLine($"Rating: {_rating}");
        }
    }

    static void Main()
    {
    
        Movie movie = new Movie();

        movie.Rating = 4;  
        movie.ShowRating();

        movie.Rating = 6;  
        movie.ShowRating();
    }
}

class Program
{
    private class WorkoutSession
    {
        private string exerciseType;
        private int durationInMinutes;

        public WorkoutSession(string exerciseType, int durationInMinutes)
        {
            this.exerciseType = exerciseType;
            this.durationInMinutes = durationInMinutes;
        }
        public void ShowWorkoutDetails()
        {
            Console.WriteLine($"Type: {exerciseType}, Duration: {durationInMinutes} minutes.");
        }
    }

    static void Main()
    {
        WorkoutSession workout1 = new WorkoutSession("Yoga", 30);
        WorkoutSession workout2 = new WorkoutSession("Strength training", 45);
        WorkoutSession workout3 = new WorkoutSession("Running", 60);

        workout1.ShowWorkoutDetails();
        workout2.ShowWorkoutDetails();
        workout3.ShowWorkoutDetails();
    }
}

class Program
{
    private class Product
    {
        private string name;
        private int price;
        private int stockQuantity;

        public Product(string name, int price, int stockQuantity)
        {
            this.name = name;               
            this.price = price;
            this.stockQuantity = stockQuantity;
        }

        public void ShowProductDetails()
        {
            Console.WriteLine($"Name : {name} , price : {price} , quantity {stockQuantity}");
        }
    }

    static void Main()
    {
        Product product1 = new Product("Laptop", 100, 5);
        product1.ShowProductDetails();
    }
}

class Program
{
    private partial class Character
    {
        private string characterName;
        private int level;

        public Character(string characterName , int level){
            this.characterName = characterName;
            this.level = level;
        }
    }
    private partial class Character
    {
        public void ShowCharacterInfo(){
            Console.WriteLine($"Name : {characterName} Level : {level}");
        }
    }
    static void Main(){
        Character character = new Character("Sarmen" , 15);
        character.ShowCharacterInfo();
    }
}
*/
class Program
{
    private class Course
    {
        private string courseName;
        private string instructor;
        private int maxStudents;

        public Course(string courseName, string instructor, int maxStudents)
        {
            this.courseName = courseName;
            this.instructor = instructor;
            this.maxStudents = maxStudents;
        }

        public void ShowCourseDetails()
        {
            Console.WriteLine($"Course Name: {courseName} , Instructor : {instructor} , max : {maxStudents}");
        }
    }

    static void Main()
    {
        Course[] courses = new Course[]{
        new Course("Introduction to Programming", "Baghmayan", 30),
        new Course("Data Structures and Algorithms", "Araqelyan", 25),
        new Course("Web Development", "Hakobyan", 40)
        };
        foreach(var i in courses){
            i.ShowCourseDetails();
        }
    }
}
    


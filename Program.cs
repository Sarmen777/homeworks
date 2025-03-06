using System;
/* Task 1 */
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    private string? _fullName;
    
    public string FullName
    {
        get
        {
            if (_fullName == null)
            {
                _fullName = FirstName + " " + LastName;
            }
            return _fullName;
        }
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("Sarmen" ,"Baghmanyan");
        Console.WriteLine(person.FullName); 
        
        person.FirstName = "Аreg";
        Console.WriteLine(person.FullName); 
    }
}

/*Task 2 **************************************************************/

class Product
{
    private decimal _price;
    private int _stock;

    public decimal Price
    {
        get => _price;
        set => _price = value < 0 ? 0 : value;
    }

    public int Stock
    {
        get => _stock;
        set => _stock = value < 0 ? 10 : value;
    }

    public Product(decimal price, int stock)
    {
        Price = price;
        Stock = stock;
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Product(100, 20);
        Console.WriteLine($"Product 1 - Price: {product1.Price}, Stock: {product1.Stock}");
        
        Product product2 = new Product(-50, -5);
        Console.WriteLine($"Product 2 - Price: {product2.Price}, Stock: {product2.Stock}");
    }
}

/*Task 3 **************************************************************/


class TimePeriod
{
    public int TotalSeconds { get; set; }

    public string FormattedTime
    {
        get
        {
            int hours = TotalSeconds / 3600; 
            int minutes = (TotalSeconds % 3600) / 60; 
            int seconds = TotalSeconds % 60; 

            return hours + ":" + minutes + ":" + seconds;
        }
    }

         static void Main()
         {
            TimePeriod timePeriod = new TimePeriod();
        
            timePeriod.TotalSeconds = 7222;
        
            Console.WriteLine(timePeriod.FormattedTime);
        }
}

/*Task 4 **************************************************************/

class Students
{
    private string[] subjects;
    private int[] grades;
    private int size;

    public Students(int capacity)
    {
        subjects = new string[capacity];
        grades = new int[capacity];
        size = 0;
    }

    public int this[string subject]
    {
        get
        {
            for (int i = 0; i < size; i++)
            {
                if (subjects[i] == subject)
                {
                    return grades[i];
                }
            }
            return -1; 
        }
        set
        {
            for (int i = 0; i < size; i++)
            {
                if (subjects[i] == subject)
                {
                    grades[i] = value;
                    return;
                }
            }
            if (size < subjects.Length)
            {
                subjects[size] = subject;
                grades[size] = value;
                size++;
            }
            else
            {
                Console.WriteLine("Can not add , there is no space");
            }
        }
    }

    public void PrintGrades()
    {
        Console.WriteLine("Grades of students:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{subjects[i]}: {grades[i]}");
        }
    }
}

class Program
{
    static void Main()
    {
        Students student = new Students(5);

        student["Math"] = 90;
        student["Physics"] = 85;

        Console.WriteLine($"Grade of math: {student["Math"]}");
        Console.WriteLine($"Grade of history: {student["History"]}"); 

        student.PrintGrades();
    }
}

/*Task 5 **************************************************************/


class Grid3D
{
    private int sizeX, sizeY, sizeZ;

    private int[,,] grid;

    public Grid3D(int x, int y, int z)
    {
        if (x <= 0 || y <= 0 || z <= 0 ) throw new ArgumentOutOfRangeException("Input must be positive");
        sizeX = x;
        sizeY = y;
        sizeZ = z;
        grid = new int[x , y , z];
    }
    public int this[int x, int y, int z]
    {
        get
        {
            if (!IsValid(x , y , z)) throw new ArgumentException("Index is not valid");
            return grid[x , y , z];
        }
        set
        {
            if (!IsValid(x,y,z)) throw new ArgumentException("Index is not valid");
            grid[x , y , z] = value;
        }
    }
    private bool IsValid(int x, int y, int z)
    {
        if (x >= 0 && y >= 0 && z >= 0 && x < sizeX && y < sizeY && z < sizeZ) return true;
        return false;
    }
    public void PrintGrid()
    {
        for (int x = 0 ; x < sizeX ; x++)
        {
            for (int y = 0 ; y < sizeY ; y++)
            {
                for ( int z = 0 ; z < sizeZ ; z++)
                {
                    Console.WriteLine($"{x}, {y}, {z} = {grid[x, y, z]}");

                }
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Grid3D grid = new Grid3D(2, 2, 1);
        grid[0 , 0 , 0] = 10;
        grid[1 , 0 , 0] = 20;
        grid[1 , 1 , 0] = 24;
        grid.PrintGrid();
    }
}

/*Task 6 **************************************************************/

class Person
{
    public int id {get;}
    public string? name {get;}

    public Person(int id , string name)
    {
        this.id = id;
        this.name = name;
    }
}
class ContactArray
{
    private Person[] contacts;

    public ContactArray(Person[] contacts)
    {
        this.contacts = contacts;
    }
    public Person this[int  id]
    {
        get 
        {
            foreach (var i in contacts)
            {
                if (i.id == id) return i;
            }
            return null;
        }
    }
    public Person this[string name]
    {
        get 
        {
            foreach(var i in contacts)
            {
                if(i.name == name) return i;
            }
            return null;
        }
    }
}






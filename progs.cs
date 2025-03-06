using System;
using System.Dynamic;

/*Task 1 **************************************************************/

class CustomList
{
    private int[] items;

    private int count;

    public CustomList()
    {
        items = new int[3];
        count = 0;
    }
     public int this[int index]
     {
        get
        {
        if (index < 0 || index >= count)  throw new Exception("Index out of range");
            return items[index];
        }
        set
        {
            if (index < 0 || index >= count)
                throw new Exception("Index out of range");
                items[index] = value;
        }
    }
    public void Add(int value)
    {
        if (count == items.Length) Resize();
        items[count] = value;
        count++;
    }
    public void RemoveAt(int index)
    {
            if (index < 0 || index >= count) throw new Exception("Out of range");
            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i+1];
            }
            count--;
    }
    private void Resize()
    {
        int newSize = items.Length * 2;
        int[] newItems = new int[newSize];
        for (int i = 0 ; i < count ; i++)
        {
            newItems[i] = items[i];
        }
        items = newItems;
    }
    public void Print()
    {
        Console.Write("Items: ");
        for (int i = 0 ;i < count ; i++)
        {   
            Console.Write(items[i] + " ");
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        CustomList list = new CustomList();
        list.Add(7);
        list.Add(3);
        list.Add(12);
        list.Add(20);
        list.RemoveAt(0);
        list.Print();
    }
}

/*Task 2 **************************************************************/

class Storage
{
    private string[] data;
    private string role;

    public Storage(string role)
    {
        data = new string[10];
        this.role = role;
    }
    public string this[int index]
    {
        get
        {
            if (role == "Admin" || role == "Manager")
            {
                if (index < 0 || index >= data.Length) throw new ArgumentOutOfRangeException("index is not valid");
                return data[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException("You do not have permission");
            }
        }
        set
        {
            if (role == "Admin")
            {
                if (index < 0 || index >= data.Length) throw new ArgumentOutOfRangeException("Index is not valid");
                data[index] = value;
            }
            else throw new ArgumentOutOfRangeException("You do not have permission");
        }
    }
    public void Print()
    {
        if (role == "Admin" || role == "Manager")
        {
            for (int i = 0 ; i < data.Length ; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
        else throw new Exception("You do not have permission");
    }
}
class Program
{
    static void Main(){
    Storage admin = new Storage("Admin");
    Storage manager = new Storage("Manager");
    Storage user = new Storage("User");

    admin[0] = "Data new";
    Console.WriteLine(admin[0]);
    user[0] = "Smth";
}
}

/*Task 3 **************************************************************/

class Grid
{
    private int[,] gridData;

    public Grid(int rows, int columns)
    {
        gridData = new int[rows, columns]; 
    }

    public int this[int row, int column]
    {
        get
        {
            if (row < 0 || row >= gridData.GetLength(0) || column < 0 || column >= gridData.GetLength(1))
                throw new ArgumentOutOfRangeException("Invalid index");
            return gridData[row, column];
        }
        set
        {
            if (row < 0 || row >= gridData.GetLength(0) || column < 0 || column >= gridData.GetLength(1))
                throw new ArgumentOutOfRangeException("Invalid index");
            gridData[row, column] = value;
        }
    }

    public int[] GetRow(int row)
    {
        if (row < 0 || row >= gridData.GetLength(0))
            throw new ArgumentOutOfRangeException("Invalid  index");
        
        int columns = gridData.GetLength(1);
        int[] rowValues = new int[columns];
        for (int i = 0; i < columns; i++)
        {
            rowValues[i] = gridData[row, i];
        }
        return rowValues;
    }

    public int[] GetColumn(int column)
    {
        if (column < 0 || column >= gridData.GetLength(1))
            throw new ArgumentOutOfRangeException("Invalid index");

        int rows = gridData.GetLength(0);
        int[] columnValues = new int[rows];
        for (int i = 0; i < rows; i++)
        {
            columnValues[i] = gridData[i, column];
        }
        return columnValues;
    }

    public void PrintGrid()
    {
        int rows = gridData.GetLength(0);
        int columns = gridData.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(gridData[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Grid grid = new Grid(2, 2);
        grid[0 , 0] = 0;
        grid[0 , 1] = 1;
        grid[1 , 0] = 2;
        grid[1 , 1] = 3;
        grid.PrintGrid();
        int[] rows = grid.GetRow(1);
        foreach (int i in rows)
        {
            Console.Write(i + " ");
        }
    }
}
/*Task 4 **************************************************************/

class BankAccount
{
    private double balance;
    public string AccountHolder { get; }

    public BankAccount(string accountHolder, double initialBalance)
    {
        AccountHolder = accountHolder;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Amount must be greater 0");
        }
    }

    public void Withdraw(double amount, out string transactionDetails)
    {
        if (amount <= 0)
        {
            transactionDetails = "Amount must be greater 0";
            return;
        }
        if (amount > balance)
        {
            transactionDetails = "Do not have much money";
            return;
        }

        balance -= amount;
        transactionDetails = $"Withraw was done";
        return;
    }

    public static void Transfer(BankAccount acc,  BankAccount acc1, double amount, out string transactionDetails)
    {
        if (amount <= 0)
        {
            transactionDetails = "Amount must be greater 0.";
            return;
        }
        if (amount > acc.balance)
        {
            transactionDetails = "Don't have much balance.";
            return;
        }
        transactionDetails = "Transfer was done";
        acc.balance -= amount;
        acc1.balance += amount;
    }
    static class CurrencyConverter
    {
    private static double eurToUsd = 1.1; 
    public static double ConvertEurToUsd(double Eur)
     {
        return Eur * eurToUsd;
     }
    }

    public double GetBalance() => balance;

    public void ShowBalance()
    {
        Console.WriteLine("Balance: " + balance);
    }
  
}
class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount("Sarmen", 1000);
        BankAccount account2 = new BankAccount("Anna", 500);

        account1.Deposit(200);
        
        account1.Withdraw(150, out string withdrawalDetails);
        
        Console.WriteLine(withdrawalDetails);
        
        BankAccount.Transfer(account1, account2, 250, out string transferDetails);
        Console.WriteLine(transferDetails);
        account1.ShowBalance();
        account2.ShowBalance();
    }
}

/*Task 5 *****************************************************************************/
class CachedObject
{
    public string Data;

    public CachedObject(string data)
    {
        Data = data;
    }
}

class SimpleCache
{
    private static int totalCachedObjects = 0;
    private CachedObject[] cache;
    private int count = 0;

    public SimpleCache(int maxSize)
    {
        cache = new CachedObject[maxSize];
    }

    public void Add(string data)
    {
        if (count >= cache.Length) 
        {
            for (int i = 1; i < cache.Length; i++)
            {
                cache[i - 1] = cache[i];
            }
            count--; 
        }

        cache[count] = new CachedObject(data);
        count++;
        totalCachedObjects++;
    }

    public CachedObject this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid  index");
            return cache[index];
        }
    }

    public void PrintCache()
    {
        Console.WriteLine("Cache data:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(cache[i].Data);
        }
    }

    public static void PrintTotalCachedObjects()
    {
        Console.WriteLine($"Total  objects: {totalCachedObjects}");
    }
}

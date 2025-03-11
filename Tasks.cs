using System;
using System.Diagnostics.CodeAnalysis;
/*
abstract class PaymentMethod
{
    protected double balance;

    public double Balance{ get { return balance; } protected set{}}

    public PaymentMethod(double balance)
    {
        this.balance = balance;
    }
 
    public abstract void PayBy(double amount);
    protected abstract double CalculateFee(double amount);
}

class PayPal : PaymentMethod
{
    private const double Fee = 0.025;

    public PayPal(double balance) : base(balance){}
    
    public override void PayBy(double amount)
    {
        double total = amount + CalculateFee(amount);
        if (amount < 0 || Balance - total < 0) throw new Exception("Do not have much money to pay");

        balance -= total;
        Console.WriteLine($"You have paid by Paypal {total}$ your balance now: {balance}"); 
    }
    protected override double CalculateFee(double amount)
    {
        return amount * Fee;
    }
}
class BankTransfer : PaymentMethod
{
    private const double Fee = 0.001;

    public BankTransfer (double balance) : base(balance){}
    public override void PayBy(double amount)
    {
        double total = amount + CalculateFee(amount);
        if (amount < 0 || Balance - total < 0) throw new Exception("Do not have much money to pay");

        balance -= total;
        Console.WriteLine($"You have paid by BankTransfer {total}$ your balance now: {balance}"); 
    }
    protected override double CalculateFee(double amount)
    {
        return amount * Fee;
    }
}
class CreditCard : PaymentMethod
{
    private const double Fee = 0.015;

    public CreditCard (double balance) : base(balance){}
    public override void PayBy(double amount)
    {
        double total = amount + CalculateFee(amount);
        if (amount < 0 || Balance - total < 0) throw new Exception("Do not have much money to pay");

        balance -= total;
        Console.WriteLine($"You have paid by CreditCard {total}$ your balance now: {balance}"); 
    }
    protected override double CalculateFee(double amount)
    {
        return amount * Fee;
    }
}

abstract class Vehicle
{
    public int FuelLevel   {get; protected set;}
    public int FuelCapacity  {get; protected set;}

    public Vehicle (int fuelLevel, int fuelCapacity)
    {
        FuelLevel = fuelLevel;
        FuelCapacity = fuelCapacity;
    }
    abstract public void Move();

    protected void ConsumeFuel(int amount)
    {
        if (FuelLevel < amount) throw new Exception("Do not have enough fuel");
        FuelLevel -= amount;
    }
    public void ReFuel(int amount)
    {
        if (amount + FuelLevel > FuelCapacity)
        {
            FuelLevel = FuelCapacity;
            Console.WriteLine("Capacity is already full");
            return;
        }
        FuelLevel += amount;
    }
    public void ShowFuelLevel()
    {
        Console.WriteLine($"Your fuel level now: {FuelLevel} ");
    }
}
class LandVehicle : Vehicle
{
    public LandVehicle (int FuelLevel, int FuelCapacity) : base (FuelLevel, FuelCapacity){}
    public override void Move()
    {
        Console.WriteLine("Your vehicle is moving on the ground");
        ConsumeFuel(10);
    }
}
class WaterVehicle : Vehicle
{
    public WaterVehicle (int FuelLevel, int FuelCapacity) : base (FuelLevel, FuelCapacity){}
    public override void Move()
    {
        Console.WriteLine("Your vehicle is moving in the water");
        ConsumeFuel(15);
    }
}
class AirVehicle : Vehicle
{
    public AirVehicle (int FuelLevel, int FuelCapacity) : base (FuelLevel, FuelCapacity){}
    public override void Move()
    {
        Console.WriteLine("Your vehicle is moving on the ground");
        ConsumeFuel(20);
    }
}
*/
class User 
{
    public string Name { get; private set; }
    public string Role { get; private set; }

    public User(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public void DisplayRole()
    {
        Console.WriteLine($"Your Role: {Role}");
    }
}

class DataStorage
{
    private object[] _data; 
    
    public DataStorage(int maxData)
    {
        _data = new object[maxData];
    }

    public object this[User user,int index]
    {
        get 
        {
            if (index < 0 || index >= _data.Length)
            {
                throw new Exception("Invalid index");
            }
            if (user.Role == "Admin" || user.Role == "Manager" || user.Role == "User")
            {
                return _data[index];
            }
            else throw new Exception("You don't have access to read from Data Storage");
        }
        set 
        {
            if (index < 0 || index >= _data.Length)
            {
                throw new Exception("Invalid index");
            }
            if (user.Role == "admin")
            {
                _data[index] = value;
                System.Console.WriteLine("Data added");
            }
            else
            {
                throw new Exception("You don't have access to set data");
            }
            
        }   
    }
   
}


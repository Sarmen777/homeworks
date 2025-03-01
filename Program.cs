using System;
/*
class WaterTank
{
     private double Capacity = 10000;
     private double CurrentLevel;

    public WaterTank()
    {
        CurrentLevel = 0;
    }
    public WaterTank(double CurrentLevel)
    {
        this.CurrentLevel = CurrentLevel;    
    }
    public override string ToString() 
    {
        return $"Capacity: {Capacity}, CurrentLevel: {CurrentLevel}";
    }
    public static void Transfer(WaterTank obj1 ,WaterTank obj2 ,double amount)
    {
        if(obj1.CurrentLevel < amount || obj2.CurrentLevel + amount > obj2.Capacity)
        {
            Console.WriteLine("Can not do this , input another amount");
            return;
        }
        obj1.CurrentLevel -= amount;
        obj2.CurrentLevel += amount;
    }

    public static WaterTank operator +(WaterTank obj, double amount)
    {
        if (obj.CurrentLevel + amount > obj.Capacity)
        {
            Console.WriteLine("Not enough capacity");
            return obj;
        }
        return new WaterTank(obj.CurrentLevel + amount);
    }

    public static WaterTank operator -(WaterTank obj, double amount)
    {
        if (obj.CurrentLevel - amount < obj.Capacity)
        {
            Console.WriteLine("Not enough water");
            return obj;
        }
        return new WaterTank(obj.CurrentLevel - amount);
    }
}

class Program
{
    static void Main()
    {
        WaterTank obj1 = new WaterTank();
        WaterTank obj2 = new WaterTank();
        obj1 = obj1 + 3000;
        obj2 = obj2 + 5000;
        WaterTank.Transfer(obj1, obj2, 2000);
        Console.WriteLine(obj1);
        Console.WriteLine(obj2);
    }
}
*/
class InkReservoir
{
    public string Color {get; private set;}
    public double InkAmount {get; private set;}

    public InkReservoir(string color, double inkAmount)
    {
        Color = color;
        InkAmount = inkAmount;
    }

    public static InkReservoir operator +(InkReservoir a, InkReservoir b)
    {
        if (a.Color == b.Color)
        {
            return new InkReservoir(a.Color, a.InkAmount + b.InkAmount);
        }
        else
        {
            Console.WriteLine("Can not combine different colours");
            return a;
        }
    }

    public static InkReservoir operator -(InkReservoir reservoir, double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Can not do this , input digit higher than 0");
            return reservoir;
        }
        return new InkReservoir(reservoir.Color, reservoir.InkAmount - amount);
    }

    public override string ToString()
    {
        return $"Color: {Color}, Amount: {InkAmount}";
    }
}


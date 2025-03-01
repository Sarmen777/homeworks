using System;
/*
class BankAccount
 {
    public int AccountNumber{get; private set;}
    public string CustomerName{get; private set;}
    public decimal Balance {get; private set;}

    public BankAccount(int accountNumber, string customerName, decimal balance = 0)
    {
        AccountNumber = accountNumber;
        CustomerName = customerName;
        Balance = balance;
    }

     public override string ToString()
    {
         return $"Customer name: {CustomerName} Account number: {AccountNumber} Balance: {Balance}$ ";
     }
     

    public override bool Equals(object? obj)
    {
        if (obj is BankAccount other)
        {
            return this.AccountNumber == other.AccountNumber;
        }
        return false;
     }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.AccountNumber, this.Balance, this.CustomerName);
    }

    public static BankAccount operator +(BankAccount account1, int deposit)
    {
        account1.Balance += deposit;
        return account1;
    }

    public static BankAccount operator -(BankAccount account1, int withdraw)
    {
        if(account1.Balance < withdraw)
         {
             System.Console.WriteLine("Balance can not be negative");
             return account1;
         }
         account1.Balance -= withdraw;
         return account1;
     }

     public static bool operator > (BankAccount account1, BankAccount account2)
     {
         return account1.Balance > account2.Balance;
     }

     public static bool operator < (BankAccount account1, BankAccount account2)
     {
         return account1.Balance < account2.Balance;
     }

     public static bool operator >= (BankAccount account1, BankAccount account2)
     {
         return account1.Balance >= account2.Balance;
     }

     public static bool operator <= (BankAccount account1, BankAccount account2)
     {
         return account1.Balance <= account2.Balance;
     }


 }
 class Program
 {
     static void Main()
     {
         BankAccount account = new BankAccount(1, "John");
         account += 2400;
         System.Console.WriteLine(account);
     }
 }
*/
class Vector3D
{
    public int X {get; private set;}
    public int Y {get; private set;}
    public int Z {get; private set;}

    public Vector3D(int x, int y, int z)
    {
        X = z;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}, Z: {Z}";
    }

    public static Vector3D operator +(Vector3D vec1, Vector3D vec2)
    {
        return new Vector3D(vec1.X + vec2.X, vec1.Y + vec2.Y,vec1.Z + vec2.Z);
    }

    public static Vector3D operator -(Vector3D vec1, Vector3D vec2)
    {
        return new Vector3D(vec1.X - vec2.X, vec1.Y - vec2.Y,vec1.Z - vec2.Z);
    }

    public static Vector3D operator *(Vector3D vec1, Vector3D vec2)
    {
        return new Vector3D(vec1.X * vec2.X, vec1.Y * vec2.Y,vec1.Z * vec2.Z);
    }

    public static Vector3D operator /(Vector3D vec1, Vector3D vec2)
    {
        if (vec2.X == 0 || vec2.Y == 0 || vec2.Z == 0)
        {
            System.Console.WriteLine("Cant divide by 0 , returning vector by default coordiantes");
            return new Vector3D(0,0,0);
        }
        return new Vector3D(vec1.X - vec2.X, vec1.Y - vec2.Y,vec1.Z - vec2.Z);
    }

    public static bool operator ==(Vector3D vec1, Vector3D vec2)
    {
        return vec2.X == vec1.X && vec2.Y == vec1.Y && vec2.Z == vec1.Z;
    }
    public static bool operator !=(Vector3D vec1, Vector3D vec2)
    {
        return vec2.X != vec1.X || vec2.Y != vec1.Y || vec2.Z != vec1.Z;
    }
    public static bool operator true(Vector3D vec1)
    {
        return vec1.X != 0 && vec1.Y != 0 && vec1.Z !=0;
    }

    public static bool operator false(Vector3D vec1)
    {
        return vec1.X == 0 || vec1.Y == 0 || vec1.Z ==0;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Vector3D other)
        {
            return (Vector3D)obj == other;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(X,Y,Z);
    }

}
    


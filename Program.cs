using System;
using System.Collections.Generic;

/*1*************************************************************/
public delegate double Operation(double a, double b);
public static class Calculator
{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b)
    {
        if (b == 0) throw new ArgumentException("Can not divide by 0");

        return a / b;
    }
} // Operation op = add , sub and using switch cases for choice

/*2*****************************************************************************/
public delegate void Notify (string msg);
public static class Notifications
{
    public static void ConsoleNotification (string msg) => Console.WriteLine($"Console: {msg}");
    public static void EmailNotification (string msg) => Console.WriteLine($"Email: {msg}");
}
public class Notifier
{
    Notify? notify;

    public void SendMessage(string msg)
    {
        if (notify != null)
        {
            notify(msg);
        }
        else
        {
            Console.WriteLine("There are no methods");
        }
    }
}

/*3*****************************************************************************/

public delegate T Transformer<T>(T input);

public static class ListTransformer
{
    public static List<T> TransformList<T>(this List<T> list, Transformer<T> transformer)
    {
        List<T> result = new List<T>();
        foreach (T item in list)
        {
            result.Add(transformer(item));
        }
        return result;
    }
}
public static class Methods
{
public static string ToUpperCase(string input)
{
    return input.ToUpper();
}

}
class Program
{
    public static void Main()
    {
        Transformer<string> transformer = Methods.ToUpperCase;

        List<string> list = new List<string>();
        list.Add("something");
        list.Add("inchka");

        List<string> transformed = list.TransformList(transformer);

        foreach (var i in transformed)
        {
            Console.WriteLine(i);
        }
    }
}

/*4******************************/

public static class MyListExtensions
{
    public static List<T> Filter<T>(this List<T> list, Predicate<T> predicate)
    {
        List<T> result = new List<T>();
        foreach (T item in list)
        {
            if (predicate(item))
            {
                result.Add(item);
            }
        }
        return result;
    }
}
public static class MyMethods
{
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}

/*5*****************************************************************************/

public class Person
{
    public string? Name { get; set;}
    public int Age { get; set; }
}

public static class PersonSorter
{
    public static void SortByAgeAscending(List<Person> people)
    {
        people.Sort((item1, item2) => item1.Age.CompareTo(item2.Age));
    }

    public static void SortByNameAlphabetically(List<Person> people)
    {
        people.Sort((item1, item2) => item1.Name.CompareTo(item2.Name));
    }
}


/*First Task************************************/

namespace second{
public class Shop
{
    public string? Name { get; set;}
    private int _discount;
    public int Discount
    {
        get { return _discount; }

        set {
            if (value != _discount)
            {
                int old = _discount;
                _discount = value;
                OnDiscountChanged(old , _discount);

            }
        }
    }
    public Shop(string name)
    {
        Name = name;
    }

    public event EventHandler<DiscountChangedEventArgs> DiscountChanged;

    protected virtual void OnDiscountChanged(int oldPrice , int newPrice)
    {
        DiscountChanged?.Invoke(this, new DiscountChangedEventArgs(oldPrice , newPrice));
    }

}
public class DiscountChangedEventArgs : EventArgs
{
    public int OldDiscount;
    public int NewDiscount;

    public DiscountChangedEventArgs (int oldPrice, int newPrice)
    {
        OldDiscount = oldPrice;
        NewDiscount = newPrice;
    }

}
public class Customer
{
    public string Name { get; }

    public Customer(string name)
    {
        Name = name;
    }

    public void Subscribe(Shop shop)
    {
        shop.DiscountChanged += RespondToDiscountChange;
    }

    private void RespondToDiscountChange(object sender, DiscountChangedEventArgs e)
    {
        Shop? shop = sender as Shop;
        if (shop != null)
        {
            Console.WriteLine($"[{Name}]-ն ասում է, որ [{shop.Name}] խանութում զեղչը բարձրացել է {e.OldDiscount}%֊ից մինչև {e.NewDiscount}%։");
        }
    }
}
class Program
{
    static void Main()
    {
        Shop shop = new Shop("TechShop");
        Customer alice = new Customer("Alice");
        Customer bob = new Customer("Bob");

        alice.Subscribe(shop);
        bob.Subscribe(shop);

        shop.Discount = 10;
        shop.Discount = 20;
    }
}
}

/*Task2*************************************************************/

namespace t2{
public interface IReadBox<out T>
{
    T this[int index] { get; }
}

public interface IWriteBox<in T>
{
    void Add(T item);
}

public class MyList<T> : IReadBox<T>, IWriteBox<T>
{
    private List<T> _list = new List<T>();

    public T this[int index]
    {
        get { return _list[index]; }
    }

    public void Add(T item)
    {
        _list.Add(item);
    }
}
public static class Test
{
    public static void ReadOnlyTest(IReadBox<object> box)
    {
        Console.WriteLine("Reading first element as object: " + box[0]);
    }

    public static void WriteOnlyTest(IWriteBox<string> box)
    {
        box.Add("Hello");
    }
}
public class Program
{
    public static void Main()
    {
        MyList<string> stringList = new MyList<string>();
        stringList.Add("Hello");
        stringList.Add("World");

        Test.ReadOnlyTest(stringList);

        MyList<object> objectList = new MyList<object>();
        Test.WriteOnlyTest(objectList);

        Console.WriteLine("objectList[0]: " + objectList[0]);
    }
}
}




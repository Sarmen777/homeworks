using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class MyMemoize
{
    public static Func<T , T> Memoize<T>(Func<T , T> func)
    {
         Dictionary<T , T> cache = new Dictionary<T , T>();

        return (T input) =>
        {
            if (cache.ContainsKey(input))
            {
                Console.WriteLine("From cache");
                return cache[input];
            }
            return cache[input] = func(input);
        };

    }
}
public static class CacheManager
{
    public static Tuple<Func<int , bool> , Action> ManagedCache()
    {
        Dictionary<int , bool> cache = new Dictionary<int , bool>();
        Func<int , bool> IsPrime = x =>
        {
            if (cache.ContainsKey(x))
            {
                Console.WriteLine("From cache");
                return cache[x];
            }
            if (x < 2)
            {
                cache[x] = false;
                return cache[x];
            }
            for (int i = 2 ; i * i <= x ; i++)
            {
                if (x % i == 0)
                {
                    cache[x] = false;
                    return cache[x];
                }
            }
            cache[x] = true;
            return cache[x];
        };
        Action ClearCache = () =>
        {
            cache.Clear();
            Console.WriteLine("Cache cleared");
        };
        return Tuple.Create(IsPrime, ClearCache);
    }
}
public static class ListExtensions
{
    public static List<T> Filter<T> (this List<T> list, Func <T , bool> func)
    {
        List<T> tmp = new List<T>();
         foreach (T item in list)
         {
            if (func(item))
            {
                tmp.Add(item);
            }
         }
         return tmp;
    }
    public static List<T> Map<T> (this List<T> list, Func <T , T> func)
    {
        List<T> tmp = new List<T>();
        foreach (T item in list)
        {
            tmp.Add(func(item));
        }
        return tmp;
    }
    public static bool Every<T> (this List<T> list, Func<T , bool> func)
    {
        foreach (T item in list)
        {
            if (!func(item)) return false;
        }
        return true;
    }
    public static bool Some<T> (this List<T> list , Func<T , bool> func)
    {
        foreach (T item in list)
        {
            if (func(item)) return true;
        }
        return false;
    }
}

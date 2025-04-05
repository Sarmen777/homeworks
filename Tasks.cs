using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

class MyStack<T>
{
    private T[] _array;
    private int _count;
    private int _capacity = 4;

    public MyStack()
    {
        _array = new T[_capacity];
    }
    private void Resize()
    {
        T[] newArr = new T[_capacity * 2];
        Array.Copy(_array , newArr , _count);
        _array = newArr;
        _capacity *= 2;
    }
    public void Push(T item)
    {
        if (_count == _capacity) Resize(); // 1 2 3 
        _array[_count++] = item;
    }
    public T Pop()
    {
        if (_count == 0) throw new Exception("There is no elements");
        T item = _array[--_count];
        _array[_count] = default;
        return item;
    }
    public T Peek()
    {
        if (_count == 0) throw new Exception("There is no elements");
        return _array[_count - 1];
    }
    public bool IsEmpty()
    {
        if (_count == 0) return true;
        return false;
    }
    public int Count => _count;
}

/***************************************************/

class MyQueue<T>
{
    private T[] _array;
    private int _count;
    private int _capacity = 4;

    public MyQueue()
    {
        _array = new T[_capacity];
    }
    private void Resize()
    {
        T[] newArr = new T[_capacity * 2];
        Array.Copy(_array , newArr , _count);
        _array = newArr;
        _capacity *= 2;
    }
    public void Enqueue(T item)
    {
        if (_count == _capacity) Resize();
        _array[_count++] = item;
    }
    public T Dequeue()
    {
        if (_count == 0) throw new Exception("There is no elements");

        for (int i = 0 ; i < _array.Length - 1 ; i++) // 1 2 3
        {
            _array[i] = _array[i + 1];
        }
        _count--;
        return _array[0];
    }
    public T Peek()
    {
        if ( _count == 0) throw new Exception("There is no elements");
        return _array[0];
    }
}
 /***************************************************/

 class MyDictionary<Tkey, TValue>
 {
    private struct Entry
    {
        public Tkey Key;
        public TValue Value;
    }
    private Entry[] _array;
    private int _count;
    private int _capacity = 4;

    public MyDictionary()
    {
        _array = new Entry[_capacity];
    }
    public bool Contains(Tkey key)
    {
        for (int i = 0 ; i < _count ; i++)
        {
            if (_array[i].Key.Equals(key)) return true;
        }
        return false;
    }
    private void Resize()
    {
        Entry[] newArr = new Entry[_capacity * 2];
        Array.Copy(_array , newArr , _count);
        _array = newArr;
        _capacity *= 2;
    }
    public void Add (Tkey key , TValue value)
    {
        if (_capacity == _count) Resize();
        if (Contains(key)) throw new Exception("There is a key like that");
        
        _array[_count++] = new Entry{Key = key, Value = value};

    }
    public bool TryAdd(Tkey key , TValue value)
    {
        if (_capacity == _count) Resize();
        if (Contains(key)) return false;

        _array[_count++] = new Entry{Key = key , Value = value};
        return true;
    }
    public TValue this[Tkey key]
    {
        get 
        {
            for (int i = 0 ; i < _count ; i++)
            {
                if (_array[i].Key.Equals(key)) return _array[i].Value;
            }
            throw new Exception("You do not have element with this key");
        }
        set 
        {
            for (int i = 0 ; i < _count ; i++)
            {
                if (_array[i].Key.Equals(key))
                {
                    _array[i].Value = value;
                    return;
                }
            }
            if (_capacity == _count) Resize();
            _array[_count++] = new Entry {Key = key, Value = value};

        }
    }
 }
 
class MySortedSet<T> where T : IComparable<T>
{
    private T[] _array;
    private int _count;
    private int _capacity = 4;

    public MySortedSet()
    {
        _array = new T[_capacity];
    }
    private void Resize()
    {
        T[] newArr = new T[_capacity * 2];
        Array.Copy(_array , newArr , _count);
        _array = newArr;
        _capacity *= 2;
    }
    public bool Contains(T item)
    {
        for (int i = 0 ; i < _count ; i++)
        {
            if (_array[i].Equals(item)) return true;
        }
        return false;
    }
    public void Add(T value)
    {
        if (Contains(value))
        {
            Console.WriteLine("You already have this element");
            return;
        }
        if (_count == _capacity) Resize();

        int i = 0;

        for (i = _count - 1 ; i > 0 && _array[i].CompareTo(value) > 0 ; i--) 
        {
            _array[i + 1] = _array[i];
        }
        _array[i + 1] = value;
        _count++;
    }
    public void PrintAll()
    {
        for (int i = 0 ; i < _count ; i++)
        {
            Console.WriteLine(_array[i]);
        }
    }
}
public class MyArrayList : ICloneable, IEnumerable
{
    private object[] _array;
    private int _count;
    private int _capacity = 4;

    public MyArrayList()
    {
        _array = new object[_capacity];
        
    }
    public void Add(object item)
    {
        if (_count == _capacity) Resize();
             
        _array[_count++] = item;
    }
    public bool Remove(object item)
    {
        int index = FindIndex(item);
        if (index < 0) return false;

        RemoveAt(index);
        return true;
    }
    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count) throw new Exception("Out of range");

        for (int i = index ; i < _count - 1 ; i++)
        {
            _array[i] = _array[i + 1]; // 1 2 3 4 
        }
        _count--;
        _array[_count] = null;
        
    }
    public bool Contains(object item)
    {
        return FindIndex(item) >= 0;
    }
    public void Insert(int index, object item)
    {
        if (index < 0 || index > _count) throw new Exception("Out of range");

        if (_count == _capacity) Resize();

        for (int i = _count ; i > index ; i--) // 1 2 . 3 4
        {
            _array[i] = _array[i - 1];
        }
        _array[index] = item;
        _count++;      
    }
    private int FindIndex(object item)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_array[i].Equals(item))
            {
                return i;
            }
        }
        return -1; 
    }

    public int BinarySearchWithComparer(object item, IComparer comparer)
    {
        int low = 0;
        int high = _count - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int comparison = comparer.Compare(_array[mid], item);

            if (comparison == 0)
            {
                return mid; 
            }
            else if (comparison < 0)
            {
                low = mid + 1; 
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }
    public int BinarySearchWithoutComparer(object item)
    {
        int low = 0;
        int high = _count- 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int comparison = ((IComparable)_array[mid]).CompareTo(item); 

            if (comparison == 0)
            {
                return mid; 
            }
            else if (comparison < 0)
            {
                low = mid + 1; 
            }
            else
            {
                high = mid - 1; 
            }
        }

        return -1;
    }
    
    public object Clone()
    {
    MyArrayList clone = new MyArrayList();
    
     clone._count = _count;
     clone._capacity = _capacity;
     clone._array = new object[_capacity];
     Array.Copy(_array, clone._array, _count);

     return clone;
    }

    private void Resize()
    {
        object[] newArray = new object[_capacity * 2];
        Array.Copy(_array, newArray, _count);
        _array = newArray;
        _capacity *= 2;
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _array[i];
        }
    }

    public object this[int index]
    {
        get
        {
            if (index < 0 || index >= _count) throw new Exception("Out of range");
            return _array[index];
        }
        set
        {
            if (index < 0 || index >= _count) throw new Exception("Out of range");
            _array[index] = value;
        }
    }
}
class MyList<T> : ICloneable, IEnumerable<T>
{
    public int Count{ get; private set; } = 0;
    public int Capacity { get; private set; }

    private T[] _collection;

    public T this[int index]
    {
        get 
        {
            if (index > Count || index < 0)
                throw new Exception("Index out of range");
            return _collection[index]; 
        }  
    }

    public MyList(int capacity = 4) 
    {
        Capacity = capacity > 0 ? capacity : 4;
        _collection = new T[Capacity];
    }
    public object Clone()
    {
        MyList<T> clone = new MyList<T>(Capacity);
        Array.Copy(_collection, clone._collection, Count);
        clone.Count = Count;
        return clone;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return _collection[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void Resize()
    {
        Capacity *=2;
        T[] temp = new T[Capacity];
        Array.Copy(_collection, temp, Count);
        _collection = temp;
    }

    public void Add(T item)
    {
        if (Capacity == Count)
            Resize();
        _collection[Count++] = item;
    }
    public bool Contains(T item)
    {
        return IndexOf(item) != -1;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (EqualityComparer<T>.Default.Equals(_collection[i], item))
                return i;
        }
        return -1;
    }
    public void Remove(T item)
    {
        int index = IndexOf(item);
        RemoveAt(index);
        Count--;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
            throw new Exception("index out of range");
        for (int i = index; i < Count - 1; i++ )
        {
            _collection[i] = _collection[i + 1];
        }
        Count --;
        _collection[Count] = default!;
        
    }

    public void InsertAt(int index)
    {
        if (index > Count || index < 0)
            throw new Exception("Index out of range");
        if (Capacity == Count)
            Resize();
        for(int i = Count; i < index; i--)
        {
            _collection[i] = _collection[i - 1];
        }
        Count ++;
    }

    public int BinarySearch(T value, IComparer<T> comparer = default!)
    {
        comparer = (comparer == null) ? Comparer<T>.Default : comparer;
        int start = 0;
        int end = Count - 1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int cmp = comparer.Compare(_collection[mid], value);
            if (cmp == 0)
                return mid;
            if (cmp < 0) start = mid + 1;
            else end = mid - 1;

        }
        return -1;
    }
    
}
/*******************************************************/


/*******************************************************/

static class MyStringExtensions
{
    public static string[] MySplit(this string str , char seperator)
    {
        List<string> list = new List<string>();
        StringBuilder sb = new StringBuilder();
        for (int i = 0 ; i < str.Length ; i++)
        {
            if (str[i] != seperator) sb.Append(str[i]);
            if (str[i] == seperator)
            {
                string local = sb.ToString();
                list.Add(local);
                sb.Clear(); 
            }
        }
        if (sb.Length > 0)
        {
            list.Add(sb.ToString());
            sb.Clear();
        }
        return list.ToArray(); 
    }
    public static string MySubString(this string str , int start , int count)
    {
        if (start + count >= str.Length || start < 0 || count < 0) throw new Exception("Out of range");
        StringBuilder sb = new StringBuilder();
        for (int i = start ; i < start + count  ; i++ )
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }
    public static int MyIndexOf(this string str , string str1)
    {
        if (string.IsNullOrEmpty(str1)) return -1;
        if (str1.Length > str.Length) return -1;

        for (int i = 0; i <= str.Length - str1.Length; i++)
        {
            bool x = true;
            for (int j = 0; j < str1.Length; j++)
            {
                if (str[i + j] != str1[j])
                {
                    x = false;
                    break;
                }
            }
            if (x) return i;
        }
        return -1;
    }
    public static bool MyContains(this string str , string str1)
    {
        return str.MyIndexOf(str1) != -1;
    }   
}
public static class ListExtensions
{
    private static Random random = new Random();
    public static void Shuffle<T>(this List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            T temp = list[n];
            list[n] = list[k];
            list[k] = temp;
        }
    }

    public static void Reverse<T>(this List<T> list)
    {
        int count = list.Count;
        for (int i = 0; i < count / 2; i++)
        {
            int j = count - i - 1;
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
    public static List<T> Slice<T>(this List<T> list, int start, int end)
    {
        int count = list.Count;

        if (start < 0) start += count;
        if (end < 0) end += count;

        if (start < 0) start = 0;
        if (end > count) end = count;
        if (start > end) return new List<T>();

        List<T> result = new List<T>();
        for (int i = start; i < end; i++)
        {
            result.Add(list[i]);
        }
        return result;
    }

    public static T At<T>(this List<T> list, int index)
    {
        int count = list.Count;

        if (index < 0)
        {
            index += count;
        }

        if (index < 0 || index >= count)
        {
            throw new Exception("Index out of range");
        }

        return list[index];
    }
}
/*************************************************/


class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        if (obj is Student other)
            return Name == other.Name;
        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}

 class Group
 {
    public List<Student> Students { get; private set; }

    public Group()
    {
        Students = new List<Student>();
    }

    public Group(List<Student> students)
    {
        Students = new List<Student>();
        for (int i = 0; i < students.Count; i++)
        {
            Students.Add(students[i]);
        }
    }

    public static bool operator true(Group group)
    {
        return group.Students.Count > 0;
    }

    public static bool operator false(Group group)
    {
        return group.Students.Count == 0;
    }

    public static Group operator +(Group g1, Group g2)
    {
        List<Student> combined = new List<Student>();

        for (int i = 0; i < g1.Students.Count; i++)
        {
            combined.Add(g1.Students[i]);
        }

        for (int i = 0; i < g2.Students.Count; i++)
        {
            Student student = g2.Students[i];
            bool exists = false;

            for (int j = 0; j < combined.Count; j++)
            {
                if (combined[j].Equals(student))
                {
                    exists = true;
                    break;
                }
            }

            if (!exists)
            {
                combined.Add(student);
            }
        }

        return new Group(combined);
    }

    public static Group operator -(Group g1, Group g2)
    {
        List<Student> result = new List<Student>();

        for (int i = 0; i < g1.Students.Count; i++)
        {
            Student student = g1.Students[i];
            bool found = false;

            for (int j = 0; j < g2.Students.Count; j++)
            {
                if (student.Equals(g2.Students[j]))
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                result.Add(student);
            }
        }

        return new Group(result);
    }
}



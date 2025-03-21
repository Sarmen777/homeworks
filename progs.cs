
using System;
class MyString
{
    private char[] _str;
    public int MyLength
    {
        get { return _str.Length;}
    }

    public char this[int index]
    {
        get
        {
            if (index < 0 || index >= MyLength) throw new Exception("Invalid index");
            return _str[index];
        }
        set
        {
            if (index < 0 || index >= MyLength) throw new Exception("Invalid index");
            _str[index] = value;
        }
    }
    public MyString()
    {
        _str = null;
    }
    public MyString(string str)
    {
        _str = str.ToCharArray();
    }
    public MyString(string[] Strings)
    {
        int totalLength = 0;

        foreach(string str in Strings)
        {
            totalLength += str.Length;
        }
        _str = new char[totalLength];
        int totalIndex = 0;
        
        foreach (string str in Strings)
        {
            for (int i = 0 ; i < str.Length ; i++)
            {
                _str[totalIndex++] = str[i];
            }
        }
    }   
    public MyString(char[] ch)
    {
        _str = new char[ch.Length];
        for (int i = 0 ; i < ch.Length ; i++){
            _str[i] = ch[i];
        }
    }
    public bool Compare(string str)
    {
        if (str.Length != MyLength) return false;
        for (int i = 0 ; i < MyLength ; i++)
        {
            if (_str[i] != str[i]) return false;
        }
        return true;
    }
    public bool Compare (MyString other)
    {
        if (other == null || other._str.Length != _str.Length) return false;

        for (int i = 0 ; i < MyLength ; i++)
        {
            if (_str[i] != other._str[i]) return false;
        }
        return true;
    }
    public static bool operator ==(MyString a, MyString b)
    {
        if (a == null && b == null) return true;

        if (a == null && b != null || a != null && b == null) return false;
        
        return a.Compare(b);
    }
    public static bool operator !=(MyString a,MyString b)
    {
        return !(a == b);
    }
    public override bool Equals(object? obj)
    {
        MyString? other = obj as MyString;

        if (other == null) return false;

        if (other.MyLength != MyLength) return false;

        for (int i = 0 ; i < MyLength ; i++)
        {
            if (other._str[i] != _str[i]) return false;
        }
        return true;
    }
    public static bool Equals(MyString a, MyString b)
    {
        if (a == null && b == null) return true;

        return a.Compare(b);
    }
    public override int GetHashCode()
    {
     int hash = 13;
     foreach (char c in _str) hash = hash * 11 + c;
     return hash;
    }
    public static MyString Join(char seperator , params MyString[] strings)
    {
        if (strings == null) throw new ArgumentNullException("Invalid strings");
        int totalLength = 0;
        foreach (var Str in strings)
        {
            totalLength += Str.MyLength;
        }
        totalLength += strings.Length - 1;
        char[] res = new char[totalLength];

        int CurrentIndex = 0;
        for (int i = 0 ; i < strings.Length ; i++)
        {
            for (int j = 0 ; j < strings[i].MyLength ; j++)
            {
                res[CurrentIndex++] = strings[i]._str[j];
            }
            if (i < strings.Length - 1) res[CurrentIndex++] = seperator;
        }
        return new MyString(res);
    }
    public bool StartsWith(string prefix)
    {
        if (prefix.Length > MyLength) return false;

        for (int i = 0 ; i < prefix.Length ; i++)
        {
            if (_str[i] != prefix[i]) return false;
        }
        return true;
    }
    public bool EndsWith(string suffix)
    {
        if (suffix.Length > MyLength) return false;

        for (int i = 0 ; i < suffix.Length ; i++)
        {
            if (_str[MyLength - suffix.Length + i] != suffix[i]) return false;
        }
        return true;
    }
    public static MyString operator +(MyString s1, MyString s2)
    {
        int totalLength = s1.MyLength + s2.MyLength;
        char[] res = new char[totalLength];
        int CurrentIndex = 0;
        
        for (int i = 0 ; i < s1.MyLength ; i++)
        {
            res[CurrentIndex++] = s1._str[i];
        }

        for (int i = 0 ; i < s2.MyLength ; i++)
        {
            res[CurrentIndex++] = s2._str[i];
        }

        return new MyString(res);
    }
}


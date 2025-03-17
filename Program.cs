using System;

class Parent
{
    public string Name { get; private set}
    public int Age {get; private set}

    public int Salary {get; private set}

    public Parent (string name , int age , int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
    public override string ToString ()
    {
        return $"Name: {Name} , Age: {Age} , Salary: {Salary}";
    }

}
class Child
{
    public string Name { get; private set;}
    public int Age {get; private set;}

    public Parent Mother;
    public Parent Father;

    public Child (string name , int age , Parent mother , Parent father)
    {
        Name = name;

        Age = age;

        Mother = mother;

        Father = father;
    }
    public override string ToString ()
    {
        return $"{Name} , Age: {Age} , Mother: {Mother} , Father: {Father}";
    }
    public static Child[] childs = new Child[]
    {
        new Child("Tigran", 13, new Parent("Anna", 32, 270000), new Parent("Arman", 44, 500000)),
        new Child("Lusine", 5, new Parent("Mari", 28, 300000), new Parent("Hakob", 38, 450000)),
        new Child("Gor", 10, new Parent("Lusine", 34, 250000), new Parent("Vahan", 42, 600000)),
        new Child("Ara", 8, new Parent("Sona", 30, 350000), new Parent("Vardan", 40, 400000)),
        new Child("Grigor", 12, new Parent("Vera", 29, 320000), new Parent("Ashot", 45, 480000)),
    };

    public static void PrintWithAgeLess70()
    {
        foreach (Child child in childs)
        {
            if (child.Father.Age + child.Mother.Age < 70) Console.WriteLine(child);
        }
    }
    public static int FindSalaryOfOldest()
    {
        Parent fatherOfOldest = null;
        int maxIndex = 0;

        foreach (Child child in childs)
        {
            if (child.Age > maxIndex)
            {
                maxIndex = child.Age;
                fatherOfOldest = child.Father;
            }
        }
        return fatherOfOldest.Salary;
    }
    public static void FindChildWithHigestIncome()
    {
        int maxIncome = 0;
        Child richestChild = null;

        foreach (Child child in childs)
        {
            if (child.Father.Salary + child.Mother.Salary > maxIncome)
            {
                maxIncome = child.Father.Salary + child.Mother.Salary;
                richestChild = child;
            }
        }
        Console.WriteLine(richestChild);
    }
    public static void SwapOldestAndYoungest()
    {
        int youngestIndex = 0;
        int oldestIndex = 0;

        for (int i = 1; i < childs.Length; i++)
        {
         Child currentChild = childs[i];

         if (currentChild.Age < childs[youngestIndex].Age) youngestIndex = i;
             
         if (currentChild.Age > childs[oldestIndex].Age)   oldestIndex = i; 

        }

        Child temp = childs[youngestIndex];
        childs[youngestIndex] = childs[oldestIndex];
        childs[oldestIndex] = temp;

        foreach (Child child in childs)
         {
          Console.WriteLine(child);
         }
    }
}





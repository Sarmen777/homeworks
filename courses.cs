using System;

class Module
{
    public string Title {get;}
    public int Duration {get;}

    public Module(string title, int duration)
    {
        Title = title;

        Duration = duration;
    }
}
abstract class Course
{
    public string Name {get;}
    public int Payment {get;}
    public Module[] Modules {get;}

    public Course(string name, int payment , Module[] modules)
    {
        Name = name;
        Payment = payment;
        Modules = modules;
    }
}

class Web : Course
{
    public string Type {get;}

    public Web(string name , int payment , Module[] modules , string type) : base(name, payment, modules)
    {
        Type = type;
    }
}
class Game : Course
{
    public string Engine {get;}

    public Game (string name , int payment , Module[] modules , string engine) : base(name, payment, modules)
    {
        Engine = engine;
    }
}
class AI : Course
{
    public AI (string name , int payment , Module[] modules) : base(name, payment, modules) {}
}

class Group
{
    public string Name {get;}
    public int StudentsCount {get;}
    public Course Course {get;}
}
static class GroupMethods
{
    public static int CountOfWebStudents (Group[] groups)
    {
        int count = 0;
        foreach (Group group in groups)
        {
            if (group.Course is Web) count += group.StudentsCount;
        }
        return count;
    }
    public static int UnrealIncome (Group[] groups)
    {
        int total = 0;
        foreach (Group group in groups)
        {
            if (group.Course is Game game && game.Name == "Unreal")
            {
                total += group.StudentsCount * game.Payment;
            }
        }
        return total;
    }
    public static string MostPopularCourse (Group[] groups)
    {
        string? mostPopular = null;
        int max = 0;
        foreach (Group group in groups)
        {
            int totalCount = 0;

            foreach (Group g in groups)
            {
                if (g.Course.Name == group.Course.Name)
                totalCount += g.StudentsCount;
            }
            if (totalCount > max)
            {
                max = totalCount;
                mostPopular = group.Course.Name;
            }
        }
        return mostPopular;
    }
}

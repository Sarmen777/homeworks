using System;
using System.Security.Cryptography;
class School
{
    private string Name;
    private string Mail;
    private Course[] Courses;
    private Instructor[] Instructors;

    public School(string name , string mail , Course[] courses , Instructor[] instructors)
    {
        Name = name;
        Mail = mail;
        Courses = courses;
        Instructors = instructors;
    }
    public string GetName() => Name;
    public Course[] GetCourses() => Courses;
    public Instructor[] GetInstructors() => Instructors;
    public Student FindStudentByEmail(string email)
    {
        foreach (var course in Courses)
        {
            foreach (var student in course.GetStudents())
            {
                if (student.GetMail() == email) return student;
            }
        }
        return null;
    }
    public static School FindSchoolByInstructor(Instructor instructor , School[] schools)
    {
        foreach(var school in schools)
        {
            foreach (var inst in school.Instructors)
            {
                if (inst == instructor) return school;
            }
        }
        return null;
    }
    public static School FindSchoolByStudent (Student student , School[] schools)
    {
        foreach(var school in schools)
        {
            foreach (var course in school.Courses)
            {
                foreach (var st in course.GetStudents())
                {
                    if (st == student) return school;
                }
            }
        }
        return null;
    }
    public void ListInstructors()
    {
        foreach (var instructor in Courses)
        {
            Console.WriteLine(instructor.GetName());;
        }
    }
}
class Course
{
    private string Name;

    private int Duration;
    private double Price;
    private int maxStudents = 25;
    private School School;
    private Student[] Students;

    public Course(string name , int duration , double price , School school , Student[] students)
    {
        Name = name;
        Duration = duration;
        Price = price;
        School = school;
        Students = students;
    }
    public string GetName() => Name;
    public Student[] GetStudents() => Students;

    public Student FindStudent (string studentName)
    {
        foreach (var st in Students)
        {
            if (st.GetName() == studentName) return st;
        }
        return null;
    }
    public void AddStudent (Student student)
    {
        if (Students.Length >= maxStudents) Console.WriteLine("There is no place for student");

        Student[] newStudents = new Student[Students.Length + 1];
        for (int i = 0 ; i < Students.Length ; i++)
        {
            newStudents[i] = Students[i];
        }
        newStudents[Students.Length] = student;
        Students = newStudents;
        Console.WriteLine("You have added new student");
    }
    public void RemoveStudent(Student student)
    {
        bool studentFound = false;

        foreach (var s in Students)
        {
            if (s == student)
            {
                studentFound = true;
                break;
            }
        }

        if (!studentFound)
        {
           Console.WriteLine("There is no student like that");
           return;
        }

        Student[] newStudents = new Student[Students.Length - 1];
        int j = 0;

        foreach (var s in Students)
        {
            if (s != student)
            {
            newStudents[j++] = s;
            }
        }

        Students = newStudents;
        Console.WriteLine($"Student was removed");
    }
    public void ListStudents()
    {
        foreach(Student student in Students)
        {
            Console.WriteLine(student.GetName());
        }
    }
}
class Student
{
    private string Name;
    private string Mail;
    private static int Id;
    private int IdentificationNumber;
    private int Age;
    private Course Course;
    private School School;

    public Student(string name , string mail , int age , Course course , School school)
    {
        Name = name;
        Age = age;
        Course = course;
        School = school;
        IdentificationNumber = ++Id;
    }
    public string GetName() => Name;
    public string GetMail() => Mail;
    public School GetSchool() => School;
    public Course GetCourses() => Course;
}
class Instructor
{
    private string Name;

    private string Mail;
    private int YearsOfExperience;
    private School School;

    public Instructor(string name , string mail , int experience , School school)
    {
        Name = name;
        Mail = mail;
        YearsOfExperience = experience;
        School = school;
    }
    public override string ToString()
    {
        return $"Name of instructor {Name} , Mail : {Mail}";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private int ID { get; set; }
    private string fName { get; set; }
    private string lName { get; set; }
    private DateTime DOB { get; set; }
    private string major { get; set; }
    private List<string> classes { get; set; }
    private bool isEnrolled { get; set; }
    public Student()
    {
        ID = 0;
        fName = "John";
        lName = "Doe";
        DOB = new DateTime(2000, 12, 5);
        major = "CIS";
        classes = new List<string> { "Home Ec", "WebDev", "Welding", "Biology" };
        isEnrolled = true;
    }
    public Student(int id, string fname, string lname, DateTime dob, string Major, List<string> Classes, bool ISenrolled)
    {
        ID = id;
        fName = fname;
        lName = lname;
        DOB = dob;
        major = Major;
        classes = Classes;
        isEnrolled = ISenrolled;
    }
    //place holders
    //Returnees from the Creating New Students part in the Main, Depending on if we JUST need this call they'll have to be modified, but since they don't leave this class if they complain about being undifined you can probably set them to Private without issue.



    public void CreateStudent()
    {
        string ans;
        int year = 0;
        int day = 0;
        int month = 0;
        int classesnum = 0;
        string Classname;
        while (ID == 0)
        {
            Console.WriteLine("Please Enter The students ID:");
            try { ID = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("This is not a valid ID");
                ID = 0;
            }
        }
        Console.WriteLine("Please Enter the Students First Name");
        fName = Console.ReadLine();
        Console.WriteLine("Please Enter the Students Last Name");
        lName = Console.ReadLine();
        while (year == 0)
        {
            Console.WriteLine("Please Enter the Students Year of Birth");
            try { year = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("This is not a valid Year");
                year = 0;
            }
        }
        while (month == 0)
        {
            Console.WriteLine("Please Enter the Students Month Of Birth (Numerical)");
            try
            {
                month = Convert.ToInt32(Console.ReadLine());
                if (month <= 0 || month > 12)
                {
                    Console.WriteLine("Month Must be between 1-12");
                    month = 0;
                }
            }
            catch
            {
                Console.WriteLine("This is not a valid month");
                month = 0;
            }
        }
        while (day == 0)
        {
            Console.WriteLine("Please Enter the Students Date of Birth");
            try
            {
                day = Convert.ToInt32(Console.ReadLine());
                if (day <= 0 || day > 31)
                {
                    Console.WriteLine("Day Must be between 1-31");
                    day = 0;
                }
            }
            catch
            {
                Console.WriteLine("This is not a valid Day");
                day = 0;
            }
        }
        DOB = new DateTime(year, month, day);
        Console.WriteLine("is this Student Enrolled? Y/N");
        ans = Console.ReadLine();
        while (ans != "Y" && ans != "N")
        {
            Console.WriteLine("Please Enter Either Y or N");
            ans = Console.ReadLine();
        }
        if (ans == "Y")
        {
            isEnrolled = true;
            Console.WriteLine("What is this students major?");
            major = Console.ReadLine();
            while (classesnum == 0)
            {
                Console.WriteLine("How many classes is this student taking?");
                try
                {
                    classesnum = Convert.ToInt32(Console.ReadLine());
                    if (classesnum < 0)
                    {
                        classesnum = 0;
                        Console.WriteLine("Number must be higher than Zero.");
                    }
                }
                catch
                {
                    Console.WriteLine("This is not a valid number.");
                    month = 0;
                }
            }
            classes = new List<string> { };
            for (int i = 0; i < classesnum; i++)
            {
                Console.WriteLine($"please Enter Class number {(i + 1)}");
                Classname = Console.ReadLine();
                classes.Add(new string(Classname));
            }

        }
        else
        {
            isEnrolled = false;
            major = "N/A";
            classes = new List<string> { "N/A" };
        }
    }

    public override string ToString()
    {
        string classesgrouped = string.Join(", ", classes);
        return $"ID: {ID}, First Name: {fName}, Last Name: {lName}, DOB: {DOB}, Major: {major}, Classes: {classesgrouped}, Enrolled: {isEnrolled}\n";
    }
}
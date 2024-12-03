using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int ID { get; set; }
    public string fName { get; set; }
    public string lName { get; set; }
    public DateTime DOB { get; set; }
    public string major { get; set; }
    public List<string> classes { get; set; }
    public bool isEnrolled { get; set; }
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
        this.ID = ID;
        this.fName = fName;
        this.lName = lName;
        this.DOB = DOB;
        this.major = major;
        this.classes = classes;
        this.isEnrolled = isEnrolled;
    }
    //place holders


    //Returnees from the Creating New Students part in the Main, Depending on if we JUST need this call they'll have to be modified, but since they don't leave this class if they complain about being undifined you can probably set them to Private without issue.
public void CreateStudent()
{
    Console.WriteLine("Enter ID:");
    ID = int.Parse(Console.ReadLine());

    Console.WriteLine("First Name:");
    fName = Console.ReadLine();

    Console.WriteLine("Last Name: ");
    lName = Console.ReadLine();

    Console.WriteLine("DOB (yyyy-mm-dd):");
    DOB = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Major:");
    major = Console.ReadLine();

    Console.WriteLine("Classes (comma separated):");
    classes = new List <string> (Console.ReadLine().Split(','));

    Console.WriteLine("Are you enrolled? (true/false)");
    isEnrolled = bool.Parse(Console.ReadLine());

}

public string ToCsv()
{
    return $"{ID}, {fName}, {lName}, {DOB:yyyy-mm-dd}, {major},\"{string.Join(";", classes)}\", {isEnrolled}";

}

using System;
using System.Collections.Generic;

public class Student
{
    public int ID { get; set; }
    public string fName { get; set; }
    public string lName { get; set; }
    public DateTime DOB { get; set; }
    public string Major { get; set; }
    public bool isEnrolled { get; set; }
    public List<Course> Courses { get; set; }  // List to hold courses

    // Constructor to initialize the student
    public Student(int id, string fname, string lname, DateTime dob, string major, bool isenrolled)
    {
        ID = id;
        fName = fname;
        lName = lname;
        DOB = dob;
        Major = major;
        isEnrolled = isenrolled;
        Courses = new List<Course>();  // Initialize the Courses list
    }

    // Method to add a course to the student's courses list
    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
}

public class Course
{
    public string ClassName { get; set; }
    public string ClassCode { get; set; }
    public string Instructor { get; set; }

    // Constructor to initialize the course details
    public Course(string className, string classCode, string instructor)
    {
        ClassName = className;
        ClassCode = classCode;
        Instructor = instructor;
    }
}


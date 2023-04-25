using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NewProject;

internal class Group
{
    public string No { get; set; }
    public int Limit { get; set; }
    private Student[] Students { get; set; } = new Student[0];

    public Group(int limit)
    {
        Limit = limit;
    }

    public void AddStudent(Student student)
    {
        if (Students.Length < Limit)
        {
            Student[] newList = new Student[Students.Length + 1];
            for (int i = 0; i < Students.Length; i++)
            {
                newList[i] = Students[i];
            }
            newList[Students.Length] = student;
            Students = newList;
            return;
        }
        else
        {
            Console.WriteLine("limit doludur");
        }
       
    }

    public string GetAll()
    {
        string result = "telebeler: ";
        foreach (var student in Students)
        {
            result += $" {student.Name}  {student.Surname}, ";
        }
        return result;

    }

}

   


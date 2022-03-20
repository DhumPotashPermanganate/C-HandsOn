using System;
using NUnit.Framework;
using App03;

namespace TestProject1;

public class Tests
{
    public Grades obj = new Grades();
    
    public void Setup()
    {
        obj.StudentName = new string[]
        {
            "Student1", "Student2", "Student3", "Student4", "Student5", "Student6", "Student7", "Student8", "Student9",
            "Student10"
        };
        obj.StudentMark = new double[]{55.0, 66.0, 88.0, 21.0, 90.0, 34.0, 41.0, 20.0, 67.0, 71.0};
    }

    
    [Test]
    public void Test1()
    {
        Setup();
        obj.PrintStatistics();
        Assert.AreEqual(obj.highest, 90.0);
    }
    [Test]
    public void Test2()
    {
        Setup();
        obj.PrintStatistics();
        Assert.AreEqual(obj.lowest, 20.0);
    }
    [Test]
    public void Test3()
    {
        Setup();
        obj.PrintStatistics();
        Assert.AreEqual(obj.mean, 55.3);
    }
    [Test]
    public void Test4()
    {
        Assert.AreEqual(obj.AssignGrade(75.0), "A Bsc(Hons) First Class");
    }
    
}
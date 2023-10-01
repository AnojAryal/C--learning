using System;

public class Class1
{
    public int id; 
    public string fullname;
    private string password;
    protected string address;

    public Class1()
    {
        // Initialize variables in the constructor
        id = 0;
        fullname = "";
        password = "";
        address = "";
    }
}

class Class2
{
    private int id;
    private string fullname;

    public Class2()
    {
        this.id = 1;
        this.fullname = "NA";
    }

    public Class2(int id, string fullname)
    {
        this.id = id;
        this.fullname = fullname;
    }

    public Class2(Class2 class2)
    {
        this.id = class2.id;
        this.fullname = class2.fullname;
    }

    public int GetId()
    {
        return this.id;
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public string GetFullName()
    {
        return this.fullname;
    }

    public void SetFullName(string fullname)
    {
        this.fullname = fullname;
    }

    public override string ToString()
    {
        return this.fullname + " " + this.id;
    }
}

class Class3
{
    private int id;

    public Class3(int id)
    {
        this.id = id;
    }

    public Class3(Class3 class3)
    {
        this.id = class3.id;
    }
}

public class Class4
{
    public int id; 
    public string fullname;
    private string password;
    protected string email;
}

public class Class4_1 : Class4
{
    public Class4_1()
    {
        id = -1;
        fullname = "anoj";
        password = "fastrack";
        email = "haha@gmail.com";
    }
}

class Class5
{
    private int id;

    public Class5(int id)
    {
        this.id = id;
    }

    public Class5(Class5 class5)
    {
        this.id = class5.id;
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Class1 obj_1 = new Class1();
        Console.WriteLine(obj_1.id);

        obj_1.fullname = "good";
        Console.WriteLine(obj_1.fullname);

        obj_1.password = "good";
        Console.WriteLine(obj_1.password);

        obj_1.address = "good";
        Console.WriteLine(obj_1.address);

        Class2 obj_2 = new Class2();

        obj_2.SetId(5);
        Console.WriteLine(obj_2.GetId());

        obj_2.SetFullName("anoj");
        Console.WriteLine(obj_2.GetFullName());

        Class2 obj_2_1 = new Class2(1, "anoj");

        Class2 obj_2_2 = new Class2(obj_2_1);

        Console.WriteLine(obj_2_2);

        Class3 obj3_1 = new Class3(10);
        Console.WriteLine(obj3_1.id);

        Class4_1 obj4_1 = new Class4_1();
        obj4_1.id = 1;
        obj4_1.fullname = "Anoj";
        obj4_1.password = "fastrack";
        obj4_1.email = "haha@gmail.com";
    }
}

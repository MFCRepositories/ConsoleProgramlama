using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public int age;
    public Person(int initialAge)
    {
        age = initialAge < 0 ? 0 : initialAge;
    }
    public void amIOld()
    {
        string status;
        if (age >= 18) status = "You are old.";
        else if (age >= 13 && age < 18) status = "You are a teenager.";
        else if (age > 0 && age <= 12) status = "You are young.";
        else status = "Age is not valid, setting age to 0.\nYou are young.";
        Console.WriteLine(status);
    }

    public void yearPasses()
    {
        age++;
    }

    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
    }
}
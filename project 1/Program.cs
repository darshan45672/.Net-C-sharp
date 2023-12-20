using System;
using project_1;

P1 p = new("darshan", 20);

Console.WriteLine($"hello {p.Name}!");
if (p.Age >= 21)
{
    Console.WriteLine($"you can marry as your age is {p.Age}");
}else
    Console.WriteLine("You are not eligible!!");
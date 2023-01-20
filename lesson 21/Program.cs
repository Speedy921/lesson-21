using System;
using lesson_21;

Console.WriteLine("*****Fun with Custom Exceptins***\n");
Car myCar = new Car("Rusty", 90);
try
{
    //отслеживать исключение
    myCar.Accelerate(50);
}
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.ErrorTimeStamp);
    Console.WriteLine(e.causeofError);
  
}
Console.ReadLine();
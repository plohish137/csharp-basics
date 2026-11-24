using System;

var car = new Car();
car.Start();

class Car
{
    public void Start()
    {
        Console.WriteLine("Start car engine!");
    }
}
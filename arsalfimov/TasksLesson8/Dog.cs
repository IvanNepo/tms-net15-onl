﻿namespace TasksLesson8;

using System;

public class Dog : Animal
{
    public override void Eat() => Console.WriteLine($"{GetName()} is eating.");
}
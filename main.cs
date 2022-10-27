// Created by: liya getachew
// Created on: Oct 12 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int baseA;
        int baseB;
        int height;

        Console.WriteLine("This program calculates the area of a trapezoid (cm).");

        Console.WriteLine("Enter the dimensions (base a, base b, height) of the trapezoid here: ");
        Console.WriteLine("");

        Console.Write("Base A of trapezoid (cm): ");
        baseA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Base B of trapezoid (cm): ");
        baseB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("Height of trapezoid (cm): ");
        height = Convert.ToInt32(Console.ReadLine());

        int area = ((baseA + baseB) / 2) * height;

        Console.WriteLine("");
        Console.WriteLine("Area = " + area + " cm².");

        Console.WriteLine("\nDone.");
    }
}

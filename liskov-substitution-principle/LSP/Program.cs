using LSP;
using System;

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

Calculator calc = new SumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {calc.Calculate()}");

Console.WriteLine();

calc = new ProductCalculator(numbers);
Console.WriteLine($"The product of all the numbers: {calc.Calculate()}");


Console.WriteLine();


calc = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {calc.Calculate()}");

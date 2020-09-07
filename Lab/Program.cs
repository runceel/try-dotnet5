using System;

var p = new Point(10, 100);
Console.WriteLine(p.X);

record Point(int X, int Y);

using Matrix2DLib;

var m = new Matrix2D(1, 2, 3, 4);
var p = new Matrix2D(1, 2, 3, 4);
Console.WriteLine(m);
Console.WriteLine(m == p);
Console.WriteLine(m + p);
Console.WriteLine(m - p);
Console.WriteLine(m * p);
Console.Write("Press enter to exit");
Console.Read();
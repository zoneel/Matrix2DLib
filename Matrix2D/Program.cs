using Matrix2DLib;

var m = new Matrix2D(1, 2, 3, 4);
var p = new Matrix2D(1, 2, 3, 4);
Console.WriteLine(m);
Console.WriteLine(m == p);
Console.WriteLine(m + p);
Console.WriteLine(m - p);
Console.WriteLine(m * p);
Console.WriteLine(3 * p);
Console.WriteLine(p * 3);
Console.WriteLine(-m);
Console.WriteLine(Matrix2D.Transpose(m));
Console.WriteLine(Matrix2D.Determinant(m));
Console.WriteLine(m.Det());
Console.WriteLine(Matrix2D.ToIntArray(m));
//Console.Write("Press enter to exit");
//Console.Read();
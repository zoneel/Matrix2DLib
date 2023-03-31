using System.Text.RegularExpressions;

namespace Matrix2DLib
{
    public class Matrix2D : IEquatable<Matrix2D>
    {
        public int A { get; init; }
        public int B { get; init; }
        public int C { get; init; }
        public int D { get; init; }

        public Matrix2D(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Matrix2D() : this(1, 0, 0, 1) { }

        public static Matrix2D Zero { get;  } = new Matrix2D(0,0,0,0);
        public static readonly Matrix2D Id = new Matrix2D();

        public override string ToString() => $"[[{A}, {B}], [{C}, {D}]]";

        public bool Equals(Matrix2D? other)
        {
            if(other is null) return false; //is operator is available after C# 8
            if(ReferenceEquals(this, other)) return true;

            return A == other.A && B == other.B && C == other.C && D == other.D;

        }

        public override bool Equals(object? obj)
        {
            if( obj is null) return false;
            if( obj is not Matrix2D ) return false;

            return Equals(obj as Matrix2D); //or by casting (Matrix2D)obj
        }

        public override int GetHashCode() => HashCode.Combine(A, B, C, D); //its required by collections to effectively manage data.

        public static bool operator==(Matrix2D left, Matrix2D right) //overrides == operator (checks if left side is equal to right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Matrix2D left, Matrix2D right) //overrides != operator (checks if left side is not equal to right)
        {
            return !left.Equals(right);
        }

        public static Matrix2D operator +(Matrix2D matrix1, Matrix2D matrix2) //overrides + operator
        {
            int outA = matrix1.A + matrix2.A;
            int outB = matrix1.B + matrix2.B;
            int outC = matrix1.C + matrix2.C;
            int outD = matrix1.D + matrix2.D;
            Matrix2D output = new Matrix2D(outA, outB, outC, outD);

            return output;
        }

        public static Matrix2D operator -(Matrix2D matrix1, Matrix2D matrix2) //overrides - operator
        {
            int outA = matrix1.A - matrix2.A;
            int outB = matrix1.B - matrix2.B;
            int outC = matrix1.C - matrix2.C;
            int outD = matrix1.D - matrix2.D;
            Matrix2D output = new Matrix2D(outA, outB, outC, outD);

            return output;
        }

        public static Matrix2D operator *(Matrix2D matrix1, Matrix2D matrix2)//overrides * operator
        {
            int outA = (matrix1.A * matrix2.A) +(matrix1.B * matrix2.C);
            int outB = (matrix1.A * matrix2.B) +(matrix1.B * matrix2.D);
            int outC = (matrix1.C * matrix2.A) +(matrix1.D * matrix2.C);
            int outD = (matrix1.C * matrix2.B) +(matrix1.D * matrix2.D);
            Matrix2D output = new Matrix2D(outA, outB, outC, outD);

            return output;
        }

        public static Matrix2D operator *(int num, Matrix2D matrix2) //lefthand multiplication by int
        {
            int outA = num * matrix2.A;
            int outB = num * matrix2.B;
            int outC = num * matrix2.C;
            int outD = num * matrix2.D;
            Matrix2D output = new Matrix2D(outA, outB, outC, outD);

            return output;
        }

        public static Matrix2D operator *(Matrix2D matrix2, int num) //righthand multiplication by int
        {
            int outA = num * matrix2.A;
            int outB = num * matrix2.B;
            int outC = num * matrix2.C;
            int outD = num * matrix2.D;
            //Matrix2D output = new Matrix2D(outA, outB, outC, outD);
            return new Matrix2D(outA, outB, outC, outD);
        }

        public static Matrix2D operator -(Matrix2D matrix)
        {
            int outA = matrix.A * (-1);
            int outB = matrix.B * (-1);
            int outC = matrix.C * (-1);
            int outD = matrix.D * (-1);
            //Matrix2D output = new Matrix2D(outA, outB, outC, outD);
            return new Matrix2D(outA, outB, outC, outD);
        }

        public static Matrix2D Transpose(Matrix2D matrix) => new Matrix2D(matrix.A, matrix.C, matrix.B, matrix.D); //transpose this matrix

        public static int Determinant(Matrix2D matrix) => matrix.A*matrix.D-matrix.B*matrix.C; // class method of Determinant function

        public int Det() => this.A * this.D - this.B * this.C; // instance method of Determinant function

        public static int[,] ToIntArray(string matrix){
            Regex regex = new Regex(@"^\[\[(\d+), (\d+)\], \[(\d+), (\d+)\]\]$");
            Match match = regex.Match(matrix);
            if (match.Success)
            {
                int a = int.Parse(match.Groups[1].Value);
                int b = int.Parse(match.Groups[2].Value);
                int c = int.Parse(match.Groups[3].Value);
                int d = int.Parse(match.Groups[4].Value);
                Console.WriteLine($"A: {a}, B: {b}, C: {c}, D: {d}");
                return new int[2, 2] { { a, b }, { c, d } };

            }
            else
            {
                throw new FormatException("Invalid format");
            }
        }
    }
}

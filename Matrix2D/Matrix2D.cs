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

        public static Matrix2D operator +(Matrix2D matrix1, Matrix2D matrix2)
        {
            int outA = matrix1.A + matrix2.A;
            int outB = matrix1.B + matrix2.B;
            int outC = matrix1.C + matrix2.C;
            int outD = matrix1.D + matrix2.D;
            Matrix2D output = new Matrix2D(outA, outB, outC, outD);

            return output;
        }



    }
}

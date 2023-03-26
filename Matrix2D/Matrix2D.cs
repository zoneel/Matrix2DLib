﻿namespace Matrix2DLib
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
            if(other == null) return false;
            if(ReferenceEquals(this, other)) return true;

            return A == other.A && B == other.B && C == other.C && D == other.D;

        }

        public override bool Equals(object? obj)
        {
            if( obj is null) return false;
            if( obj is not Matrix2D ) return false;

            return Equals(obj as Matrix2D); //or by casting (Matrix2D)obj
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}

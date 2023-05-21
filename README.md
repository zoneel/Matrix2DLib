# Matrix2D

![License](https://img.shields.io/badge/license-MIT-blue.svg)

**Matrix2D is a class that allows you to define and implement the functionality of a 2D matrices. This class provides a convenient and efficient way to work with matrices, supporting various operations and calculations.**

## Features

- Define and manipulate 2D arrays easily with the Matrix2D class.
- Implements overloads for `ToString()`, `IEquatable<Matrix2D>`, and all arithmetic operators such as `+`, `-`, and `*`.
- Custom functions like `Determinant(A)` and `Det()` are provided to calculate the determinant of the matrix.

## Installation

You can simply clone the repository or download the source code and include it in your project.

```bash
git clone https://github.com/zoneel/Matrix2D.git
```

## Usage

First, include the Matrix2D class in your project:

```csharp
using Matrix2D;
```

To create a new matrix, initialize an instance of the Matrix2D class:

```csharp
Matrix2D matrix = new Matrix2D(a,b,c,d);
```

Perform operations on the matrix using the available methods and operators:

```csharp
Matrix2D matrixA = new Matrix2D(1,2,3,4);
Matrix2D matrixB = new Matrix2D(5,6,7,8);
Matrix2D result = matrixA + matrixB;
```

You can also use the provided custom functions to calculate the determinant:

```csharp
Matrix2D matrix = new Matrix2D(7,2,4,5);
double determinant = matrix.Determinant();
```

## Examples

Here are a few examples to illustrate the usage of the Matrix2D class:

```csharp
Matrix2D matrixA = new Matrix2D(1,2,3,4);
matrixA.A = 1;
matrixA.B = 2;
matrixA.C = 3;
matrixA.D = 4;

Matrix2D matrixB = new Matrix2D(1,2,3,4);
matrixA.A = 1;
matrixA.B = 2;
matrixA.C = 3;
matrixA.D = 4;

Matrix2D result = matrixA + matrixB;

Console.WriteLine(result.ToString());
```

Output:

```
[[1, 2], [3, 4]]
```

## Contributing

Contributions are welcome! If you find any issues or have suggestions, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License.

---

**Note:** **This project is for educational purposes and may not be suitable for production environments.**

using System;

namespace Consoleapp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix mass = new Matrix();
            Matrix mass2 = new Matrix();
            Matrix mass3 = new Matrix(3);
            Matrix mass4 = new Matrix(3);
            Console.WriteLine("Enter matrix A: ");
            mass.WriteMat();
            Console.WriteLine("Enter matrix B: ");
            mass2.WriteMat();
            Console.WriteLine("Matrix A: ");
            mass.ReadMat();
            Console.WriteLine("Matrix B: ");
            mass2.ReadMat();
            Console.WriteLine("Addition A and B: ");
            mass3 = (mass + mass2);
            mass3.ReadMat();
            Console.WriteLine("Multipicaton A and B:");
            mass4 = (mass * mass2);
            mass4.ReadMat();
            Console.WriteLine("Transparent Matrix A: ");
            mass.TransparentMatrix();
            mass.ReadMat();
        }
    }

}
using System;

namespace Matrix
{
    class Matrix
    {
        // Скрытые поля
        private int n;
        private int[,] mass;
        // Создаем конструкторы матрицы
        public Matrix() { }
        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }
        // Задаем аксессоры для работы с полями вне класса Matrix
        public Matrix(int n)
        {
            this.n = n;
            mass = new int[this.n, this.n];
        }
        public int this[int i, int j]
        {
            get
            {
                return mass[i, j];
            }
            set
            {
                mass[i, j] = value;
            }
        }
        // Ввод матрицы с клавиатуры
        public void WriteMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Enter element", i + 1, j + 1);
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        // Вывод матрицы с клавиатуры
        public void ReadMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //Сложение матриц
        public static Matrix Sum(Matrix a, Matrix b)
        {
            Matrix resMass = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    resMass[i, j] = a[i, j] + b[i, j];
                }
            }
            return resMass;
        }
        // Умножение матрицы А на матрицу Б
        public static Matrix mult(Matrix a, Matrix b)
        {
            Matrix resMass = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        resMass[i, j] += a[i, k] * b[k, j];

            return resMass;
        }
        //Транспонирование матрицы
        public void TransparentMatrix()
        {
            int temp;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    temp = mass[i, j];
                    mass[i, j] = mass[j, i];
                    mass[j, i] = temp;
                }
            }
        }
        //Перегрузка оператара сложения
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.Sum(a, b);
        }
        //Перегрузка оператора умножить
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.mult(a, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix mass = new Matrix(3);
            Matrix mass2 = new Matrix(3);
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

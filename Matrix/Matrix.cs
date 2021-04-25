using System;

namespace Consoleapp1
{
    public class Matrix
    {
        // Скрытые поля
        private int n;
        private int[,] mass;
        // Создаем конструкторы матрицы
        public Matrix()
        {
            n = 2;
            mass = new int[2, 2];
            int[,] array = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            mass = array;
        }
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
        public int[,] getarray()
        {
            return this.mass;
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

}
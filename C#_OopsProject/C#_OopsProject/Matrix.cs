namespace OopsProject
{
    internal class Matrix
    {
        int a;
        int b;
        int c;
        int d;

        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override string ToString()
        {
            return $"{a} {b}\n{c} {d}";
        }
        public static string ToStringPattern(int x)
        {
            string Pattern = "";
            for (int j = 0; j < x; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Pattern = Pattern + "* ";
                }
                Pattern = Pattern + "\n";
            }
            return Pattern;
        }

        public static Matrix operator +(Matrix left, Matrix right)
        {
            Matrix obj = new Matrix(left.a + right.a, left.b + right.b, left.c + right.c, left.d + right.d);
            return obj;
        }

        public static void Main()
        {
            Matrix m1 = new Matrix(2, 4, 6, 8);
            Matrix m2 = new Matrix(3, 5, 7, 9);

            Matrix m3 = m1 + m2;
            Console.WriteLine(m3);

            Console.Write("Enter a number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            string str = Matrix.ToStringPattern(x);
            Console.WriteLine(str);

            Console.ReadLine();
        }   
    }
}

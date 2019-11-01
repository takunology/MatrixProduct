using System;

namespace MatrixProduct
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Matrix Calc.");
            while (true)
            {
                Console.Clear();
                MatrixCalc();
            }
        }

        static void MatrixCalc()
        {
            Console.WriteLine("行列Aのパラメータ");
            Console.Write("行数：");
            int Ax = int.Parse(Console.ReadLine());
            Console.Write("列数：");
            int Ay = int.Parse(Console.ReadLine());
            double[,] matrixA = new double[Ax, Ay];

            //行列Aの入力ロジック
            Random rndX = new Random();
            for (int x = 0; x < Ax; x++)
            {
                for (int y = 0; y < Ay; y++)
                {
                    matrixA[x, y] = double.Parse(rndX.Next(0,9).ToString()); //x行y列に要素を代入
                }
            }

            Console.WriteLine("\n行列Bのパラメータ");
            Console.Write("行数：");
            int Bx = int.Parse(Console.ReadLine());
            Console.Write("列数：");
            int By = int.Parse(Console.ReadLine());
            double[,] matrixB = new double[Bx, By];

            //行列Bの入力ロジック
            Random rndY = new Random();
            for (int x = 0; x < Bx; x++)
            {
                for (int y = 0; y < By; y++)
                {
                    matrixB[x, y] = double.Parse(rndY.Next(0, 9).ToString()); //x行y列に要素を代入
                }
            }

            Console.WriteLine("\nA = ");
            //入力された行列Aの表示
            for (int x = 0; x < Ax; x++)
            {
                Console.Write("| ");
                for (int y = 0; y < Ay; y++)
                {
                    Console.Write($"{matrixA[x, y]} ");
                }
                Console.WriteLine("|");
            }

            Console.WriteLine("\nB = ");
            //入力された行列Bの表示
            for (int x = 0; x < Bx; x++)
            {
                Console.Write("| ");
                for (int y = 0; y < By; y++)
                {
                    Console.Write($"{matrixB[x, y]} ");
                }
                Console.WriteLine("|");
            }

            //積の和
            Console.WriteLine("\nAB = ");
            double[,] matrixC = new double[Ax, By];

            for (int x = 0; x < Ax; x++)
            {
                for (int y = 0; y < By; y++)
                {
                    for (int k = 0; k < Ay; k++) //共通要素数は k で変数を分けて考える
                    {
                        matrixC[x, y] += (matrixA[x, k] * matrixB[k, y]);
                    }
                }
            }

            //計算結果の表示
            for (int x = 0; x < Ax; x++)
            {
                Console.Write("|");
                for (int y = 0; y < By; y++)
                {
                    //Console.Write($"{matrixC[x, y]} ");
                    Console.Write(string.Format("{0,4}", matrixC[x, y]));
                }
                Console.WriteLine(" |");
            }
            Console.ReadKey();
            return;
        }
    }
}

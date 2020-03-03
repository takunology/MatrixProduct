using System;

namespace MatrixProduct_Input
{
    class Program
    {
        static int ROW_A = 0;
        static int COL_A = 0;

        static int ROW_B = 0;
        static int COL_B = 0;

        static int[,] MatrixA = new int[ROW_A, COL_A];
        static int[,] MatrixB = new int[ROW_B, COL_B];
        static int[,] MatrixResult = new int[ROW_A, COL_B];

        static void Main(string[] args)
        {
            Input();
            Calc();
            ShowResult();
        }

        static void Input()
        {
            Console.Write("行列Aの行数：");
            ROW_A = int.Parse(Console.ReadLine());
            Console.Write("行列Aの列数：");
            COL_A = int.Parse(Console.ReadLine());
            Console.WriteLine("行列Aのパラメータ入力");

            MatrixA = new int[ROW_A, COL_A];

            for (int i = 0; i < ROW_A; i++)
            {
                for(int j = 0; j < COL_A; j++)
                {
                    MatrixA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("行列Bの行数：");
            ROW_B = int.Parse(Console.ReadLine());
            if (COL_A != ROW_B)
            {
                Console.WriteLine("行列Aの列数と行列Bの行数が異なるため計算できません。");
                return;
            }

            Console.WriteLine("行列Bの列数：");
            COL_B = int.Parse(Console.ReadLine());
            Console.WriteLine("行列Bのパラメータ入力");

            MatrixB = new int[ROW_B, COL_B];

            for (int i = 0; i < ROW_B; i++)
            {
                for (int j = 0; j < COL_B; j++)
                {
                    MatrixB[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }

        static void Calc()
        {
            MatrixResult = new int[ROW_A, COL_B]; //結果行列は行列Aの行数と行列Bの列数で再定義
            for(int i = 0; i < ROW_A; i++)
            {
                for(int j = 0; j < COL_B; j++)
                {
                    for(int k = 0; k < COL_A; k++)
                    {
                        MatrixResult[i, j] += MatrixA[i, k] * MatrixB[k, j];
                    }
                }
            }
        }

        static void ShowResult()
        {
            Console.WriteLine("====== 計算結果 =====");
            for(int i = 0; i < MatrixResult.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < MatrixResult.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0,4}", MatrixResult[i, j]));
                }
                Console.WriteLine(" |");
            }
            Console.ReadKey();
        }
    }
}
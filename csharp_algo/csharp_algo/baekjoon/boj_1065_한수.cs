﻿using System;

namespace csharp_algo.baekjoon
{
    class boj_1065_한수
    {
        static int N;
        static int result;

        internal static void Program(string[] args)
        {
            N = int.Parse(Console.ReadLine());

            if (N < 100)
            {
                Console.WriteLine(N);
                return;
            }

            result = 99;
            for (int i = 100; i <= N; i++)
            {
                char[] number = i.ToString().ToCharArray();

                int diff = number[1] - number[0];
                Boolean flag = true;
                for (int j = 2; j < number.Length; j++)
                {
                    if (number[j] - number[j - 1] != diff)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) result++;
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid_test_study
{
    internal class Class_3
    {

        static void arr_1()
        {
            int people = int.Parse(Console.ReadLine());
            int[] student = new int[people];
            int sum = 0;
            int max = 0, min = 1000;

            for (int i = 0; i < people; i++)
            {
                Console.Write($"학생 {i + 1} 성적 입력 :");
                int score = int.Parse(Console.ReadLine());
                student[i] = score;
            }

            for (int i = 0; i < people; i++)
            {
                sum += student[i];
                if (student[i] > max)
                    max = student[i];
                if (student[i] < min)
                    min = student[i];
            }
            Console.WriteLine($"평균 : {sum / people}");
            Console.WriteLine($"최고점 : {max}");
            Console.WriteLine($"최저점 : {min}");
        }
        /// 주된 내용은 배열.

        static void arr_2()
        {
            Console.Write("돈 넣어라 이자식아 : ");
            int money = int.Parse(Console.ReadLine());
            int won_1000 = money / 1000;
            int[,] number = new int[won_1000, 6];

            Console.WriteLine("로또 번호 출력");
            for (int i = 0; i < won_1000; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    number[i, j] = new Random().Next(1, 45);
                    if (j == 0)
                    {
                        continue;
                    }
                    else if (number[i, j - 1] == number[i, j])
                    {
                        j--;
                        continue;
                    }
                    Console.Write(number[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void class_3(string[] args)
        {
            /// 해당 내용 확인 시 아래 주석 해제
            /// arr_1();
            /// arr_2();
            Console.WriteLine("영화관 좌석 예약 시스템");
            Console.WriteLine("1. 좌석 현황 체크");
            Console.WriteLine("2. 좌석 예약");
            Console.WriteLine("3. 종료");
            Console.Write("메뉴 선택 : ");
            int menu = int.Parse(Console.ReadLine());

            int[][] theater_seat = new int[3][];
            theater_seat[0] = new int[6];
            theater_seat[1] = new int[9];
            theater_seat[2] = new int[12];


            for (int i = 0; i < theater_seat.Length; i++)
            {
                for (int j = 0; j < theater_seat[i].Length; j++)
                {
                    Console.Write("[ ] ");
                    if ((j+1) % 5 == 0) Console.WriteLine();

                }
                Console.WriteLine();
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mid_test_study
{
    internal class study_mid
    {
        /// 클래스와 Property 생성 Character
        public class Character
        {
            public string name { get; set; }
            private int hp;
            public int Hp
            {
                get { return hp; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("0보다 적을 수 없음");
                    }
                    else
                    {
                        hp = value;
                    }
                }
            }
            public int level
            {
                get { return level; }
                private set
                {
                    // LevelUp();
                }

            }
            public Character(string name, int hp, int level)
            {
                name = this.name;
                hp = this.hp;
                level = this.level;
            }

        }
        public class CharaterManager
        {
            public Character[] arr { get; set; } = new Character[5];
            public Character this[int index]
            {
                get { return arr[index]; }
                set { arr[index] = value; }
            }
        }

        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("진행은 1, 종료는 0 : ");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 0)
                    {
                        Console.WriteLine("종료합니다.");
                        break;
                    }
                    Console.Write("캐릭터의 이름 : ");
                    string name = Console.ReadLine();
                    Console.Write("캐릭터의 체력 : ");
                    int hp = int.Parse(Console.ReadLine());
                    Console.Write("캐릭터의 레벨 : ");
                    int level = int.Parse(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    Console.WriteLine("잘못된 입력입니다. " + e);
                }
                string path = "C:\\Users\\super\\OneDrive\\바탕 화면\\폴더정리\\1. Project\\3학년\\03. C#\\grade_3_project\\date.json";
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.ReadWrite);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mid_test_study
{
    internal class class_2
    {
        class Player
        {
            public int hp, level, exp, attack;
            public Player()
            {
                hp = 100;
                level = 1;
                exp = 0;
                attack = 10;
            }
          public void MAttack(Monster monster)
            {
                monster.hp -= attack;
                Console.WriteLine("몬스터 공격! 몬스터의 남은 체력 : " + monster.hp);
                if (monster.hp <= 0)
                {
                    exp += monster.exp;
                    if (exp >= 10)
                    {
                        level++;
                        exp = 0;
                        Console.WriteLine("레벨업! 현재 레벨 : " + level);
                    }
                }
            }
        }
        class Monster
        {
            public int hp, level, exp, attack;
            public Monster()
            {
                hp = 50;
                level = 1;
                attack = 5;
                exp = 5;
            }
            public void PAttack(Player player)
            {
                player.hp -= attack;
                Console.WriteLine("플레이어 공격! 플레이어의 남은 체력 : " + player.hp);
            }
        }
        /// 다른 파일도 추가 하기 위해 Main 대신 다른 파일로 작성
        static void Class_2(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();

            Console.WriteLine("게임 시작!");
            while(player.hp > 0 && monster.hp > 0)
            {
                player.MAttack(monster);
                if(monster.hp <= 0)
                {
                    Console.WriteLine("몬스터를 처치했습니다!");
                    break;
                }
                monster.PAttack(player);
                if(player.hp <= 0)
                {
                    Console.WriteLine("플레이어가 패배했습니다!");
                    break;
                }
            }
            Console.WriteLine("게임 종료!");
        }
    }
}

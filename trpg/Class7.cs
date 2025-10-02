using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
//연습용
namespace trpg
{
    public class Character
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int Level { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Hp { get; set; }
        public int Gold { get; set; }
        public int Experience { get; set; }
        public int Stamina { get; set; }

        public Character(string name, string job, int level, int attack, int defense, int hp, int gold, int experience, int stamina)
        {
            Name = name;
            Job = job;
            Level = level;
            Attack = attack;
            Defense = defense;
            Hp = hp;
            Gold = gold;
            Experience = experience;
            Stamina = stamina;

        }
    }
    internal class Class7
    {
        static Character player;

        //아이템 이름
        static List<string> itemNamesList = new List<string> { "낡은 로브", "낡은 지팡이", "낡은 완드", "운영자의 검" };

        //아이템 타입
        static List<int> itemTypesList = new List<int> { 1, 0, 0, 0 };

        //아이템 스텟
        static List<int> itemStatsList = new List<int> { 3, 5, 4, 9999 };

        //아이템 설명
        static List<string> itemDescriptionsList = new List<string>
        {
            "금방이라도 찢어질 것 같다.",
            "흔하게 볼 수 있는 지팡이다.",
            "지팡이보다 가볍다.",
            "운영자의 검이다"
        };

        //보유
        static List<bool> itemOwndList = new List<bool> { true, true, true, true };

        //장착 표시
        static List<bool> itemEquippedList = new List<bool> { false, false, false, false };

        static void Main(string[] args)
        {
            player = new Character("kont", "마법사", 10, 20, 5, 100, 500, 0, 20);

            while (true)
            {
                ShowMainMenu();
                string input = Console.ReadLine();

                if (input == "1")
                {
                    ShowStatus();
                }
                else if (input == "2")
                {
                    ShowInventory();
                }
                else if (input == "3")
                {
                    RandomAdventure();
                }
                else if (input == "4")
                {
                    PatrolVillage();
                }
                else
                {
                    Console.WriteLine("\n잘못된 입력입니다. 다시 입력해주세요.");
                    Console.ReadLine();
                }
            }
        }

        //메인 메뉴
        static void ShowMainMenu()
        {
            Console.Clear();
            string intro = @"
스파르타 마을에 오신 것을 환영합니다.
이곳에서 던전으로 들어가기 전
활동을 할 수 있습니다.";
            Console.WriteLine(intro);
            Console.WriteLine("\n1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 랜덤모험");
            Console.WriteLine("4. 마을 순찰하기");
            Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
        }

        //상태 보기
        static void ShowStatus()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

                //아이템 능력치 합산
                int totalAttack = 0;
                int totalDefense = 0;

                for (int i = 0; i < itemNamesList.Count; i++)
                {
                    if (itemEquippedList[i])
                    {
                        if (itemTypesList[i] == 0)
                            totalAttack += itemStatsList[i];
                        else if (itemTypesList[i] == 1)
                            totalDefense += itemStatsList[i];
                    }
                }

                Console.WriteLine($"Lv. {player.Level:D2}");
                Console.WriteLine($"{player.Name} ( {player.Job} )");
                Console.WriteLine($"공격력 : {player.Attack}{(totalAttack > 0 ? $" (+{totalAttack})" : "")}");
                Console.WriteLine($"방어력 : {player.Defense}{(totalDefense > 0 ? $" (+{totalDefense})" : "")}");
                Console.WriteLine($"체 력 : {player.Hp}");
                Console.WriteLine($"Gold : {player.Gold} G");

                Console.WriteLine("\n0. 나가기");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");

                string input = Console.ReadLine();

                if (input == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n잘못된 입력입니다.");
                    Console.ReadLine();
                }
            }
        }

        //인벤토리
        static void ShowInventory()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("인벤토리");
                Console.WriteLine("인벤토리의 정보가 표시됩니다.\n");

                //아이템 정보, 장착 표시
                for (int i = 0; i < itemNamesList.Count; i++)
                {
                    string typeText = (itemTypesList[i] == 1) ? "방어력" : "공격력";
                    string eTxt = itemEquippedList[i] ? "[E]" : " ";
                    Console.WriteLine($"{eTxt}{i + 1}. {itemNamesList[i]} | {typeText} +{itemStatsList[i]} | {itemDescriptionsList[i]}");
                }

                Console.WriteLine("\n1.장착 관리");
                Console.WriteLine("0.나가기");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    ShowEquipManage();
                }
                else if (input == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\n잘못된 입력입니다.");
                    Console.ReadLine();
                }
            }
        }

        //장착 관리
        static void ShowEquipManage()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("인벤토리 - 장착 관리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");

                for (int i = 0; i < itemNamesList.Count; i++)
                {
                    if (itemOwndList[i])
                    {
                        string typeText = (itemTypesList[i] == 1) ? "방어력" : "공격력";
                        string eTxt = itemEquippedList[i] ? "[E]" : " ";
                        Console.WriteLine($"{i + 1}. {(itemEquippedList[i] ? "[E]" : " ")}{itemNamesList[i]} | {typeText} +{itemStatsList[i]} | {itemDescriptionsList[i]}");
                    }
                }

                Console.WriteLine("0.나가기");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    break;
                }
                else if (int.TryParse(input, out int choice) && choice >= 1 && choice <= itemNamesList.Count)
                {
                    int index = choice - 1;

                    if (itemOwndList[index])
                    {
                        itemEquippedList[index] = !itemEquippedList[index];
                    }

                }
                else
                {
                    Console.WriteLine("\n잘못된 입력입니다.");
                    Console.ReadLine();
                }
            }
        }
        //모험하기
        static void RandomAdventure()
        {
            if (player.Stamina < 10)
            {
                Console.WriteLine("\n스태미나가 부족합니다!");
                Console.ReadLine();
                return;
            }

            player.Stamina -= 10;
            Random rand = new Random();
            int result = rand.Next(0, 2);

            if (result == 0)
            {
                Console.WriteLine("\n몬스터 조우! 500 골드 획득!");
                player.Gold += 500;
            }
            else
            {
                Console.WriteLine("\n아무일도 일어나지 않았다!");
            }

            Console.WriteLine($"\n현재 골드 : {player.Gold} G | 스태미나 : {player.Stamina}");
            Console.ReadLine();

        }

        //마을 순찰하기 작업중
        static void PatrolVillage()
        {
            if (player.Stamina < 5)
            {
                Console.WriteLine("\n스태미너가 부족합니다!");
                return;
            }
            player.Stamina -= 5;
            Random rand = new Random();

            Console.Clear();
            Console.WriteLine("\n마을을 순찰 중입니다...");
            Console.ReadLine();
        }
    }
}



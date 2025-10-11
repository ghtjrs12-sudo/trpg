using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
        static Random rand = new Random();

        //아이템 이름
        static List<string> itemNamesList = new List<string> { "낡은 로브", "낡은 지팡이", "낡은 완드", "운영자의 검", "운영자의 옷" };

        //아이템 타입
        static List<int> itemTypesList = new List<int> { 1, 0, 0, 0, 1 };

        //아이템 스텟
        static List<int> itemStatsList = new List<int> { 3, 5, 4, 9999, 999 };

        //아이템 설명
        static List<string> itemDescriptionsList = new List<string>
        {
            "금방이라도 찢어질 것 같다.",
            "흔하게 볼 수 있는 지팡이다.",
            "지팡이보다 가볍다.",
            "운영자의 검이다.",
            "운영자의 옷이다."
        };

        //보유
        static List<bool> itemOwndList = new List<bool> { true, true, true, true, true };

        //장착 표시
        static List<bool> itemEquippedList = new List<bool> { false, false, false, false, false };

        static void Main(string[] args)
        {
            player = new Character("kont", "마법사", 10, 20, 5, 100, 500, 0, 30);

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
                else if (input == "5")
                {
                    Training();
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
            Console.WriteLine("5. 훈련하기");
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

                    string name = itemNamesList[i].PadRight(10);
                    string type = typeText.PadRight(10);
                    string desc = itemDescriptionsList[i].PadRight(30);

                    Console.WriteLine($"{eTxt}{i + 1}. {name} | {type} +{itemStatsList[i],3} | {desc}");
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
                Console.WriteLine("[아이템 목록]");

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

                    //디버깅으로 인한 주석처리 
                    //if (itemOwndList[index])
                    //{
                    //    Console.WriteLine("\n아직 소유하지 않은 아이템입니다.");
                    //    Console.ReadLine();
                    //    continue;
                    //}

                    int selectedType = itemTypesList[index];

                    if (itemEquippedList[index])
                    {
                        itemEquippedList[index] = false;
                        Console.WriteLine($"\n{itemNamesList[index]} 장착을 해제했습니다.");
                    }
                    else
                    {
                        for(int i = 0; i < itemEquippedList.Count; i++)
                        {
                            if (itemEquippedList[i] && itemTypesList[i] == selectedType)
                            {
                                itemEquippedList[i] = false;
                            }
                        }

                        itemEquippedList[index] = true;
                        Console.WriteLine($"\n{itemNamesList[index]}을(를) 장착했습니다!");
                    }
                    Console.ReadLine();

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
            int roll = rand.Next(1, 101);

            if (roll <= 50)
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

        //마을 순찰하기
        static void PatrolVillage()
        {
            if (player.Stamina < 5)
            {
                Console.WriteLine("\n스태미너가 부족합니다!");
                Console.ReadLine();
                return;
            }

            player.Stamina -= 5;
            int roll = rand.Next(1, 101);

            if (roll <= 10)
            {
                Console.WriteLine("\n마을 아이들이 모여있다. 간식을 사줘볼까?");
                if (player.Gold >= 500)
                {
                    player.Gold -= 500;
                    Console.WriteLine("500 G를 사용했다.");
                }
                else
                {
                    Console.WriteLine("골드가 부족해 간식을 사주지 못했다.");
                }
            }
            else if (roll <= 20)
            {
                Console.WriteLine("\n촌장님을 만나서 심부름을 했다.");
                player.Gold += 2000;
                Console.WriteLine("2000 G를 획득했다!");
            }
            else if (roll <= 40)
            {
                Console.WriteLine("길 잃은 사람을 안내해주었다.");
                player.Gold += 1000;
                Console.WriteLine("1000 G를 획득했다.");
            }
            else if (roll <= 70)
            {
                Console.WriteLine("마을 주민과 인사를 나눴다. 선물을 받았다.");
                player.Gold += 500;
                Console.WriteLine("500 G를 획득했다!");
            }
            else
            {
                Console.WriteLine("아무 일도 일어나지 않았다.");
            }

            Console.WriteLine($"\n현재 골드 : {player.Gold} G | 스태미나 : {player.Stamina}");
            Console.ReadLine();
        }

        static void Training()
        {
            if (player.Stamina < 15)
            {
                Console.WriteLine("\n스태미나가 부족합니다!");
                Console.ReadLine();
                return;
            }

            player.Stamina -= 15;
            int roll = rand.Next(1, 101);

            if (roll <= 15)
            {
                Console.WriteLine("훈련이 잘 되었습니다!");
                player.Experience += 60;
                Console.WriteLine("획득경험치 60");
            }
            else if (roll <= 75)
            {
                Console.WriteLine("오늘하루 열심히 훈련했습니다.");
                player.Experience += 40;
                Console.WriteLine("획득경험치 40");
            }
            else if (roll <= 100)
            {
                Console.WriteLine("하기 싫다... 훈련이...");
                player.Experience += 30;
                Console.WriteLine("획득경험치 30");
            }

            Console.WriteLine($"\n현재 경험치 {player.Experience}exp");
            Console.ReadLine();
        }
    }
}



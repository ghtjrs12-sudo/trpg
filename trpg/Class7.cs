using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

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
            player = new Character("kont", "마법사", 10, 20, 5, 100, 10000, 0, 30);//디버깅을 위한 골드 증가

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
                else if (input == "6")
                {
                    Store();
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
            Console.WriteLine("6. 상점");
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

                Console.WriteLine("\n1.이름");
                Console.WriteLine("2.장착순");
                Console.WriteLine("3.공격력");
                Console.WriteLine("4.방어력");
                Console.WriteLine("5.장착 관리");
                Console.WriteLine("0.나가기");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    break;
                }
                else if (input == "1")
                {
                    SortInventory("이름");
                    Console.WriteLine("\n이름 길이 기준으로 정렬했습니다. (긴 이름 → 짧은 이름)");
                    Console.ReadLine();
                }
                else if (input == "2")
                {
                    SortInventory("장착");
                    Console.WriteLine("\n장착된 아이템이 위로 오도록 정렬했습니다.");
                    Console.ReadLine();
                }
                else if (input == "3")
                {
                    SortInventory("공격력");
                    Console.WriteLine("\n공격력이 높은 순으로 정렬했습니다.");
                    Console.ReadLine();
                }
                else if (input == "4")
                {
                    SortInventory("이름");
                    Console.WriteLine("\n방어력이 높은 순으로 정렬했습니다.");
                    Console.ReadLine();
                }
                else if (input == "5")
                {
                    ShowEquipManage();
                }
                else
                {
                    Console.WriteLine("\n잘못된 입력입니다.");
                    Console.ReadLine();
                }
            }
        }
        //인벤토리 정렬
        static void SortInventory(string mode)
        {
            IEnumerable<int> order = Enumerable.Empty<int>();

            switch (mode)
            {
                case "이름":
                    order = Enumerable.Range(0, itemNamesList.Count)
                                      .OrderByDescending(i => itemNamesList[i].Length);
                    break;

                case "장착":
                    order = Enumerable.Range(0, itemNamesList.Count)
                                      .OrderByDescending(i => itemEquippedList[i]);
                    break;

                case "공격력":
                    order = Enumerable.Range(0, itemNamesList.Count)
                                      .Where(i => itemTypesList[i] != 1)
                                      .OrderByDescending(i => itemStatsList[i])
                                      .Concat(Enumerable.Range(0, itemNamesList.Count)
                                                        .Where(i => itemTypesList[i] == 1));
                    break;

                case "방어력":
                    order = Enumerable.Range(0, itemNamesList.Count)
                                      .Where(i => itemTypesList[i] == 1)
                                      .OrderByDescending(i => itemStatsList[i])
                                      .Concat(Enumerable.Range(0, itemNamesList.Count)
                                                        .Where(i => itemTypesList[i] != 1));
                    break;
            }
            ApplySortOrder(order.ToList());
        }
        static void ApplySortOrder(List<int> order)
        {
            var newNames = new List<string>();
            var newTypes = new List<int>();
            var newStats = new List<int>();
            var newDescs = new List<string>();
            var newOwns = new List<bool>();
            var newEquips = new List<bool>();

            foreach (int i in order)
            {
                newNames.Add(itemNamesList[i]);
                newTypes.Add(itemTypesList[i]);
                newStats.Add(itemStatsList[i]);
                newDescs.Add(itemDescriptionsList[i]);
                newOwns.Add(itemOwndList[i]);
                newEquips.Add(itemEquippedList[i]);
            }

            itemNamesList = newNames;
            itemTypesList = newTypes;
            itemStatsList = newStats;
            itemDescriptionsList = newDescs;
            itemOwndList = newOwns;
            itemEquippedList = newEquips;
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

        //훈련하기
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

        //상점
        static void Store()
        {
            List<string> shopNames = new List<string>
    {
        "수련자 갑옷", "무쇠갑옷", "스파르타의 갑옷",
        "낡은 검", "청동 도끼", "스파르타의 창"
    };

            List<int> shopTypes = new List<int> { 1, 1, 1, 0, 0, 0 };
            List<int> shopStats = new List<int> { 5, 9, 15, 2, 5, 7 };
            List<string> shopDescriptions = new List<string>
    {
        "수련에 도움을 주는 갑옷입니다.",
        "무쇠로 만들어져 튼튼한 갑옷입니다.",
        "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.",
        "쉽게 볼 수 있는 낡은 검 입니다.",
        "어디선가 사용됐던거 같은 도끼입니다.",
        "스파르타의 전사들이 사용했다는 전설의 창입니다."
    };
            List<int> shopPrices = new List<int> { 1000, 1500, 3500, 600, 1500, 2500 };
            List<bool> shopPurchased = new List<bool> { false, false, false, false, false, false };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
                Console.WriteLine($"[보유 골드] {player.Gold} G\n");
                Console.WriteLine("[아이템 목록]");

                Console.WriteLine("──────────────────────────────────────────────────────────────");

                for (int i = 0; i < shopNames.Count; i++)
                {
                    string type = (shopTypes[i] == 1) ? "방어력" : "공격력";
                    string priceText = shopPurchased[i] ? "구매완료" : $"{shopPrices[i]} G";

                    string name = shopNames[i].PadRight(10);
                    string stat = $"{type} +{shopStats[i]}".PadRight(10);
                    string desc = shopDescriptions[i].PadRight(40);
                    string price = priceText.PadLeft(8);

                    Console.WriteLine($"- {i + 1}. {name} | {stat} | {desc} | {price}");
                }

                Console.WriteLine("──────────────────────────────────────────────────────────────");
                Console.WriteLine("\n1. 아이템 구매");
                Console.WriteLine("0. 나가기");
                Console.Write("\n원하시는 행동을 입력해주세요.\n>> ");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    break;
                }
                else if (input == "1")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("상점 - 아이템 구매");
                        Console.WriteLine("원하시는 아이템 번호를 입력해주세요. (0 입력 시 나가기)\n");

                        for (int i = 0; i < shopNames.Count; i++)
                        {
                            string type = (shopTypes[i] == 1) ? "방어력" : "공격력";
                            string priceText = shopPurchased[i] ? "구매완료" : $"{shopPrices[i]} G";
                            Console.WriteLine($"{i + 1}. {shopNames[i]} | {type} +{shopStats[i]} | {shopDescriptions[i]} | {priceText}");
                        }

                        Console.Write("\n>> ");
                        string buyInput = Console.ReadLine();

                        if (buyInput == "0")
                            break;

                        if (int.TryParse(buyInput, out int choice))
                        {
                            if (choice < 1 || choice > shopNames.Count)
                            {
                                Console.WriteLine("\n잘못된 입력입니다.");
                                Console.ReadLine();
                                continue;
                            }

                            int index = choice - 1;

                            if (shopPurchased[index])
                            {
                                Console.WriteLine("\n이미 구매한 아이템입니다.");
                            }
                            else if (player.Gold >= shopPrices[index])
                            {
                                player.Gold -= shopPrices[index];
                                shopPurchased[index] = true;

                                itemNamesList.Add(shopNames[index]);
                                itemTypesList.Add(shopTypes[index]);
                                itemStatsList.Add(shopStats[index]);
                                itemDescriptionsList.Add(shopDescriptions[index]);
                                itemOwndList.Add(true);
                                itemEquippedList.Add(false);

                                Console.WriteLine($"\n{shopNames[index]} 구매를 완료했습니다!");
                            }
                            else
                            {
                                Console.WriteLine("\n골드가 부족합니다!");
                            }

                            Console.WriteLine($"\n현재 골드: {player.Gold} G");
                            Console.WriteLine("계속 구매하려면 Enter, 나가려면 0을 입력하세요.");
                            string next = Console.ReadLine();
                            if (next == "0") break;
                        }
                        else
                        {
                            Console.WriteLine("\n잘못된 입력입니다.");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}



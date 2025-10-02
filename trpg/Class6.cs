//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.Generic;

//namespace trpg
//{
//    class Player
//    {
//        public string name;
//        public int hp;
//        public Player(string name, int hp)
//        {
//            this.name = name;
//            this.hp = hp;
//        }

//        public void Attack()
//        {
//            Console.WriteLine($"{name}이(가) 공격합니다!");
//        }

//        public void TakeDamage(int damage)
//        {
//            hp -= damage;
//            Console.WriteLine($"{name}이(가) {damage} 데미지를 입음. 남은 HP: {hp}");
//        }
//    }

//    class Monster
//    {
//        public string name;
//        public int level;
//        public int hp;

//    public Monster(string name, int level)
//        {
//            this.name = name;
//            this.level = level;
//            this.hp = level * 50;
//        }
//    public void DisplayInfo()
//        {
//            Console.WriteLine($"이름: {name}, 레벨: {level}, HP: {hp}");
//        }
//    }

//    class Item
//    {
//        public string name;
//        public int price;
//        public Item(string name, int price)
//        {
//            this .name = name;
//            this.price = price;
//        }
//        public void DisplayInfo()
//        {
//            Console.WriteLine($"아이템: {name}, 가격: {price}G");
//        }
//    }

//    class Skill
//    {
//        public string name;
//        public int damage;
//        public int mpCost;

//        public Skill(string name, int damage, int mpCost)
//        {
//            this .name = name;
//            this.damage = damage;
//            this.mpCost = mpCost;
//        }
//        public void Activate()
//        {
//            Console.WriteLine($"스킬 {name} 발동! 데미지: {damage}, MP 소모: {mpCost}");
//        }
//    }

//    class Shop
//    {
//        public List<Item> items;

//        public Shop()
//        {
//            items = new List<Item>();
//        }
//        public void AddItem(Item item)
//        {
//            items.Add(item);
//            Console.WriteLine($"상점에 {item.name} 아이템 추가됨");
//        }
//        public void DisplayItems()
//        {
//            Console.WriteLine("\n--- 상점 목록 ---");
//            foreach (Item item in items)
//            {
//                item.DisplayInfo();
//            }
//        }
//    }

//    internal class Class6
//    {
//        static void Main(string[] args)
//        {
//            Player player1 = new Player("전사", 100);

//            player1.Attack();
//            player1.TakeDamage(30);

//            Console.WriteLine();

//            Monster slime = new Monster("슬라임", 1);
//            Monster goblin = new Monster("고블린", 3);

//            slime.DisplayInfo();
//            goblin.DisplayInfo();

//            goblin.hp = 10;
//            goblin.DisplayInfo();

//            Console.WriteLine();

//            Item potion = (new Item("HP포션", 50));
//            Item sword = (new Item("철검", 150));

//            potion.DisplayInfo();

//            sword.DisplayInfo();
//            sword.price = 200;
//            sword.DisplayInfo();

//            Console.WriteLine();

//            Skill fireball = (new Skill("파이어볼", 50, 20));
//            Skill heal = (new Skill("힐", -30, 15));

//            fireball.Activate();
//            heal.Activate();
//            fireball.damage = 60;
//            fireball.Activate();

//            Shop shop = new Shop();

//            shop.AddItem(new Item("HP포션", 50));
//            shop.AddItem(new Item("MP포션", 70));
//            shop.AddItem(new Item("철검", 150));
//            shop.DisplayItems();
//            shop.items[0].price = 60;
//            shop.DisplayItems();

//            Console.WriteLine();
//        }
//    }
//}

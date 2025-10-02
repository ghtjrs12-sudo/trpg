//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace trpg
//{
//    internal class Class2
//    {

//        //Basic
//        //1
//        static void sayHello()
//        {
//            Console.WriteLine("sayHello");
//        }

//        //2
//        static void StartGame()
//        {
//            Console.WriteLine("StartGame");
//        }

//        //3
//        static void PrintLine()
//        {
//            Console.WriteLine("============");
//        }

//        //4
//        static void DisplayMenu()
//        {
//            Console.WriteLine("1.상태 보기 2.인벤토리 3.상점");
//        }

//        //5
//        static void GreetPerson(string name)
//        {
//            Console.WriteLine($"안녕하세요, {name}");
//        }

//        //6
//        static void PrintLevel(int level)
//        {
//            Console.WriteLine($"당신의 레벨은 {level}입니다.");
//        }

//        //7
//        static void PrintHp(int hp)
//        {
//            Console.WriteLine($"현재 HP:{hp}");
//        }

//        //8
//        static void MonsterAttack(string monsterName)
//        {
//            Console.WriteLine($"{monsterName}이(가) 공격합니다!");
//        }

//        //9
//        static void TakeDamage(int damage)
//        {
//            Console.WriteLine($"플레이어는 {damage}의 데미지를 입었습니다.");
//        }

//        //10
//        static void PrintItemPrice(string itemName, int price)
//        {
//            Console.WriteLine($"{itemName}의 가격은 {price}골드입니다.");
//        }

//        //11
//        static int Add(int a, int b)
//        {
//            return a + b;
//        }

//        //12
//        static int Subtract(int a, int b)
//        {
//            return a - b;
//        }

//        //13
//        static int Multiply(int a, int b)
//        {
//            return a * b;
//        }

//        //14
//        static float Divide(float a, float b)
//        {
//            return a / b;
//        }

//        //15
//        static string GetWelcomeMessage(string name)
//        {
//            return $"환영합니다. {name}님";
//        }

//        //Standard
//        //5
//        static string GetFullName(string firstName, string lastName)
//        {
//            return firstName + " " + lastName;
//        }

//        //6
//        static float GetAverage(int a, int b)
//        {
//            return (a + b) / 2.0f;
//        }

//        //7
//        static int CalculateRemainingHp(int hp, int damage)
//        {
//            return hp - damage;
//        }

//        //8
//        static bool IsEven(int number)
//        {
//            return number % 2 == 0;
//        }

//        //9
//        static bool IsAdult(int age)
//        {
//            return age >= 19;
//        }

//        //10
//        static bool IsAlive(int hp)
//        {
//            return hp > 0;
//        }

//        static void CheckHp(int hp)
//        {
//            if (IsAlive(hp))
//            {
//                Console.WriteLine("생존");
//            }
//            else
//            {
//                Console.WriteLine("사망");
//            }
//        }


//        static void Main(string[] args)
//        {
//            //1
//            sayHello();

//            //2
//            StartGame();

//            //3
//            PrintLine();
//            PrintLine();
//            PrintLine();

//            //4
//            DisplayMenu();

//            //5
//            GreetPerson("chad");

//            //6
//            PrintLevel(5);

//            //7
//            PrintHp(80);

//            //8
//            MonsterAttack("고블린");

//            //9
//            TakeDamage(10);

//            //10
//            PrintItemPrice("빨간포션", 50);

//            //11
//            int result = Add(10, 20);
//            Console.WriteLine(result);

//            //12
//            int remainingHp = Subtract(100, 30);
//            Console.WriteLine(remainingHp);

//            //13
//            int totalDamage = Multiply(5, 10);
//            Console.WriteLine(totalDamage);

//            //14
//            float result1 = Divide(10.0f, 4.0f);
//            Console.WriteLine(result1);

//            //15
//            string message = GetWelcomeMessage("스파르타");
//            Console.WriteLine(message);

//            //Standard
//            //1
//            Console.WriteLine(Add(1, 2));
//            Console.WriteLine(Add(5, 5));
//            Console.WriteLine(Add(100, 200));

//            //2
//            PrintItemPrice("철검", 1000);
//            PrintItemPrice("가죽갑옷", 500);

//            //3
//            int result2 = Add(10, 20);
//            int result3 = Add(result2, 50);
//            Console.WriteLine(result3);

//            //4
//            int damage = Multiply(10, 5);
//            TakeDamage(damage);

//            //5
//            string fullName = GetFullName("John", "Doe");
//            Console.WriteLine(fullName);

//            //6
//            Console.WriteLine(GetAverage(10, 20));
//            Console.WriteLine(GetAverage(5, 10));

//            //7
//            int currentHp = 100;
//            currentHp = CalculateRemainingHp(currentHp, 30);
//            Console.WriteLine(currentHp);

//            //8
//            Console.WriteLine(IsEven(10));
//            Console.WriteLine(IsEven(7));

//            //9
//            bool isAdult1 = IsAdult(20);
//            bool isAdult2 = IsAdult(15);
//            Console.WriteLine(isAdult1);
//            Console.WriteLine(isAdult2);

//            //10
//            CheckHp(50);
//            CheckHp(0);
//        }

//    }

//}
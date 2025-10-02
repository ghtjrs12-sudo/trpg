//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace trpg
//{
//    internal class Class4
//    {
//        static void Main(string[] args)
//        {
//            //Basic
//            //1
//            string a = "스파르타";
//            string b = "마을";
//            string result = a + " " + b;
//            Console.WriteLine(result);

//            //2
//            Console.WriteLine("1.상태 보기\n2.인벤토리");

//            //3
//            Console.WriteLine("이름:\tChad");

//            //4
//            string message = "상점 주인이 \"어서오게!\"라고 말했다.";
//            Console.WriteLine(message);

//            //5
//            string intro = @"
//            스파르타 마을에 오신 것을 환영합니다.
//            이곳에서 던전으로 들어가기 전
//            활동을 할 수 있습니다.";
//            Console.WriteLine(intro);

//            //6
//            string name = "전사";
//            int level = 10;
//            string playerInfo = string.Format("이름: {0}, 레벨: {1}", name, level);
//            Console.WriteLine(playerInfo);

//            //7
//            string playerInfo1 = $"이름: {name}, 레벨: {level}";
//            Console.WriteLine(playerInfo1);

//            //8
//            string monster = "슬라임";
//            int damage = 5;
//            string log = $"{monster}에게 {damage}의 데미지를 입혔다!";
//            Console.WriteLine(log);

//            //9
//            int atk = 10;
//            int extraAtk = 3;
//            string statInfo = $"총 공격력: {atk + extraAtk}";
//            Console.WriteLine(statInfo);

//            //standard
//            //1
//            string command = "shop";
//            if (command == "shop")
//            {
//                Console.WriteLine("상점으로 이동합니다.");
//            }

//            //2
//            string name1 = "Chad";
//            int length = name1.Length;
//            Console.WriteLine(length);

//            //3
//            Console.Write("이름을 입력하세요: ");
//            string name2 = Console.ReadLine();
//            if (name2.Length > 10)
//            {
//                Console.WriteLine("이름은 10자를 초과할 수 없습니다.");
//            }

//            //4
//            string command1 = "SHOP";
//            if (command1.ToLower() == "shop")
//            {
//                Console.WriteLine("상점");
//            }

//            //5
//            string command2 = "exit";
//            string upperCommand = command2.ToUpper();
//            Console.WriteLine(upperCommand);

//            //6
//            string input = " shop ";
//            if (input.Trim() == "shop")
//            {
//                Console.WriteLine("상점");
//            }

//            //7
//            string command3 = " Shop ";
//            if (command.Trim().ToLower() == "shop")
//            {
//                Console.WriteLine("상점");
//            }

//            //Challenge
//            //1
//            string input2 = "1";
//            int choice = int.Parse(input2);
//            Console.WriteLine(choice + 1);

//            //2
//            //string input3 = "abc";
//            //int gt = int.Parse(input3);//System.FormatException: 'The input string 'abc' was not in a correct format.'
//            //Console.WriteLine(gt);// abc는 정수가 아니여서 사용불가

//            //3
//            //string input4 = "abc";
//            //if(int.TryParse)

//            //4
//            //string input5 = "3";
//            //if(int.TryParse) //시도

//            //5
//            string message1 = "You found a potion!";
//            if(message1.Contains("potion"))
//            {
//                Console.WriteLine("포션을 발견했다!");
//            }

//            //6
//            string description = "매우 [낡은] 검입니다.";
//            string newDescription = description.Replace("[낡은]", "강화된");
//            Console.WriteLine(newDescription);

//        }
//    }
//}

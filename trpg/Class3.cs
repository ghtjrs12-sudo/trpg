//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Numerics;
//using System.Text;
//using System.Threading.Tasks;

//namespace trpg
//{
//    internal class Class3
//    {
//        //2
//        static void PrintLine()
//        {
//            Console.WriteLine("==============");
//        }

//        //6
//        static void GreetRepeat(int count)
//        {
//            for (int i = 0; i < count; i++)
//            {
//                Console.WriteLine("안녕하세요");
//            }
//        }
//        static void Main(string[] args)
//        {
//            //1
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(i);
//            }

//            //2
//            for (int i = 0; i < 5; i++)
//            {
//                PrintLine();
//            }

//            //3
//            for (int i = 10; i >= 1; i--)
//            {
//                Console.WriteLine(i);
//            }

//            //4
//            for (int i = 0; i <= 10; i+= 2)
//            {
//                Console.WriteLine(i);
//            }

//            //5
//            int sum = 0;

//            for (int i = 1; i <= 10; ++i)
//            {
//                sum += i;
//            }
//            Console.WriteLine($"합계: {sum}");

//            //6
//            GreetRepeat(3);

//            //7
//            for (int i = 1; i <=20; ++i)
//            {
//                if(i % 3 ==0)
//                {
//                    Console.WriteLine(i);
//                }
//            }

//            //8
//            int i1 = 1; //e로 변경

//            while (i1 <= 10)
//            {
//                Console.WriteLine(i1);
//                i1++;
//            }

//            //9
//            int i2 = 10;

//            while (i2 >= 1)
//            {
//                Console.WriteLine(i2);
//                i2--;
//            }

//            //10
//            int sum1 = 1;
//            int i3 = 1;

//            while(i3 <= 10)
//            {
//                sum1 += i3;
//                i3++;
//            }
//            Console.WriteLine($"합계: {sum1}");

//            //11
//            int i4 = 1;

//            while(i4 <= 20)
//            {
//                if(i4 % 2 == 0)
//                {
//                    Console.WriteLine(i4);
//                }
//                i4++;
//            }

//            //12
//            string password = "1234";
//            string input = "";

//            while (input != password)
//            {
//                Console.Write("비밀번호를 입력하세요:");
//                input = Console.ReadLine();
//            }
//            Console.WriteLine("로그인 성공!");

//            //13
//            while(true)
//            {
//                Console.WriteLine("숫자를 입력하세요 (0 = 종료): ");
//                int number = int.Parse(Console.ReadLine());

//                if(number == 0)
//                {
//                    Console.WriteLine("종료합니다.");
//                    break;
//                }
//                if(number % 2 == 0)
//                {
//                    Console.WriteLine("짝수");
//                }
//                else
//                {
//                    Console.WriteLine("홀수");
//                }    
//            }

//            //14
//            for(int i = 1; i <= 100; i++)
//            {
//                if(i == 5)
//                {
//                    break;
//                }
//                Console.WriteLine(i);
//            }

//            //15
//            for (int i = 1; i <= 10; i++)
//            {
//                if(i % 2 != 0)
//                {
//                    continue;
//                }
//                Console.WriteLine(i);
//            }

//            //16
//            int i5 = 1;

//            while(true)
//            {
//                Console.WriteLine(i5);
//                i5++;
//                if(i5 > 5)
//                {
//                    break;
//                }
//            }

//            //17
//            while(true)
//            {
//                Console.Write("명령어 입력 ('exit' 입력 시 종료): ");
//                string input1 = Console.ReadLine();
                
//                if(input1 == "exit")
//                {
//                    break;
//                }
//            }

//            //18
//            int i6 = 0;

//            while (i6 < 20)
//            {
//                i6++;

//                if(i6 % 3 != 0)
//                {
//                    continue;
//                }
//                Console.WriteLine(i6);
//            }

//            //19
//            for(int i = 1; i <= 100; ++i)
//            {
//                if(i % 7 ==0)
//                {
//                    Console.WriteLine(i);
//                    break;
//                }
//            }

//            //20
//            while (true)
//            {
//                Console.Write("비밀번호 (1234): ");
//                string input3 = Console.ReadLine();
//                if (input3 == "1234")
//                {
//                    Console.WriteLine("로그인 성공!");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("비밀번호 오류!");
//                }
//            }

//            //standard
//            //21
//            bool isGameRunning = true;

//            while(isGameRunning)
//            {
//                Console.WriteLine("1.공격 2.방어 0.종료");
//                Console.Write("입력: ");
//                string choice = Console.ReadLine();

//                switch(choice)
//                {
//                    case "1":
//                        Console.WriteLine("공격!");
//                        break;
//                    case "2":
//                        Console.WriteLine("방어!");
//                        break;
//                    case "0":
//                        isGameRunning = false;
//                        break;
//                    default:
//                        Console.WriteLine("잘못된 입력");
//                        break;   
//                }
//            }

//            //22
//            string id = "myid";
//            string pw = "1234";

//            while (true)
//            {
//                Console.Write("아이디: ");
//                string inputId = Console.ReadLine();
//                Console.Write("비밀번호: ");
//                string inputPw = Console.ReadLine();

//                if (inputId == id && inputPw == pw)
//                {
//                    Console.WriteLine("로그인 성공!");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("아이디/비밀번호 오류. 재시도.");
//                }
//            }

//            //23
//            int sum2 = 0;
//            while (true)
//            {
//                Console.Write("더할 숫자 입력(0=종료): ");
//                int.TryParse(Console.ReadLine(), out int num);

//                if(num == 0)
//                {
//                    break;
//                }
//                if(num < 0)
//                {
//                    Console.WriteLine("음수는 계산하지 않습니다.");
//                    continue;
//                }
//            }

//            //24
//            int total = 0;

//            for(int i = 1; i <= 100; i++)
//            {
//                if (i % 3 == 0 || i % 5 == 0)
//                    total += i;
//            }
//            Console.WriteLine($"3 또는 5의 배수 합: {total}");

//            //25
//            for(int i = 1; i <= 3; i++)  //바깥 > 안쪽
//            {
//                for(int j = 1; j <= 2; j++)
//                {
//                    Console.WriteLine($"i: {i}, j: {j}");
//                }
//            }

//            //26
//            for(int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j < 5; j++)
//                {
//                    Console.Write("*");
//                }
//                Console.WriteLine();
//            }

//            //27
//            for(int i = 1; i <= 9; i++)
//            {
//                Console.WriteLine($"2 * {i} = {2 * i}");
//            }

//            //28
//            for(int j = 2; j <= 9; j++)
//            {
//                for(int i = 1; i <= 9; i++)
//                {
//                    Console.WriteLine($"{j} * {i} = {j * i}");
//                }
//                Console.WriteLine();
//            }

//            //29
//            int sum3 = 0;

//            for (int i = 1; ; i++)
//            {
//                sum3 += i;
//                if(sum3 > 2000)
//                {
//                    Console.WriteLine($"합: {sum3}, 마지막 i={i}");
//                    break;
//                }
//            }

//            //30
//            int i7 = 1;
//            do
//            {
//                Console.WriteLine(i7);
//                i7++;
//            }
//            while (i7 <= 5);

//        }
//    } 

   
//}

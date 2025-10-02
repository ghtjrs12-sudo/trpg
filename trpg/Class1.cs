//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace trpg
//{
//    internal class Class1
//    {
//        static void Main(string[] args)
//        {
//            //Basic

//            //산술-
//            int playerGold = 1000;
//            int itemPrice = 300;
//            int remainingGold = playerGold - itemPrice;
//            Console.WriteLine(remainingGold);

//            //산술*
//            int damage = 30;
//            int totalDamage = damage * 3;
//            Console.WriteLine(totalDamage);

//            //산술/
//            int totalScore = 100;
//            int subjectCount = 3;
//            float aaverageScore = (float)totalScore / subjectCount;
//            Console.WriteLine(aaverageScore);

//            //산술%
//            int number = 10;
//            int remainder = number % 3;
//            Console.WriteLine(remainder);

//            //관계>
//            int playerLevel = 10;
//            int monsterLevel = 5;
//            bool isPlayerStronger = playerLevel > monsterLevel;
//            Console.WriteLine(isPlayerStronger);

//            //관계 ==
//            string playerName = "Chad";
//            bool isGM = playerName == "GM";
//            Console.WriteLine(isGM);

//            //논리 &&
//            bool hasKey = true;
//            bool canEnterDungeon = (playerLevel >= 10) && hasKey;
//            Console.WriteLine(canEnterDungeon);

//            //논리 ||
//            bool hasSword = false;
//            bool hasMagic = true;
//            bool canAttack = hasSword || hasMagic;
//            Console.WriteLine(canAttack);

//            //복합 +=
//            int score = 100;
//            score += 50;
//            Console.WriteLine(score);

//            //증감 ++
//            int potionCount = 5;
//            potionCount++;
//            Console.WriteLine(potionCount);

//            //연산자 우선순위
//            int result = 10 + 5 * 2;
//            Console.WriteLine(result);

//            //if
//            int playerGold2 = 500; //위에 선언해서 2로 바꿈
//            int itemPrice2 = 400; //위에 선언해서 2로 바꿈
//            if (playerGold2 >= itemPrice2)
//            { 
//             Console.WriteLine("구매가능!");
//            }

//            //if-else
//            int playerHp = 0;
//            if (playerHp > 0)
//            {
//                Console.WriteLine("생존");
//            }
//            else
//            {
//                Console.WriteLine("사망");
//            }

//            // if-else 와 %
//            int number2 = 10; //위에 선언해서 2로 바꿈
//            if (number % 2 == 0)
//            {
//                Console.WriteLine("짝수입니다.");
//            }
//            else
//            { 
//                Console.WriteLine("홀수입니다.");
//            }

//            // if-else if
//            Console.WriteLine("점수를 입력하세요(0-100)");
//            int score2 = int.Parse(Console.ReadLine()); //위에 선언해서 2로바꿈
//            if(score2 >= 90)
//            {
//                Console.WriteLine("A등급");
//            }
//            else if(score2 >=80)
//            {
//                Console.WriteLine("B등급");
//            }
//            else if(score2 >= 70)
//            {
//                Console.WriteLine("C등급");
//            }

//            //로그인 예제
//            string id = "myid";
//            string password = "mypassword";
//            Console.Write("아이디:");
//            string inputId = Console.ReadLine();
//            Console.Write("비밀번호:");
//            string inputPassword = Console.ReadLine();
//            if (inputId == id && inputPassword == password)
//            {
//                Console.WriteLine("로그인 성공");
//            }
//            else
//            {
//                Console.WriteLine("로그인 실패");
//            }

//            //논리 응용 ||
//            int playerLevel2 = 5; //위에 선언해서 2로 바꿈
//            bool isVIP = true;
//            if(playerLevel2 >= 10 || isVIP)
//            {
//                Console.WriteLine("특수 상점에 입장할 수 있습니다.");
//            }

//            //논리 응용 &&
//            int attack = 100;
//            int accuracy = 95;
//            if (attack >=100 && accuracy >= 95)
//            {
//                Console.WriteLine("특수 스킬 '명중'을 사용할 수 있습니다.");
//            }

//            //switch 기본
//            Console.WriteLine("1: 전사, 2:마법사, 3:궁수");
//            Console.Write("직업을 선택하세요:");
//            string jobChoice = Console.ReadLine();
//            switch(jobChoice)
//            {
//                case "1":
//                    Console.WriteLine("전사 선택");
//                    break;
//                case "2":
//                    Console.WriteLine("마법사 선택");
//                    break;
//                case "3":
//                    Console.WriteLine("궁수 선택");
//                    break;
//                default:
//                    Console.WriteLine("잘못된 입력");
//                    break;
//            }

//            //switch - int
//            int monsterType = 1; //1.슬라임 2. 고블린 3. 오크
//            switch (monsterType)
//            {
//                case 1:
//                    Console.WriteLine("슬라임 등장!");
//                    break;
//                case 2:
//                    Console.WriteLine("고블린 등장!");
//                    break;
//                case 3:
//                    Console.WriteLine("오크 등장!");
//                    break;
//                default:
//                    Console.WriteLine("알 수 없는 몬스터");
//                    break;
//            }

//            //Standard

//            //삼항 연산자1
//            int playerHp2 = 100; ;
//            string status = playerHp2 > 0 ? "생존" : "사망";//위에선언
//            Console.WriteLine(status);

//            //삼항 연산자3
//            int number3 = 11; //위에선언
//            string result2 = number % 2 == 0 ? "짝수" : "홀수";//위에선언
//            Console.WriteLine(result2);

//            //중첩 if + 중접 if 응용
//            string itemType = "Weapin";
//            int itemLevel = 5;

//            if(itemType == "Weapon")
//            {
//                if(itemLevel >= 5)
//                    Console.WriteLine("강화된 무기");
//                else
//                    Console.WriteLine("일반 무기");
                
//            }
//            else if (itemType == "Armor")
//            {
//                if (itemLevel >= 5)
//                    Console.WriteLine("강화된 방어구");
//                else
//                    Console.WriteLine("일반 방어구");
//            }

//            //5. 중접 if 응용
//            int playerLevel3 = 10; //위
//            bool isQustCompleted = true;

//            if(playerLevel >= 10)
//            {
//                if (isQustCompleted)
//                    Console.WriteLine("보상을 지급합니다!");
//                else
//                    Console.WriteLine("퀘스트를 완료하세요.");
//            }
//            else
//            {
//                Console.WriteLine("레벨이 부족합니다.");
//            }

//            // 복합 논리 1
//            Console.Write("레벨을 입력하세요:");
//            int level = int.Parse(Console.ReadLine());
//            Console.Write("직업을 입력하세요(전사/마법사):");
//            string job = Console.ReadLine();
//            if ((job == "전사" && level >= 10) || (job == "마법사" && level >= 12))
//            {
//                Console.WriteLine("특수 던전 입장이 가능합니다.");
//            }

//            // 복합 논리 2
//            bool hasRedKey = true;
//            bool hasBlueKey = false;
//            int playerLevel4 = 15; //위

//            if (hasRedKey && hasBlueKey || playerLevel4 >= 20)
//            {
//                Console.WriteLine("보스 방에 입장할 수 있습니다.");
//            }

//            // 전위 증감 응용
//            int x = 3;
//            int y = 2 + ++x; //++x가 먼저 실행 x = 4 y = 6 
//            Console.WriteLine("x = " + x); // 4
//            Console.WriteLine("y = " + y); // 6
//            // 전위 증강 ++x 면 +1를 x에 먼저 한다음 계산

//            //중접 if - 로그인
//            string id2 = "myid";
//            string password2 = "mypassword";

//            Console.Write("아이디:");
//            string inputId2 = Console.ReadLine();

//            Console.Write("비밀번호:");
//            string inputPassword2 = Console.ReadLine();

//            if(inputId2 == id2)
//            {
//                if(inputPassword2 == password2)
//                Console.WriteLine("로그인 성공");
//                else 
//                Console.WriteLine("비밀번호 오류");
//            }
//            else
//            {
//                Console.WriteLine("아이디 존재하지 않음");
//            }


//            //Challenge

//            //비트&
//            int a = 12; //2진수 0b1100
//            int b = 10; //2진수 0b1010
//            int result3 = a & b; // 8 (0b1000)
//            Console.WriteLine("AND:" + result3);

//            //비트 |
//            int result4 = a | b; // 14 (0b1110)
//            Console.WriteLine("OR:" + result4);

//            //비트 ^
//            int result5 = a ^ b; // 6 (0b0110)
//            Console.WriteLine("XOR:" + result5);

//            //비트 <<
//            int c = 11; //2진수 0b1011
//            int result6 = c << 2; // 44 (0b101100)
//            Console.WriteLine("left shift:" + result6);

//            //비트 >>
//            int result7 = c >> 1; // 5(0b0101)
//            Console.WriteLine("right shift:" + result7);

//            //비트 - 특정 비트 확인
//            int d = 12; //0b1100
//            bool isThirdBitOn = ((d >> 2) & 1) == 1; // 3번째 비트 검사
//            Console.WriteLine(" 3번째 비트 " + isThirdBitOn);

//            //비트 - 플래그 추가 |
//            int playerStatus = 0; //0b0000
//            playerStatus |= 0b0100;
//            Console.WriteLine("독 상태 추가: " + playerStatus); //4

//            //비트 - 플래그 토글 ^
//            int playerStatus2 = 5; //0b0101 독 은신
//            playerStatus2 ^= 0b0001; //은신
//            Console.WriteLine("은신:" + playerStatus2); //4

//            //비트 - 플래그 검사 &
//            int playerStatus3 = 5; //0b0101
//            if((playerStatus3 & 0b0100) != 0)
//            {
//                Console.WriteLine("플레이어가 독상태 입니다.");
//            }

//            //비트 - 플래그 제거 ~&
//            int playerStatus4 = 7; //0b0111 독 화상 은신
//            playerStatus &= ~0b1000; // 독 제거
//            Console.WriteLine("독 제거 후:" + playerStatus4); //3


//        }


//    }
//}

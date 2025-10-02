//using System.Xml.Linq;

//namespace trpg
//{
    //internal class Program
    //{
   
        //static void Main(string[] args)
        //{
            ////Basic
            //int playerHp = 100;
            //string playerName = "내 이름";
            //bool isPlaterAlive = true;
            //float moveSpeed = 3.5f;
            //long wordlPopulation = 7000000000L;
            //byte potionCount = 20;
            //double pi = 3.1415926535;
            //string monsterName = "슬라임";
            //Console.WriteLine(monsterName);
            //int Gold = 500;
            //Console.WriteLine(Gold);
            //string camelCase = "낡은 검";

            ////생각하는 문제
            //byte playerLevel = 1; //int = 4byte

            ////단위가 넘어가서 byte = 255 int사용

            //// 단위가 넘어가서 int = 21억 long 사용

            ////int는 정수만 사용가능 float 소수점 사용가능

            ////bool은 true, fals만 값이 나와서 보기쉬움v


            ////standard
            //byte level = 50;
            //int levelInt = level; //암시적 형변환 (작은타입에서 큰타입으로)
            //Console.WriteLine(levelInt);

            //int gold = 200000;
            //long goldLong = gold; //암시적 형변환 (작은타입에서 큰타입으로)
            //Console.WriteLine(goldLong);

            //int hp = 10;
            //float hpFloat = hp; //암시적 형변환 (작은타입에서 큰타입으로)
            //Console.WriteLine(hpFloat);

            //float speed = 5.25f;
            //double speedDouble = speed;
            //Console.WriteLine(speedDouble);

            //int itemCount = 150;
            ////byte countByte = (byte)itemCount;
            ////Console.WriteLine(countByte);

            //var myLevel = 10;

            //var myJob = "전사";

            //var isPlayerTurn = true;

            ////생각하는 문제 

            //int overflowValue = 300;
            //byte overflowByte = (byte)overflowValue;
            //Console.WriteLine(overflowByte); // 44  300-256 = 44 0부터 샘

            //long hugeGold = 30000000L;
            //int goldInt = (int)hugeGold;
            //Console.WriteLine(goldInt); // int 범위 -21억 ~ 21억 오버플로우?
            ////초과한 비트가 잘려서 2의 보수 표현 방식에 따라 음수 값으로 변환됨. 무슨말임

            //int 1stPlayerLevel; // 숫자로 먼저 시작하면 오류
            //string player Name; //공백 사용불가
            //bool IsMonsterDead; //카멜케이스 사용 권장v
            //int long; //예약어 사용불가


        //}
    //}
//}

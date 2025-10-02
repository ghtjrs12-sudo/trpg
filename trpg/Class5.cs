//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace trpg
//{
//    internal class Class5
//    {

//        static void Main(string[] args)
//        {
//            //1 
//            int[] scores = new int[5];
//            scores[0] = 100;
//            scores[2] = 80;
//            Console.WriteLine(scores[0] + scores[2]);

//            if (scores[0] == 100)
//            {
//                Console.WriteLine("만접입니다.");
//            }

//            //2
//            string[] items = { "철검", "가죽갑옷", "HP포션" };
//            string item = items[2];
//            Console.WriteLine(item);
//            int count = items.Length;
//            Console.WriteLine(count);

//            for (int i = 0; i < items.Length; i++)
//            {
//                Console.WriteLine(items[i]);
//            }

//            //3
//            string[] monsterNames = new string[3];
//            monsterNames[0] = "슬라임";
//            monsterNames[1] = "주황버섯";
//            monsterNames[2] = "달팽이";

//            for (int i = 0; i < monsterNames.Length; i++)
//            {
//                Console.WriteLine($"{i}번 몬스터: {monsterNames[i]}");
//            }

//            for (int i = 0; i < monsterNames.Length; i++)
//            {
//                Console.WriteLine($"{monsterNames[i]}의 이름 길이: {monsterNames[i].Length}");
//            }

//            foreach (string name in monsterNames)
//            {
//                Console.WriteLine(name);
//            }

//            //4
//            int[] data = { 5, 12, 3, 8, 10 };

//            for (int i = 0; i < data.Length; i++)//큰숫자만
//            {
//                if (data[i] > 10)
//                    Console.WriteLine(data[i]);
//            }

//            for (int i = 0; i < data.Length; i++)//짝수만
//            {
//                if (data[i] % 2 == 0)
//                    Console.WriteLine(data[i]);
//            }

//            int sum = 0;
//            for (int i = 0; i < data.Length; i++)//총합
//            {
//                sum += data[i];
//            }
//            Console.WriteLine($"총 합: {sum}");

//            foreach (int num in data)//5보다 큰수
//            {
//                if (num > 5)
//                    Console.WriteLine(num);
//            }

//            //5
//            List<string> inventory = new List<string>(); //빈 리스트 생성

//            inventory.Add("검"); //리스트에 데이터 추가
//            inventory.Add("방패");
//            inventory.Add("포션");

//            int invCount = inventory.Count; //Length x  Count o
//            Console.WriteLine(invCount);

//            string firstItem = inventory[0];
//            Console.WriteLine(firstItem);

//            inventory[1] = "강철 방패";

//            inventory.Remove("포션"); //리스트에서 데이터 삭제

//            inventory.RemoveAt(0);

//            Console.WriteLine(inventory.Count);

//            bool hasShield = inventory.Contains("강철 방패");
//            Console.WriteLine(hasShield);

//            bool hasSword = inventory.Contains("검");
//            Console.WriteLine(hasSword);

//            inventory.Clear(); //내용 삭제? 지우기?
//            Console.WriteLine(inventory.Count);

//            inventory.Add("단검");
//            inventory.Add("가죽 방패");
//            inventory.Add("회복 포션");

//            PrintInventory(inventory);
//        }

//        static void PrintInventory(List<string> inv)
//        {
//            foreach (string item in inv) //리스트 데이터 출력
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}

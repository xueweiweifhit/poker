using Net5Demo.CSharpEight;
using System;
using System.Collections.Generic;

namespace Net5Demo
{
    public class Program
    {
        public static List<List<string>> InitGame = new List<List<string>>();
        public static List<string> AllItem = new List<string>();
        public static List<Player> PlayerList = new List<Player>();
        static void Main(string[] args)
        {
            
            //初始化游戏数据
            initGame();
            PokerGame pg = new PokerGame(InitGame);
            int i = 0;            
            var flag = true;
            while (flag) {
                if (PlayerList[i].PickPoker(InitGame, AllItem))
                {
                    PlayerList[i].PrintResult(InitGame);
                }
                else {
                    //flag = false;
                    Console.WriteLine("胜负已分，继续吗？退出请按 Ctrl + C。");
                    Reset();
                }
                if (i == 1)
                {
                    i = 0;
                }
                else {
                    i = 1;
                }
            }            
        }
        /// <summary>
        /// 初始化游戏数据
        /// </summary>
        public static void initGame() {
            InitGame.Add(new List<string> { "A", "2", "3" });
            InitGame.Add(new List<string> { "4", "5", "6", "7", "8" });
            InitGame.Add(new List<string> { "9", "10", "J", "Q", "K", "X", "Y" });
            AllItem = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "X", "Y" };
            PlayerList.Add(new Player { Name = "玩家A", Age = 16 });
            PlayerList.Add(new Player { Name = "玩家B", Age = 18 });
            Console.WriteLine("欢迎参加Poker游戏数字");
            Console.WriteLine("---------------------");
            Console.WriteLine("说明:\n 游戏人数 X 2");
            Console.WriteLine("游戏一方先选择任意一行，拿掉任意数量的纸牌（不允许跨行选择）,双方轮流拿取。");
            Console.WriteLine("拿到最后一张牌的一方失败。");
        }
        /// <summary>
        /// 重置游戏数据,玩家不变
        /// </summary>
        /// <param name="InitGame"></param>
        /// <param name="AllItem"></param>
        /// <returns></returns>
        public static void Reset()
        {
            InitGame.Clear();
            AllItem.Clear();
            InitGame.Add(new List<string> { "A", "2", "3" });
            InitGame.Add(new List<string> { "4", "5", "6", "7", "8" });
            InitGame.Add(new List<string> { "9", "10", "J", "Q", "K", "X", "Y" });
            AllItem = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "X", "Y" };
            //Console.WriteLine("欢迎参加Poker游戏数字");
            //Console.WriteLine("---------------------");
            //Console.WriteLine("说明:\n 游戏人数 X 2");
            //Console.WriteLine("游戏一方先选择任意一行，拿掉任意数量的纸牌（不允许跨行选择）,双方轮流拿取。");
            //Console.WriteLine("拿到最后一张牌的一方失败。");
            var i = 1;
            foreach (var item in InitGame)
            {
                Console.Write($"第{i}行:\t");
                foreach (var subitem in item)
                {
                    Console.Write(subitem + "\t");
                }
                Console.Write("\n");
                i = i + 1;
            }
            //return true;
        }
    }
}

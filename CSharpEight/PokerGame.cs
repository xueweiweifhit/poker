using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5Demo.CSharpEight
{
    public class PokerGame
    {
        /// <summary>
        /// 输出初始化以后的游戏主界面
        /// </summary>
        /// <param name="InitGame"></param>
        public PokerGame(List<List<string>> InitGame) {            

            var i = 1;
            foreach(var item in InitGame)
            {
                Console.Write($"第{i}行:\t");
                foreach (var subitem in item) {
                    Console.Write(subitem+"\t");
                }
                Console.Write("\n");
                i = i + 1;
            }
            Console.WriteLine("游戏初始化完成.");
        }
        
    }
}

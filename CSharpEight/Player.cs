using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5Demo.CSharpEight
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool PickPoker(List<List<string>> InitGame,List<string> allitem) {
            try
            {
                Console.WriteLine($"\n玩家[{Name}]开始抽牌:");
                if (allitem.Count == 1 )
                {
                    Console.WriteLine($"{Name} Lose :(");
                    return false;
                }
                //Console.WriteLine($"请选择要抽取的行号:");
                var firststep = "";
                while (string.IsNullOrEmpty(firststep) || !new Common().IsNumber(firststep)||int.Parse(firststep)>3)
                {
                    Console.WriteLine($"请{Name}输入抽取行(注意输入合法数字1-3):");
                    firststep = Console.ReadLine();                    
                }
                //Console.WriteLine($"请选择要抽掉的牌，【，】分隔(非中文符号):");
                var secondstep = "";
                while (string.IsNullOrEmpty(secondstep))
                {
                    Console.WriteLine($"请{Name}抽牌,[,]分隔(非中文符号):");
                    secondstep = Console.ReadLine();
                   
                    var selList = secondstep.ToUpper().Split(",");
                    try {
                        foreach (var item in selList)
                        {
                            InitGame[int.Parse(firststep)-1].Remove(item);
                            allitem.Remove(item);
                        }
                        Console.WriteLine("抽取成功");
                        break;
                    } catch(NullReferenceException e) {
                        Console.WriteLine("请{Name}注意，不要跨行选取" + e.Message);
                        secondstep = "";
                    }                    
                }
                return true;
            }
            catch{
                return false;
            }
            
        }
        public void PrintResult(List<List<string>> InitGame) {
            Console.WriteLine("当前剩余牌：\t");
            var i = 1;
            foreach (var item in InitGame)
            {
                Console.Write($"第{i}行:\t");
                if (InitGame[i - 1].Count == 0) {
                    Console.Write("没有啦");
                }
                else
                {
                    foreach (var subitem in item)
                    {
                        Console.Write(subitem+"\t");
                    }
                }                
                Console.Write("\n");
                i = i + 1;
            }
        }

    }
}

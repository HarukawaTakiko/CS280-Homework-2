using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "";
            float number = 000;
            float height = 0.0f;
            float weight = 0.0f;
            string abilities = "";
            string category = "";

            Console.Write("請輸入你的寶可夢名稱:");
            try
            {
                name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("寶可夢編號:");
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("寶可夢身高:");
            try
            {
                height = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("寶可夢體重:");
            try
            {
                weight = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("寶可夢能力:");
            try
            {
                abilities = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.Write("寶可夢類別:");
            try
            {
                category = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.WriteLine("名稱:{0}, 編號:{1}, 身高:{2}, 體重:{3}, 能力:{4}, 類別:{5}", name, number, height, weight, abilities, category);
        }
    }
}
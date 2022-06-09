using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数字あてゲーム
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 0以上１０未満のランダムな数値を作る*/
            Random r = new Random();
            int randomvalue = r.Next(10);


            Console.WriteLine("数当てゲーム\n0から10の数値を入力してください。");
            for (var i = 1; i < 4; i++)
            {
                Console.Write("{0}回目:", i);
                int num = int.Parse(Console.ReadLine());

                /* 数が当たった場合 */
                if (num == randomvalue)
                {
                    Console.WriteLine("グレートですよこいつはァ！");
                    break;
                }
                /* 数が大きかった場合 */
                else if (num > randomvalue)
                {
                    Console.WriteLine("無駄無駄無駄無駄！");
                }
                /* 数が小さかった場合 */
                else if (num < randomvalue)
                {
                    Console.WriteLine("貧弱！貧弱ゥ！");
                }
                /* 試行回数が３回目で数がはずれた場合*/
                if (i == 3 & num != randomvalue)
                {
                    Console.WriteLine("やれやれだぜ (Game Over!)\n正解は{0}", randomvalue);
                }
            }
        }
    }
}

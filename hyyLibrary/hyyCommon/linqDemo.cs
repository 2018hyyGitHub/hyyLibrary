using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hyyModel;

namespace hyyCommon
{
    /// <summary>
    /// LINQ Object
    /// </summary>
    public class linqDemo
    {

        /// <summary>
        /// 过滤操作符 |
        /// 丐帮中级别高于80的大侠
        /// </summary>
        public string linqFunc1(List<MartialArtsMaster>master,List<Kongfu>kongfu) {
            string message1 = "\n\n丐帮中级别高于80的大侠(表达式写法)：\n";
            string message2 = "\n\n丐帮中级别高于80的大侠(扩展方法)：\n";

            //表达式写法
            var GaiBangMater = from m in master
                               where m.Level > 8 && m.Menpai == "丐帮"
                               select m;
            foreach (var m in GaiBangMater)
                message1 += m.Id + "    " + m.Name + "    " + m.Menpai + "    " + m.Kongfu + "    " + m.Level + "\n";


            //扩展方法写法
            var GaiBangMater2 = master.Where(x => x.Level > 8 && x.Menpai == "丐帮");
            foreach (var m in GaiBangMater2)
                message2 += m.Id + "    " + m.Name + "    " + m.Menpai + "    " + m.Kongfu + "    " + m.Level + "\n";

            return message1 + message2;
        }



        /// <summary>
        /// 投影操作符
        /// </summary>
        public string linqFunc2(List<MartialArtsMaster> master, List<Kongfu> kongfu) {
            string message1 = "\n\n武学杀伤力大于90的大侠（表达式写法）：\n";
            string message2 = "\n\n武学杀伤力大于90的大侠（扩展方法）：\n";

            var masterKongfu = from m in master
                               from k in kongfu
                               where (k.Lethality > 90 && m.Kongfu == k.KongfuName)
                               orderby m.Level
                               select m.Id + "    " + m.Name + "    " + m.Menpai + "    " + m.Kongfu + "    " + m.Level + "  ";
            foreach (var m in masterKongfu)
                message1 += m.ToString() + "  \n";


            var masterKongfu2 = master.SelectMany(
                                        k => kongfu,
                                       (m, k) => new { mt = m, kf = k })
                                        .Where(x => x.kf.Lethality > 90 && x.mt.Kongfu == x.kf.KongfuName)
                                        .OrderBy(m => m.mt.Level)
                                        .Select(m => m.mt.Id + "    " + m.mt.Name + "   " + m.mt.Age + "    " + m.mt.Menpai + "    " + m.mt.Kongfu + "    " + m.mt.Level + "    ");
            foreach (var m in masterKongfu2)
                message2 += m.ToString() + "  \n";


            return message1 + message2;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hyyCommon;
using System.IO;
using System.IO.Compression;
using hyyCommon.CompressionHelper;
using hyyModel;

namespace hyyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(string.Format("Welcome hyyLibrary!\n{0}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")));


            /*  Linq
            var master = getMater();
            var kongfu = getKongfu();
            linqDemo demo = new linqDemo();
            Console.Write(demo.linqFunc1(master, kongfu));
            Console.Write(demo.linqFunc2(master, kongfu));
             */

            //DirectoryInfo directorySelected = new DirectoryInfo(CompressionHelper.directoryPath);
            //CompressionHelper.Compress(directorySelected);
            //foreach (FileInfo fileToDecompress in directorySelected.GetFiles("*.cmp"))
            //{
            //    CompressionHelper.Decompress(fileToDecompress);
            //}



            //using (FileStream zipToOpen = new FileStream(@"c:\users\exampleuser\release.zip", FileMode.Open))
            //{
            //    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
            //    {
            //        ZipArchiveEntry readmeEntry = archive.CreateEntry("Readme.txt");
            //        using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
            //        {
            //            writer.WriteLine("Information about this package.");
            //            writer.WriteLine("========================");
            //        }
            //    }
            //}



            Console.ReadLine();
        }

        /// <summary>
        /// 初始化人物
        /// </summary>
        public static List<MartialArtsMaster> getMater()
        {
            var master = new List<MartialArtsMaster>(){
                new MartialArtsMaster(){Id=1,Name="黄蓉",Age=18,Menpai="丐帮",Kongfu="打狗棒法",Level=9},
                new MartialArtsMaster(){Id=2,Name="洪七公",Age=70,Menpai="丐帮",Kongfu="打狗棒法",Level=10},
                new MartialArtsMaster(){Id=3,Name="郭靖",Age=22,Menpai="丐帮",Kongfu="降龙十八掌",Level=10},
                new MartialArtsMaster(){Id=4,Name="任我行",Age=50,Menpai="明教",Kongfu="葵花宝典",Level=1},
                new MartialArtsMaster(){Id=5,Name="东方不败",Age=35,Menpai="明教",Kongfu="葵花宝典",Level=10},
                new MartialArtsMaster(){Id=6,Name="林平之",Age=23,Menpai="华山",Kongfu="葵花宝典",Level=7},
                new MartialArtsMaster(){Id=7,Name="岳不群",Age=50,Menpai="华山",Kongfu="葵花宝典",Level=8}
            };

            return master;
        }
        /// <summary>
        /// 初始化武学
        /// </summary>
        public static List<Kongfu> getKongfu()
        {
            var kongfu = new List<Kongfu>(){
                new Kongfu(){KongfuId=1,KongfuName="打狗棒法",Lethality=90},
                new Kongfu(){KongfuId=2,KongfuName="降龙十八掌",Lethality=95},
                new Kongfu(){KongfuId=3,KongfuName="葵花宝典",Lethality=100}                
            };
            return kongfu;
        }

    }
}

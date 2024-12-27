using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint5.Task1.V20.Lib;

namespace Tyuiu.MaslennikovVA.Sprint5.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\vladm\source\repos\Tyuiu.MaslennikovVA.Sprint5\Tyuiu.MaslennikovVA.Sprint5.Task1.V20\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
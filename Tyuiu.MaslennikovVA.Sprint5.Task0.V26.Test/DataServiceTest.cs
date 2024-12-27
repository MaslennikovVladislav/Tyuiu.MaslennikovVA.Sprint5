using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.MaslennikovVA.Sprint5.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\vladm\source\repos\Tyuiu.MaslennikovVA.Sprint5\Tyuiu.MaslennikovVA.Sprint5.Task0.V26\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
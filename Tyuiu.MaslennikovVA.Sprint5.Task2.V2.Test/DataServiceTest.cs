﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint5.Task2.V2.Lib;

namespace Tyuiu.MaslennikovVA.Sprint5.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\vladm\source\repos\Tyuiu.MaslennikovVA.Sprint5\Tyuiu.MaslennikovVA.Sprint5.Task2.V2\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
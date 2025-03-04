﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint5.Task3.V14.Lib;

namespace Tyuiu.MaslennikovVA.Sprint5.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\vladm\source\reposit\Tyuiu.MaslennikovVA.Sprint5\Tyuiu.MaslennikovVA.Sprint5.Task3.V14\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
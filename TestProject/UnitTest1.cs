﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestJenkins;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Hello World", Program.CreateMessage());
        }
    }
}

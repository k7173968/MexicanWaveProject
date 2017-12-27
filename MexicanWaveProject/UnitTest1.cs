using System;
using System.Collections.Generic;
using MexicanWaveProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using CollectionAssert = Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert;

namespace MexicanWave
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Kata kata = new Kata();
            var result = new List<string> { };
            CollectionAssert.AreEqual(result, kata.Wave(""), "it should return '" + result + "'");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "H" };
            CollectionAssert.AreEqual(result, kata.Wave("h"), "it should return '" + result + "'");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "He", "hE" };
            CollectionAssert.AreEqual(result, kata.Wave("he"), "it should return '" + result + "'");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "H e", "h E" };
            CollectionAssert.AreEqual(result, kata.Wave("h e"), "it should return '" + result + "'");
        }

        [TestMethod]
        public void TestMethod5()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "$He", "$hE" };
            CollectionAssert.AreEqual(result, kata.Wave("$he"), "it should return '" + result + "'");
        }
        [TestMethod]
        public void BasicTest1()
        {
            Kata kata = new Kata();
            List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
            CollectionAssert.AreEqual(result, kata.Wave("hello"), "it should return '" + result + "'");
        }
    }
}

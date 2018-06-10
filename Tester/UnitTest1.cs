using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kattis;

namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumbersCount_ExpectingYes()
        {
            string expected = "YES";
            string result = "";

            int i = 3;

                int a = 911;
                int b = 97625999;
                int c = 91125426;

            var numbers = new HashSet<int>() { a, b ,c };

            if (numbers.Count != i)
            {
                result = "NO";
            }

            if (numbers.Count == i)
            {
                result = "YES";
            }

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestNumbersCount_ExpectingNo()
        {
            string expected = "NO";
            string result = "";

            int i = 3;

            int a = 911;
            int b = 97625999;
            int c = 97625999;

            var numbers = new HashSet<int>() { a, b, c };

            if (numbers.Count != i)
            {
                result = "NO";
            }

            if (numbers.Count == i)
            {
                result = "YES";
            }

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestIndexSetter_ExpectingYes()
        {
            string expected = "YES";
            string result = "";

            int i = 5;

            var numbers = new HashSet<int>();

            numbers.Add(113);
            numbers.Add(12340);
            numbers.Add(123440);
            numbers.Add(12345);
            numbers.Add(98346);

            if (numbers.Count != i)
            {
                result = "NO";
            }

            if (numbers.Count == i)
            {
                result = "YES";
            }

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void IsListLengthLessThanTestNumbers_ExpectedFalse()
        {
            bool expected = false;

            int i = 5;

            var numbers = new List<int>();

            numbers.Add(113);
            numbers.Add(12340);
            numbers.Add(123440);
            numbers.Add(12345);
            numbers.Add(98346);

            bool result = MediumKattis.IsListLessThanTestNumbers(numbers, i);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void IsListLengthLessThanTestNumbers_ExpectedTrue()
        {
            bool expected = true;

            int i = 5;

            var numbers = new List<int>();

            numbers.Add(113);
            numbers.Add(12340);
            numbers.Add(123440);
            numbers.Add(12345);


            bool result = MediumKattis.IsListLessThanTestNumbers(numbers, i);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void DoAnyNumbersMatch_ExpectedFalse()
        {
            bool expected = false;

            var numbers = new List<string>();

            numbers.Add("111");
            numbers.Add("222");
            numbers.Add("333");
            numbers.Add("444");
            numbers.Add("555");

            bool result = MediumKattis.DoAnyNumbersMatch(numbers);

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void DoAnyNumbersMatch_ExpectedTrue()
        {
            bool expected = true;

            var numbers = new List<string>();

            numbers.Add("1111");
            numbers.Add("2222");
            numbers.Add("3333");
            numbers.Add("11113");
            numbers.Add("4444");


            bool result = MediumKattis.DoAnyNumbersMatch(numbers);

            Assert.AreEqual(expected, result);

        }


    }
}

﻿using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Ntwali()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Ntwali()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Ntwali()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [Test]
        public void Subtract_Valid_Ntwali()
        {
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(2, Program.Subtract("5", "3"));
            Assert.AreEqual(3, Program.Subtract("8", "5"));
        }

        [Test]
        public void Subtract_Invalid_Ntwali()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Multiply_Valid_Ntwali()
        {
            Assert.AreEqual(6, Program.Multiply("2", "3"));
            Assert.AreEqual(15, Program.Multiply("5", "3"));
            Assert.AreEqual(35, Program.Multiply("7", "5"));
        }

        [Test]
        public void Multiply_Invalid_Ntwali()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("2", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "3"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Divide_Valid_Ntwali()
        {
            Assert.AreEqual(2, Program.Divide("6", "3"));
            Assert.AreEqual(5, Program.Divide("15", "3"));
            Assert.AreEqual(7, Program.Divide("35", "5"));
        }

        [Test]
        public void Divide_Invalid_Ntwali()
        {
            Assert.Throws<FormatException>(() => Program.Divide("6", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "3"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Power_Valid_Ntwali()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(27, Program.Power("3", "3"));
            Assert.AreEqual(125, Program.Power("5", "3"));
        }

        [Test]
        public void Power_Invalid_Ntwali()
        {
            Assert.Throws<FormatException>(() => Program.Power("2", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "3"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }
    }
}

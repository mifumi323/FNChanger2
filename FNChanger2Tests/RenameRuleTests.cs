using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FNChanger2.Tests
{
    [TestClass()]
    public class RenameRuleTests
    {
        [TestMethod()]
        public void ApplyNoEffectTest()
        {
            var renameRule = new RenameRule();
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\Tofu on FIRE.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveLeftLengthTest()
        {
            var renameRule = new RenameRule()
            {
                RemoveLeftLength = 5
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\on FIRE.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddLeftTest()
        {
            var renameRule = new RenameRule()
            {
                AddLeft = "The "
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\The Tofu on FIRE.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveRightLengthTest()
        {
            var renameRule = new RenameRule()
            {
                RemoveRightLength = 5
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\Tofu on.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddRightTest()
        {
            var renameRule = new RenameRule()
            {
                AddRight = " : The Movie"
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\Tofu on FIRE : The Movie.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReplaceTest()
        {
            var renameRule = new RenameRule()
            {
                ReplaceFrom = "on",
                ReplaceTo = "Loves"
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\Tofu Loves FIRE.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReplaceToEmptyTest()
        {
            var renameRule = new RenameRule()
            {
                ReplaceFrom = "on "
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\Tofu FIRE.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReplaceRegexTest()
        {
            var renameRule = new RenameRule()
            {
                ReplaceFrom = @"^(\S+)(\s\S+\s)(\S+)$",
                ReplaceTo = "$3$2$1",
                ReplaceRegex = true
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\FIRE on Tofu.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ReplaceNotRegexTest()
        {
            var renameRule = new RenameRule()
            {
                ReplaceFrom = ".",
                ReplaceTo = "X"
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\Tofu on FIRE.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RandomTest()
        {
            var renameRule = new RenameRule()
            {
                AddLeft = "<random> ",
                AddRight = " <random>",
                Random = new Random(323)
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\46961975 Tofu on FIRE 46961975.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Random0Test()
        {
            var renameRule = new RenameRule()
            {
                AddLeft = "<random-0> ",
                AddRight = " <random-0>",
                Random = new Random(323)
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            Assert.ThrowsException<ArgumentException>(() => renameRule.Apply(input));
        }

        [TestMethod()]
        public void Random1Test()
        {
            var renameRule = new RenameRule()
            {
                AddLeft = "<random-1> ",
                AddRight = " <random-1>",
                Random = new Random(323)
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\4 Tofu on FIRE 4.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Random9Test()
        {
            var renameRule = new RenameRule()
            {
                AddLeft = "<random-9> ",
                AddRight = " <random-9>",
                Random = new Random(323)
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\469619753 Tofu on FIRE 469619753.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Random10Test()
        {
            var renameRule = new RenameRule()
            {
                AddLeft = "<random-10> ",
                AddRight = " <random-10>",
                Random = new Random(323)
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\4696197535 Tofu on FIRE 4696197535.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Random99Test()
        {
            var renameRule = new RenameRule()
            {
                AddLeft = "<random-99> ",
                AddRight = " <random-99>",
                Random = new Random(323)
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\469619753591538841541143613500227770035927098827876353628340387486239982938043986380308996255866809 Tofu on FIRE 469619753591538841541143613500227770035927098827876353628340387486239982938043986380308996255866809.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Random100Test()
        {
            var renameRule = new RenameRule()
            {
                AddLeft = "<random-100> ",
                AddRight = " <random-100>",
                Random = new Random(323)
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            Assert.ThrowsException<ArgumentException>(() => renameRule.Apply(input));
        }

        [TestMethod()]
        public void WordCaseTest()
        {
            var renameRule = new RenameRule()
            {
                Case = RenameRule.CaseRule.Word
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\Tofu On Fire.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void UpperCaseTest()
        {
            var renameRule = new RenameRule()
            {
                Case = RenameRule.CaseRule.Upper
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\TOFU ON FIRE.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LowerCaseTest()
        {
            var renameRule = new RenameRule()
            {
                Case = RenameRule.CaseRule.Lower
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\tofu on fire.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WithExtensionTest()
        {
            var renameRule = new RenameRule()
            {
                WithExtension = true,
                Case = RenameRule.CaseRule.Upper
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\Directory\TOFU ON FIRE.TXT";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void WithDirectoryTest()
        {
            var renameRule = new RenameRule()
            {
                WithDirectory = true,
                Case = RenameRule.CaseRule.Upper
            };
            var input = @"C:\Directory\Tofu on FIRE.txt";
            var expected = @"C:\DIRECTORY\TOFU ON FIRE.txt";
            var actual = renameRule.Apply(input);
            Assert.AreEqual(expected, actual);
        }
    }
}

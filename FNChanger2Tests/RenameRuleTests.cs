using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

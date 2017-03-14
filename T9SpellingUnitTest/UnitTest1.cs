using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using T9Spelling;

namespace T9SpellingUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReplacerTest()
        {
            var input = new string[] { "hi", "yes", "foo  bar", "hello world" };
            var expectedOutput = new string[] { "44 444", "999337777", "333666 6660 022 2777", "4433555 555666096667775553" };
            var actualOutput = input.Select(x => Program.Replacer(x)).ToArray();
            CollectionAssert.AreEqual(expectedOutput, actualOutput);
        }
    }
}

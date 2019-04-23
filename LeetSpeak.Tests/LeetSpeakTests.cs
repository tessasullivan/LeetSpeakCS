using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
    [TestClass]
    public class LeetSpeakTest
    {
        [TestMethod]
        public void Translate_LetterEntered_e_ReplacedWith3()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("3", testLeetSpeak.Translate("e"));
        }
    }
}
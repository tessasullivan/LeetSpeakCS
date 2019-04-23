using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
    [TestClass]
    public class LeetSpeakTest
    {
        [TestMethod]
        public void Translate_LetterProcessed_e_ReplacedWith3()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("3", testLeetSpeak.Translate("e"));
        }
        [TestMethod]
        public void Translate_LetterProcessed_o_ReplacedWith0()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("0", testLeetSpeak.Translate("o"));
        }
        [TestMethod]
        public void Translate_LetterProcessed_I_ReplacedWith1()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("1", testLeetSpeak.Translate("I"));
        }
        [TestMethod]
        public void Translate_LetterProcessed_t_ReplacedWith7()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("7", testLeetSpeak.Translate("t"));
        }
        [TestMethod]
        public void Translate_LetterProcessedNotAtBeginningOfWord_s_ReplacedWithz()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("iz", testLeetSpeak.Translate("is"));
        }
        [TestMethod]
        public void Translate_WordStartsWith_s_ReplacedWithz()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("s37", testLeetSpeak.Translate("set"));
        }
    }
}
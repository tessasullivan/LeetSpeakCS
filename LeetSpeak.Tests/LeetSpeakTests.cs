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
        public void Translate_LetterProcessed_E_ReplacedWith3()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("3", testLeetSpeak.Translate("E"));
        }

        [TestMethod]
        public void Translate_LetterProcessed_o_ReplacedWith0()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("0", testLeetSpeak.Translate("o"));
        }
        [TestMethod]
        public void Translate_LetterProcessed_O_ReplacedWith0()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("0", testLeetSpeak.Translate("O"));
        }
        [TestMethod]
        public void Translate_LetterProcessed_I_ReplacedWith1()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("1", testLeetSpeak.Translate("I"));
        }

        [TestMethod]
        public void Translate_LetterProcessed_i_NotReplaced()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("i", testLeetSpeak.Translate("i"));
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
        public void Translate_InputStartsWith_s_NotReplaced()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("s37", testLeetSpeak.Translate("set"));
        }
        [TestMethod]
        public void Translate_WordStartsWith_s_NotReplaced()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("h3ll0 s0ng", testLeetSpeak.Translate("hello song"));
        }

        [TestMethod]
        public void Translate_WordWithSeveralReplacementsToMake_WordWithSeveralReplacementsMade()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("3pic0duz", testLeetSpeak.Translate("Epicodus"));
        }

        [TestMethod]
        public void Translate_PhraseWithSeveralReplacementsToMake_PhraseWithSeveralReplacementsMade()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak();
            Assert.AreEqual("D0n'7 y0u l0v3 7h3z3 'S7ring' 3x3rciz3z? 1 d0!", testLeetSpeak.Translate("Don't you love these 'String' exercises? I do!"));
        }
    }
}
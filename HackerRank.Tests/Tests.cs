using NUnit.Framework;
using HackerRank;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("climbing-the-leaderboard")]
        [TestCase(new int[] { 100, 100, 50, 40, 40, 20, 10 }, new int[] { 5, 25, 50, 120 }, ExpectedResult = new int[] { 6, 4, 2, 1 })]
        [TestCase(new int[] { 100, 90, 90, 80, 75, 60 }, new int[] { 50, 65, 77, 90, 102 }, ExpectedResult = new int[] { 6, 5, 4, 2, 1 })]
        public int[] HackerRank_Problems_ClimbingTheLeaderboard(int[] scores, int[] alice)
        {
            return Problems.ClimbingLeaderboard(scores, alice);
        }

        [Test]
        [Category("morgan-and-a-string")]
        //[TestCase("JACK", "DANIEL", ExpectedResult = "DAJACKNIEL")]
        //[TestCase("ABACABA", "ABACABA", ExpectedResult = "AABABACABACABA")]
        //[TestCase("B", "D", ExpectedResult = "BD")]
        //[TestCase("C", "Z", ExpectedResult = "CZ")]
        //[TestCase("C", "ZA", ExpectedResult = "CZA")]
        //[TestCase("CAAAAAA", "Z", ExpectedResult = "CAAAAAAZ")]
        [TestCase("DAD", "DAD", ExpectedResult = "DADADD")]
        [TestCase("ABCBA", "BCBA", ExpectedResult = "ABBCBACBA")]
        [TestCase("BAC", "BAB", ExpectedResult = "BABABC")]
        [TestCase("DAD", "DABC", ExpectedResult = "DABCDAD")]
        [TestCase("YZYYZYZYY", "ZYYZYZYY", ExpectedResult = "YZYYZYYZYZYYZYZYY")]
        public string HackerRank_Problems_MorganAndString(string a, string b)
        {
            return Problems.MorganAndString(a, b);
        }
    }
}
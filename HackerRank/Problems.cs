using System;

namespace HackerRank
{
    public static class Problems
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
        /// </summary>
        /// <param name="scores"></param>
        /// <param name="alice"></param>
        /// <returns></returns>
        public static int[] ClimbingLeaderboard(int[] scores, int[] alice)
        {
            int currentPosition = 1;
            int currentAliceValue = alice[alice.Length - 1];
            int currentScoreValue = scores[0];
            int[] positionArray = new int[alice.Length];

            for(int aliceIndex = alice.Length - 1, scoreIndex = 1; aliceIndex >= 0;)
            {
                if(currentAliceValue >= currentScoreValue)
                {
                    positionArray[aliceIndex] = currentPosition;
                    if (aliceIndex == 0) break;
                    currentAliceValue = alice[--aliceIndex];
                    continue;
                }

                if (scoreIndex >= scores.Length)
                {
                    currentScoreValue = 0;
                    currentPosition++;
                }
                if (currentScoreValue == 0) continue;

                if (scoreIndex == scores.Length - 1)
                {
                    currentScoreValue = scores[scoreIndex];
                    currentPosition++;
                    scoreIndex++;
                    continue;
                }

                int scoreValue = scores[scoreIndex];
                if(currentScoreValue != scoreValue)
                {
                    currentPosition++;
                }
                currentScoreValue = scoreValue;
                scoreIndex++;
            }
           
            return positionArray;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/morgan-and-a-string/problem
        /// </summary>
        public static string MorganAndString(string a, string b)
        {
            int str1Index = 0;
            int str2Index = 0;
            int charIndex = 0;
            char str1Char = a[str1Index];
            char str2Char = b[str2Index];
            char[] value = new char[a.Length + b.Length];

            while (charIndex < value.Length)
            {
                var result = str1Char.CompareTo(str2Char);

                if(result == 0)
                {
                    string.Compare()
                }

                if(result < 0)
                {
                    value[charIndex++] = str1Char;
                    //str1Char = str1Index == a.Length - 1 ? char.MaxValue : a[++str1Index];

                    if (str1Index == a.Length - 1)
                        str1Char = char.MaxValue;
                    else
                        str1Char = a[++str1Index];


                    continue;
                }

                if(result > 0)
                {
                    value[charIndex++] = str2Char;
                    //str2Char = str2Index == b.Length - 1 ? char.MaxValue : b[++str2Index];
                    if (str2Index == b.Length - 1)
                        str2Char = char.MaxValue;
                    else
                    {
                        str2Char = b[++str2Index];
                        if(str2Index == 21)
                        {
                            string test = "";
                        }
                    }
                    continue;
                }
            }

            return new string(value);
        }
    }
}

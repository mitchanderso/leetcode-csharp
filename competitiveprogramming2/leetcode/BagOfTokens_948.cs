
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class BagOfTokens_948
    {
        public int BagOfTokensScore(int[] tokens, int power)
        {
            int score = 0;
            List<int> tokenList = new List<int>();
            tokenList.AddRange(tokens);
            
            tokenList.Sort();
            bool bothPathsUseless = false;

            while (!bothPathsUseless)
            {
                // Face up
                bool noFaceUp = true;
                bool noFaceDown = true;
                while (tokenList.Count > 0 && power >= tokenList[0])
                {
                    int powerAdd = tokenList.First();
                    tokenList.RemoveAt(0);
                    score += 1;
                    power -= powerAdd;
                    noFaceUp = false;
                }

                // Face down
                if (tokenList.Count > 1 && power < tokenList[0] && score > 0)
                {
                    int powerAdd = tokenList.Last();
                    tokenList.RemoveAt(tokenList.Count - 1);
                    score -= 1;
                    power += powerAdd;
                    noFaceDown = false;
                }

                if (noFaceDown && noFaceUp) bothPathsUseless = true;
            }
            
            
            
            return score;
        }
        
    }
    

}


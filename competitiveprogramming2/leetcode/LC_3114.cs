
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace competitiveprogramming.leetcode
{
    public class LC_3114
    {
        
        public string FindLatestTime(string s)
        {
            char[] schars = s.ToCharArray();
            
            if (schars[0] == '?'){
                if (schars[1] == '?')
                {
                    schars[0] = '1';
                    schars[1] = '1';
                }
                else if (schars[1] == '1')
                {
                    schars[0] = '1';
                }
                else if (schars[1] == '0')
                {
                    schars[0] = '1';
                }
                else
                {
                    schars[0] = '0';
                }
            }
            
            if (schars[1] == '?'){
                if (schars[0] == '0')
                {
                    schars[1] = '9';
                }
                else
                {
                    schars[1] = '1';
                }
            }
            
            if (schars[3] == '?')
            {
                schars[3] = '5';
            }

            if (schars[4] == '?') schars[4] = '9';
            
            
            
            
            return new string(schars);
        }
    }


}


/*
Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the order of characters. No two characters may map to the same character, but a character may map to itself.

 

Example 1:

Input: s = "egg", t = "add"
Output: true
*/

public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> map1 = new Dictionary<char, char>();
            Dictionary<char, bool> map2 = new Dictionary<char, bool>();

         
                char[] ch1 = s.ToCharArray();
                char[] ch2 = t.ToCharArray();
             

            for (int i = 0; i <ch1.Length ; i++)
            {
                if (map1.ContainsKey(ch1[i])){
                    
                    if (map1.TryGetValue(ch1[i], out char value) && value != ch2[i])
                    {
                        return false;
                    }
                }

                    else
                    {
                        if (map2.ContainsKey(ch2[i]))
                            return false;

                        else
                        {
                            map1.Add(ch1[i], ch2[i]);
                            map2.Add(ch2[i],true);
                        }
                    }
            }

            return true;
    }
}
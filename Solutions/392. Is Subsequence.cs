/*
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
*/

public class Solution {
    
    public bool IsSubsequence(string s, string t) {
        
        if(s.Length==0)
            return true;
        
        int subsequence_pointer=0;
        int target_pointer=0;
        
        while(target_pointer< t.Length){
            
            if(t[target_pointer]==s[subsequence_pointer]){
                subsequence_pointer++;
                
                if(subsequence_pointer==s.Length)
                    return true;
            }
            
            target_pointer++;
        }
        
        
        return false;
          
    }
    
    
}
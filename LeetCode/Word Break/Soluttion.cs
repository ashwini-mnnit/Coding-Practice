public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> dict = new HashSet<string>();
        
        foreach(string word in wordDict)
        {
            dict.Add(word);
        }
        
        return WordBreakUtil(s , dict);
    }
    
    private bool WordBreakUtil(string s, HashSet<string> dict)
    {
        
        bool[] cache= new bool[s.Length+1];
        
        cache[0] = true;
        for(int i= 0 ;i<=s.Length;i++)
        {
            for(int j=0;j<i;j++)
            {
                if(cache[j]== true  && dict.Contains(s.Substring(j, i-j)))
                {
                    cache[i]= true; 
                }
                   
            }
        }
        
        return cache[s.Length];
        
    }
}
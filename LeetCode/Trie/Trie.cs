using System.Collections.Generic;
namespace Trie {
    public class TrieNode {
        public string word;
        public Dictionary<char, TrieNode> childs;

        public TrieNode () {
            this.word = string.Empty;
            this.childs = new Dictionary<char, TrieNode> ();
        }

        public bool IsLeaf {
            get {
                return word.Equals (string.Empty);
            }
        }
    }

    public class Trie {
        private TrieNode root;

        /** Initialize your data structure here. */
        public Trie () {
            this.root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert (string word) {
            //if root null
            TrieNode temp = root;

            foreach (char c in word) {
                if (temp.childs.ContainsKey (c)) {
                    temp = temp.childs[c];
                    continue;
                }

                temp.childs.Add (c, new TrieNode ());
                temp = temp.childs[c];
            }

            temp.word = word;
        }

        /** Returns if the word is in the trie. */
        public bool Search (string word) {
            //if root null
            if (root == null) {
                return false;
            }
            TrieNode temp = root;
            foreach (char c in word) {
                if (temp.childs.ContainsKey (c)) {
                    temp = temp.childs[c];
                    continue;
                }

                return false;
            }

            return temp.word.Equals(word);
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith (string prefix) {
             //if root null
            if (root == null) {
                return false;
            }
            TrieNode temp = root;
            foreach (char c in prefix) {
                if (temp.childs.ContainsKey (c)) {
                    temp = temp.childs[c];
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}
/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
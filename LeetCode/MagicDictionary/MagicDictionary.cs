using System.Collections.Generic;

namespace MagicDictionary {
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

    public class MagicDictionary {
        private TrieNode root;

        /** Initialize your data structure here. */
        public MagicDictionary () {
            this.root = new TrieNode ();
        }

        public void BuildDict(string[] dict) {
            foreach (var word in dict) {
                this.Insert (word);
            }
        }

        /** Inserts a word into the trie. */
        private void Insert (string word) {
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

            return temp.word.Equals (word);
        }
    }
}
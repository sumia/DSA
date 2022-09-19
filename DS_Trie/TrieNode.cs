using System.Collections.Generic;
using System.Linq;

namespace DS_Trie
{
    public class TrieNode
    {
        public char ch { get; set; }
        public Dictionary<char, TrieNode> children { get; set; }
        public bool isWord { get; set; }

        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
        }

        public TrieNode(char ch) : this()
        {
            this.ch = ch;
        }

        public void Insert(string word)
        {
            if (string.IsNullOrEmpty(word)) return;

            char firstChar = word.ElementAt(0);

            TrieNode child;

            if (children.ContainsKey(firstChar)) {
                child = children[firstChar];
            } else
            {
                child = new TrieNode(firstChar);
                children.Add(firstChar, child);
            }

            if (word.Length > 1)
            {
                child.Insert(word.Substring(1));
            }
            else
                child.isWord = true;
        }
    }
}

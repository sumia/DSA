using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DS_Trie
{
    public class Trie
    {
        private TrieNode root;

        public Trie(List<string> words) 
        {
            root = new TrieNode();
            foreach(var word in words)
            {
                root.Insert(word);
            }
        }

        public bool Find(string prefix)
        {
            return Find(prefix, false);
        }

        private bool Find(string prefix, bool exact)
        {
            TrieNode lastNode = root;

            foreach(var ch in prefix.ToCharArray())
            {
                if (lastNode.children.ContainsKey(ch))
                {
                    lastNode = lastNode.children[ch];
                }
                else
                {
                    return false;
                }
                
            }

            return !exact || lastNode.isWord;
        }

        public List<string> Suggest(string prefix)
        {
            var list = new List<string>();
            TrieNode lastNode = root;
            var sb = new StringBuilder();

            foreach(var ch in prefix.ToCharArray())
            {
                if(lastNode.children.ContainsKey(ch))
                {
                    lastNode = lastNode.children[ch];
                } else
                {
                    return list;
                }

                sb.Append(ch);
            }

            SuggestHelper(lastNode, list, sb);
            return list;
        }



        private void SuggestHelper(TrieNode root, List<string> list, StringBuilder sb)
        {
            if(root.isWord)
            {
                list.Add(sb.ToString());
            }

            if (root.children == null || root.children.Count() == 0)
                return;

            foreach(var child in root.children.Values)
            {
                SuggestHelper(child, list, sb.Append(child.ch));
                sb.Length = sb.Length - 1;
            }
        }
    }
}

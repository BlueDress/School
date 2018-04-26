using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace TextEditor
{
    public class TextEditor : ITextEditor
    {
        private Trie<BigList<char>> usersStrings;
        private Trie<Stack<string>> usersStack;

        public TextEditor()
        {
            this.usersStrings = new Trie<BigList<char>>();
            this.usersStack = new Trie<Stack<string>>();
        }

        public void Clear(string username)
        {
            if (!this.IsLogged(username))
            {
                return;
            }

            SaveLastAmendment(username);
            this.usersStrings.GetValue(username).Clear();
        }

        public void Delete(string username, int startIndex, int length)
        {
            if (!this.IsLogged(username))
            {
                return;
            }

            SaveLastAmendment(username);
            this.usersStrings.GetValue(username).RemoveRange(startIndex, length);
        }

        public void Insert(string username, int index, string str)
        {
            if (!this.IsLogged(username))
            {
                return;
            }

            SaveLastAmendment(username);
            this.usersStrings.GetValue(username).InsertRange(index, str);
        }

        public int Length(string username)
        {
            if (!this.IsLogged(username))
            {
                return -1;
            }

            return this.usersStrings.GetValue(username).Count;
        }

        public void Login(string username)
        {
            this.usersStrings.Insert(username, new BigList<char>());
            this.usersStack.Insert(username, new Stack<string>());
        }

        public void Logout(string username)
        {
            this.usersStrings.Delete(username);
            this.usersStack.Delete(username);
        }

        public void Prepend(string username, string str)
        {
            if (!this.IsLogged(username))
            {
                return;
            }

            SaveLastAmendment(username);
            this.usersStrings.GetValue(username).AddRangeToFront(str);
        }

        public string Print(string username)
        {
            if (!this.IsLogged(username))
            {
                return string.Empty;
            }

            return string.Join("", this.usersStrings.GetValue(username));
        }

        public void Substring(string username, int startIndex, int length)
        {
            if (!this.IsLogged(username))
            {
                return;
            }

            SaveLastAmendment(username);

            var subString = this.usersStrings.GetValue(username).GetRange(startIndex, length);
            this.usersStrings.GetValue(username).Clear();
            this.usersStrings.GetValue(username).AddRange(subString);
        }

        public void Undo(string username)
        {
            if (!this.IsLogged(username) || this.usersStack.GetValue(username).Count == 0)
            {
                return;
            }

            this.usersStrings.GetValue(username).Clear();
            this.usersStrings.GetValue(username).AddRange(this.usersStack.GetValue(username).Pop());
        }

        public IEnumerable<string> Users(string prefix = "")
        {
            return this.usersStrings.GetByPrefix(prefix);
        }

        private bool IsLogged(string username)
        {
            return this.usersStrings.Contains(username);
        }
        
        private void SaveLastAmendment(string username)
        {
            this.usersStack.GetValue(username).Push(string.Join("", this.usersStrings.GetValue(username)));
        }
    }
}

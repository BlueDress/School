using System.Collections.Generic;

namespace Collection_Hierarchy
{
    public abstract class Collection
    {
        public Collection()
        {
            this.StringCollection = new List<string>();
        }

        public List<string> StringCollection;
    }
}

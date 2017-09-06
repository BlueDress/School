using System;

namespace Inferno_Infinity
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        public CustomAttribute(string author, int revision, string description, string reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = reviewers;
        }

        public string Author { get; }

        public int Revision { get; }

        public string Description { get; }

        public string Reviewers { get; }
    }
}

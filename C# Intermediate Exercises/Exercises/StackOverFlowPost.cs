using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Intermediate_Exercises.Exercises
{
    internal class StackOverFlowPost
    {
        public String Title { get; private set; }
        public String Description { get; private set; }
        public DateTime CreationTime { get; private set; }
        public int VoteCount { get; private set; }

        public void CreatePost(string title, string description)
        {
            if (String.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title Cannot be Empty");
            }
            if (String.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Description Cannot be Empty");
            }
            Title = title;
            Description = description;
            CreationTime = DateTime.Now;
            VoteCount = 0;
        }
        public void UpVote() => VoteCount++;
        public void DownVote() => VoteCount--;
    }
}

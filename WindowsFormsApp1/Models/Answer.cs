using System;
using System.Collections.Generic;
using System.Text;

namespace GehaOverFlow.Models
{
    public class Answer : IIndexable, ISubmittable, IVotable
    {
        #region private fields
        
        int id;
        string body;
        DateTime postDate;
        User author;
        int upvotes, downvotes;

        List<Comment> comments;
        #endregion

        #region public props

        public int Id { get { return id; } set { id = value; } }
        public string Body { get { return body; } set { body = value; } }
        public DateTime PostDate { get { return postDate; } set { postDate = value; } }
        public User Author { get { return author; } set { author = value; } }
        public int Upvotes { get { return upvotes; } set { upvotes = value; } }
        public int Downvotes { get { return downvotes; } set { downvotes = value; } }

        public List<Comment> Comments { get { return comments; } set { comments = value; } }

        #endregion

        public Answer()
        {

        }
    }
}

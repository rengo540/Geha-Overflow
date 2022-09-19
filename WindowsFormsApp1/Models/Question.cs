using System;
using System.Collections.Generic;

namespace GehaOverFlow.Models
{
    public class Category
    {

    }
    public class Question : IIndexable, ISubmittable, IVotable
    {
        #region private fields

        int id;
        string body;
        DateTime postDate;
        User author;
        int upvotes, downvotes;

        string title, category;

        List<Answer> answers;
        Answer acceptedAnswer;

        List<Comment> comments;

        #endregion

        #region public props

        public int Id { get { return id; } set { id = value; } }
        public string Body { get { return body; } set { body = value; } }
        public DateTime PostDate { get { return postDate; } set { postDate = value; } }
        public User Author { get { return author; } set { author = value; }  }
        public int Upvotes { get { return upvotes; } set { upvotes = value; } }
        public int Downvotes { get { return downvotes; } set { downvotes = value; } }

        public string Title { get { return title; } set { title = value;   } }
        public string Category { get { return category; } set { category = value;   } }

        public List<Answer> Answers { get { return answers; } set { answers = value; } }
        public Answer AcceptedAnswer { get { return acceptedAnswer; } set { acceptedAnswer = value; } }

        public List<Comment> Comments { get { return comments; } set { comments = value; } }

        #endregion

        public Question()
        {

        }
    }
}

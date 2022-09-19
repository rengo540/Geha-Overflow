using System;
using System.Collections.Generic;
using System.Text;

namespace GehaOverFlow.Models
{
    public class Comment:IIndexable, ISubmittable
    {
        #region private fields

        int id;
        string body;
        DateTime postDate;
        User author;

        #endregion

        #region public props

        public int Id { get { return id; } set { id = value; } }
        public string Body { get { return body; } set { body = value; } }
        public DateTime PostDate { get { return postDate; } set { postDate = value; } }
        public User Author { get { return author; } set { author = value; } }

        #endregion


        public Comment()
        {

        }
    }
}

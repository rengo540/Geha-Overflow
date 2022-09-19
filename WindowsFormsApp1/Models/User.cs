using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace GehaOverFlow.Models
{
    public class User : IIndexable
    {
        private int id;

        public int Id { get { return id; } set { id = value; } }


        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;
        public string Password
        {
            set { password = value; }
        }

        private bool isAdmin;
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        private int reputation;
        public int Reputation
        {
            get { return reputation; }
            set { reputation = value; }
        }

        private List<Question> questions;
        public List<Question> Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        private List<Answer> answers;
        public List<Answer> Answers
        {
            get { return answers; }
            set { answers = value; }
        }

        public User()
        {
            Questions = new List<Question>();
            Answers = new List<Answer>();
        }

    }
}

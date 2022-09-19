using System;
using System.Collections.Generic;
using System.Text;

namespace GehaOverFlow.Models
{
    interface IVotable
    {
        int Upvotes
        {
            get;
            set;
        }

        int Downvotes
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GehaOverFlow.Models
{
    interface ISubmittable
    {
        string Body
        { get; set; }

        DateTime PostDate
        { get; set; }

        User Author { get; set; }
    }
}
